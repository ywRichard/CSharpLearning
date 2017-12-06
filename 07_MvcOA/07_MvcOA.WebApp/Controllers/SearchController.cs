using _07_MvcOA.Model;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class SearchController : Controller
    {
        IBLL.IBookBLL BookBll { get; set; }
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchContent()
        {
            if (!string.IsNullOrEmpty(Request["btnSearch"]))
            {
                var list = SearchBookContent();
                ViewData["searchList"] = list;
                ViewData["searchWhere"] = Request["txtContent"];//重新递交页面之后，在搜索框中保留搜索的关键字，
                return View("Index");
            }
            else
            {
                CreateSearchIndex();
            }

            return Content("ok");
        }
        /// <summary>
        /// 负责向Lucene.Net中写数据
        /// </summary>
        /// <returns></returns>
        private void CreateSearchIndex()
        {
            var indexPath = @"C:\Users\Victor\Desktop\LuceneNetDir";//注意和磁盘上文件夹的大小写一致，否则会出现报错，将创建的分词内容放在该目录下。
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexPath), new NativeFSLockFactory());//指定索引文件（打开索引目录） FS指的就是FileSystem
            var isUpdate = IndexReader.IndexExists(directory);//IndexReader：对索引进行读取的类。该语句的作用：判断索引库文件夹是否存在以及索引特征文件是否存在。
            if (isUpdate)
            {
                //同时只能有一段代码对索引库进行写操作，当使用IndexWriter打开directory时会自动对索引库文件上锁。
                //如果索引目录被锁定（比如索引过程中程序异常退出），则首先解锁（提示一下：如果我现在正在写着已经加锁了，但是还没有写完，这时候又来一个请求，那么不解锁了吗？这个问题后面解决）
                if (IndexWriter.IsLocked(directory))
                {
                    IndexWriter.Unlock(directory);
                }
            }
            IndexWriter writer = new IndexWriter(directory, new PanGuAnalyzer(), !isUpdate, Lucene.Net.Index.IndexWriter.MaxFieldLength.UNLIMITED);//向索引库中写索引，这时在这里加锁。

            foreach (Book bookModel in BookBll.LoadEntities(b => true))
            {
                Document document = new Document();//表示一篇文档
                                                   //Field.Store.Yes:表示是否储存原值。只有当Field.Store.YES在后面才能用doc.Get("number")取出值来。Field.Index. Not_ANALYZED:不进行分词保存。
                document.Add(new Field("Id", bookModel.Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));//字段名"number"可更改

                //Field.Index.ANALYZED:进行分词保存，也就是将要进行全文搜索的字段设置分词保存（因为要进行模糊查询）
                //Lucene.Net.Documents.Field.TermVector.WITH_POSITION_OFFSETS:不仅保存分词还保存分词的距离，干扰词的数量
                document.Add(new Field("Title", bookModel.Title, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                document.Add(new Field("Content", bookModel.ContentDescription, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                writer.AddDocument(document);
            }

            writer.Dispose();//会自动解锁
            directory.Dispose();//不要忘了close，否则索引结果搜不到
        }

        private List<Models.ViewSearchContentModel> SearchBookContent()
        {
            var indexPath = @"C:\Users\Victor\Desktop\LuceneNetDir";
            var kw = Common.WebCommon.GetPanGuWord(Request["txtContent"]);
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexPath), new NoLockFactory());
            IndexReader reader = IndexReader.Open(directory, true);
            IndexSearcher searcher = new IndexSearcher(reader);
            //搜索条件
            PhraseQuery query = new PhraseQuery();
            foreach (var word in kw)//先用空格，让用户去分词，空格分隔的就是词"计算机   专业"
            {
                query.Add(new Term("body", word));
            }
            //WITH_POSITIONS_OFFSETS -> 盘古分词在建立索引的时候已经将干扰词间距记录，lucene.net只要匹配就可以了
            query.Slop = 100;//多个查询条件词之间的最大距离，在文章中相隔太远也就无意义（例如 “大学生”这个查询条件和“简历”这个查询条件之间如果间隔的词太多也就没有意义了。）
            //TopScoreDocCollector是盛放查询结果的容器
            TopScoreDocCollector collector = TopScoreDocCollector.Create(1000, true);
            searcher.Search(query, null, collector);//根据query查询条件进行查询，查询结果放入cllector容器
            ScoreDoc[] docs = collector.TopDocs(0, collector.TotalHits).ScoreDocs;//得到所有查询结果中的文档，collector.TotalHits:表示总条数；TopDocs(300,20):表示得到300(从300开始)，到320(结束）的文档内容
            var list = new List<Models.ViewSearchContentModel>();
            //可以用来实现分页内容
            for (int i = 0; i < docs.Length; i++)
            {
                //搜索ScoreDoc[]只能获得文档的id，这样不会把查询结果的Document一次性加载到内存中。降低了内存的压力，需要获得文档的详细内容的时候通过searcher.Doc来根据文档id来获得文档的详细内容对象document
                int docId = docs[i].Doc;//得到查询结果文档的id(Lucene内容分配的id)
                Document doc = searcher.Doc(docId);//找到文档id对应的文档详细信息
                list.Add(new Models.ViewSearchContentModel
                {
                    Id = doc.Get("Id"),
                    Title = doc.Get("Title"),
                    Content = Common.WebCommon.CreateHighLight(Request["txtContent"], doc.Get("Content"))
                });
            }

            return list;
        }
    }
}