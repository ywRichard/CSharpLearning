using _07_MvcOA.Model;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace _07_MvcOA.WebApp.Models
{
    public sealed class SearchIndexManager
    {
        private static readonly SearchIndexManager searchIndexManager = new SearchIndexManager();
        private SearchIndexManager()
        {

        }
        /// <summary>
        /// 单例模式的懒汉模式
        /// </summary>
        /// <returns></returns>
        public static SearchIndexManager GetInstance()
        {
            return searchIndexManager;
        }
        Queue<IndexContent> queue = new Queue<IndexContent>();
        /// <summary>
        /// 向队列中写添加数据
        /// </summary>
        public void AddQueue(string id, string title, string content)
        {
            queue.Enqueue(new IndexContent
            {
                Id = id,
                Title = title,
                Content = content,
                LuceneEnum = LuceneEnum.AddType//添加索引
            });
        }
        /// <summary>
        /// 向队列中添加要删除的数据
        /// </summary>
        /// <param name="id"></param>
        public void DeleteQueue(string id)
        {
            queue.Enqueue(new IndexContent
            {
                Id = id,
                LuceneEnum = LuceneEnum.DeleteType//删除索引
            });
        }

        /// <summary>
        /// 开启线程，扫描队列，从队列中读取数据
        /// </summary>
        public void StartThread()
        {
            var myThread = new Thread(WriteIndexContent);
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void WriteIndexContent()
        {
            while (true)
            {
                if (queue.Count > 0)
                {
                    CreateIndexContent();
                }
                else
                {
                    Thread.Sleep(5000);//避免浪费CPU资源
                }
            }
        }

        private void CreateIndexContent()
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

            while (queue.Count > 0)
            {
                var indexContent = queue.Dequeue();//数据出列
                writer.DeleteDocuments(new Term("Id", indexContent.Id.ToString()));

                if (indexContent.LuceneEnum == LuceneEnum.DeleteType)
                {
                    continue;//跳出本次循环，执行下一次while
                }

                var document = new Document();//表示一篇文档
                                              //Field.Store.Yes:表示是否储存原值。只有当Field.Store.YES在后面才能用doc.Get("number")取出值来。Field.Index. Not_ANALYZED:不进行分词保存。
                document.Add(new Field("Id", indexContent.Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));//字段名"number"可更改

                //Field.Index.ANALYZED:进行分词保存，也就是将要进行全文搜索的字段设置分词保存（因为要进行模糊查询）
                //Lucene.Net.Documents.Field.TermVector.WITH_POSITION_OFFSETS:不仅保存分词还保存分词的距离，干扰词的数量
                document.Add(new Field("Title", indexContent.Title, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                document.Add(new Field("Content", indexContent.Content, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                writer.AddDocument(document);
            }

            writer.Dispose();//会自动解锁
            directory.Dispose();//不要忘了close，否则索引结果搜不到
        }
    }
}