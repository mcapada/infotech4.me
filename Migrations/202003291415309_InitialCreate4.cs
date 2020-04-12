namespace It4MEProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.School", "ProgramDesc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.School", "ProgramDesc", c => c.String());
        }
    }
}
