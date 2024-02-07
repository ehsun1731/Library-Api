using FluentMigrator;
using FluentMigrator.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMigration
{


    [Migration(202402062140)]
    public class _202402062140_AddTables : Migration
    {
        public override void Up()
        {
            Create.Table("Author")
                  .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                  .WithColumn("Name").AsString(50).NotNullable();

            Create.Table("Book")
                 .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                 .WithColumn("Title").AsString(50).NotNullable()
                 .WithColumn("AuthorID").AsInt32().ForeignKey("Fk_Book_Author","Author","Id")
                 .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("Fk_Book_User","User","Id")
                 .WithColumn("Count").AsInt32();

            Create.Table("Category")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("BookId").AsInt32().ForeignKey("Fk_Category_Book","Book","Id")
                .WithColumn("Name").AsString(50).NotNullable();

            Create.Table("User")
                  .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                  .WithColumn("Name").AsString(50).NotNullable()
                  .WithColumn("BookCount").AsInt32().NotNullable();


        }

        public override void Down()
        {
            Delete.Table("User");
            Delete.Table("category");
            Delete.Table("Book");
            Delete.Table("Author");

        }
    }
}
