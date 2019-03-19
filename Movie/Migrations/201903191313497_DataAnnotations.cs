namespace Movie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Films", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Films", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Rating", c => c.String());
            AlterColumn("dbo.Films", "Genre", c => c.String());
            AlterColumn("dbo.Films", "Title", c => c.String());
        }
    }
}
