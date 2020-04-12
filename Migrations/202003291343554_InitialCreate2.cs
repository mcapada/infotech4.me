namespace It4MEProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.School", "ProgramName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.School", "ProgramName");
        }
    }
}
