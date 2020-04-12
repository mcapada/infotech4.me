namespace It4MEProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.School", "Campus", c => c.String());
            AddColumn("dbo.School", "ProgramDesc", c => c.String());
            AddColumn("dbo.School", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.School", "Link");
            DropColumn("dbo.School", "ProgramDesc");
            DropColumn("dbo.School", "Campus");
        }
    }
}
