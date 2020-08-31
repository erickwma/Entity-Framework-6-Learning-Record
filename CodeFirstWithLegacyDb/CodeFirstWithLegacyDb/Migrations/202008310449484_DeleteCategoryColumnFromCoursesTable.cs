namespace CodeFirstWithLegacyDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_ID" });
            DropColumn("dbo.Courses", "Category_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Category_ID", c => c.Int());
            CreateIndex("dbo.Courses", "Category_ID");
            AddForeignKey("dbo.Courses", "Category_ID", "dbo.Categories", "ID");
        }
    }
}
