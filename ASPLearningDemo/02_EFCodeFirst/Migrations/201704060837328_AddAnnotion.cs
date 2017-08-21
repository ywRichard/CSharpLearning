namespace _02_EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotion : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Blogs", "SubName", c => c.String());
            AlterColumn("dbo.Blogs", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Name", c => c.String());
            //DropColumn("dbo.Blogs", "SubName");
        }
    }
}
