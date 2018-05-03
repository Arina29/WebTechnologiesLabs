namespace eUseControl.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStyleTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('MODERN')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('CONTEMPORARY')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('MINIMALIST')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('INDUSTRIAL')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('MID-CENTURY MODERN')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('SCANDINAVIAN')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('TRADITIONAL')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('TRANSITIONAL')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('FRENCH-COUNTRY')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('BOHEMIAN')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('RUSTIC')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('SHABBY CHIC')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('HOLLYWOOD GLAM')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('COASTAL')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('ECLECTIC')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('VINTAGE')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('NAUTICAL')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('BOHEMIAN')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('FARMHOUSE')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('URBAN-MODERN')");
            Sql("INSERT INTO StyleTypes (StyleName) VALUES ('CUSTOM-STYLE')");

        }

        public override void Down()
        {
        }
    }
}
