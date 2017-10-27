using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _03_DbTableRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOneToMantRelation();

            //TestManyToManyRelation();
        }

        #region OneToMany
        public static void TestOneToMantRelation()
        {
            using (DbContext context = new OneToManyContext())
            {
                //AddBooks(context);
                //AddBookReviews(context);
                //RemoveBook(context);
                RemoveBookReview(context);
                //MoveEntity(context);
            }
        }
        public static void AddBooks(DbContext context)
        {
            //一对多，集合可以null，但是非集合的导航属性必须赋值。否则会报错
            var list = new List<Book> {
                new Book{ Title="红高粱1"},
                new Book{ Title="红高粱2"}
            };

            context.Set<Book>().AddRange(list);
            var result = "Add Book" + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
            Console.WriteLine("Book count is {0}", context.Set<Book>().Count());
        }
        public static void AddBookReviews(DbContext context)
        {
            var book = context.Set<Book>()
                .Where(b => b.Title == "红高粱2")
                .FirstOrDefault();

            var list = new List<BookReview> {
                new BookReview{ Content="红高粱2很不好看",Book=book},
                new BookReview{ Content="红高粱2不一般般",Book=book}
            };

            context.Set<BookReview>().AddRange(list);
            var result = "Add BookReview" + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
            Console.WriteLine("BookReview count is {0}", context.Set<BookReview>().Count());
        }
        public static void RemoveBook(DbContext context)
        {
            var book = context.Set<Book>()
               .Where(b => b.Title == "红高粱1")
               .FirstOrDefault();

            //由于存在外键关系，必须设置级联删除。否则抛异常
            //删除了主键表中的记录，会将关联的BookReview 全部删除
            //集合删除
            //context.Set<Book>().Remove(book);


            var result = "Remove Book" + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
            Console.WriteLine("Book count is {0}", context.Set<BookReview>().Count());
        }
        public static void RemoveBookReview(DbContext context)
        {

            var book = context.Set<Book>()
               .Where(b => b.Title == "红高粱2")
               .FirstOrDefault();

            #region 删除单个书评
            //删除单个书评，推荐到DbSet<BookReview>中删除
            var bookReview = book.BookReview.FirstOrDefault();//获得想要删除的BookReview
            //集合的扩展方法
            //context.Set<BookReview>().Remove(bookReview);

            //更改entry的方法，在导航属性中删除
            context.Entry(bookReview).State = EntityState.Deleted;
            context.Set<BookReview>().Remove(bookReview);
            #endregion

            #region 批量删除
            //方法1、集合的扩展方法
            //var reviewList = book.BookReview.ToList();//将指定书本的全部书评全部载入内存
            //foreach (var item in reviewList)
            //{
            //    context.Set<BookReview>().Remove(item);//编译器会为每个item生成一条delete指令，如果删除数据多，会有性能的问题。
            //}

            //方法2、直接执行SQL指令
            context.Database.ExecuteSqlCommand("delete from BookReviews where BookId={0}", book.BookId);
            #endregion

            var result = "Remove BookReview" + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
            Console.WriteLine("BookReview count is {0}", context.Set<BookReview>().Count());
        }
        /// <summary>
        /// 在两个实体对象间移动子对象
        /// </summary>
        public static void MoveEntity(DbContext context)
        {
            var book1 = context.Set<Book>().Where(b => b.Title == "红高粱1").FirstOrDefault();
            var book2 = context.Set<Book>().Where(b => b.Title == "红高粱2").FirstOrDefault();
            var bookReview = book2.BookReview.FirstOrDefault();
            book1.BookReview.Add(bookReview);
            book2.BookReview.Remove(bookReview);

            var result = "MoveEntity " + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
            Console.WriteLine("BookReview count is {0}", context.Set<BookReview>().Where(i => i.BookId == 1).Count());
        }
        #endregion

        #region ManyToMany
        public static void TestManyToManyRelation()
        {
            //如果数据库不存在则新建数据库，如果存在则将表插入到已有的数据库中
            using (DbContext context = new ManyToManyContext())
            {
                //AddEntity(context);
                RemoveEntity(context);
            }
        }
        public static void AddEntity(DbContext context)
        {
            var users = new List<User> {
                new User{ UserID=1,UserName="张三"},
                new User{ UserID=2,UserName="李四"},
                new User{ UserID=3,UserName="王五"},
            };

            var roles = new List<Role>
            {
                new Role{ RoleId=1,RoleName="管理员"},
                new Role{ RoleId=1,RoleName="工程师"},
                new Role{ RoleId=1,RoleName="操作员"}
            };

            users[0].Roles = roles;
            users[1].Roles = roles.Skip(1).ToList();
            users[2].Roles = roles.Skip(2).ToList();

            roles[0].Users = users.GetRange(0, 1);
            roles[1].Users = users.GetRange(0, 2);
            roles[2].Users = users;

            context.Set<User>().AddRange(users);
            context.Set<Role>().AddRange(roles);

            var result = "Add Entity" + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
            Console.WriteLine($@"Users' count is {context.Set<User>().Count()}===Roles' count is {context.Set<Role>().Count()}");
        }
        /// <summary>
        /// 在多对多关联任一方对象集合的导航属性中移除某个对象，都需要将两个导航属性的关联项删除。
        /// 否则会造成内存中数据实体数据不一致的问题
        /// </summary>
        public static void RemoveEntity(DbContext context)
        {
            //删除张三管理员权限
            var user = context.Set<User>().Find(1);
            var admin = context.Set<Role>().Find(1);
            user.Roles.Remove(admin);//在张三中删除管理员权限
            admin.Users.Remove(user);//在管理员名单中删除张三

            var result = "Remove ZhangSan's adminstrator" + (context.SaveChanges() > 0 ? "OK" : "NG");
            Console.WriteLine(result);
        }
        #endregion
    }
}
