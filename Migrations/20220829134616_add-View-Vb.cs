using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tourest.Migrations
{
    public partial class addViewVb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
Create View VbToursLocationCategory
as 
SELECT        dbo.TbTours.TourId, dbo.TbTours.isNew, dbo.TbTours.Sale, dbo.TbTours.TourPrice, dbo.TbTours.TourTitel, dbo.TbTours.LocationId, dbo.TbTours.CategoryId, dbo.TbLocation.LocationName, dbo.TbCategores.CategoryName
FROM            dbo.TbCategores INNER JOIN
                         dbo.TbTours ON dbo.TbCategores.CategoryId = dbo.TbTours.CategoryId INNER JOIN
                         dbo.TbLocation ON dbo.TbTours.LocationId = dbo.TbLocation.LocationId
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
