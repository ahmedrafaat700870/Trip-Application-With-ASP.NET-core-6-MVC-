using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tourest.Migrations
{
    public partial class addView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentModels",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentModels", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "TbBlog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BlogCreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BlogCreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBlog", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "TbCategores",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategores", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomer",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomer", x => x.UsersId);
                });

            migrationBuilder.CreateTable(
                name: "TbFAQ",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    Answer = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbFAQ", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TbHomePageImages",
                columns: table => new
                {
                    HomePageImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SubImage1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SubImage2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomePageImages", x => x.HomePageImageId);
                });

            migrationBuilder.CreateTable(
                name: "TbInetegram",
                columns: table => new
                {
                    InstagramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstagramSrc = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    PhotoSrc = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInetegram", x => x.InstagramId);
                });

            migrationBuilder.CreateTable(
                name: "TbInformation",
                columns: table => new
                {
                    InformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InformationPhone = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    InformationEmail = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    FaceBookAccount = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    TwitterAcount = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    InstagramAccount = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    WebSiteName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescriptionInfo = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    LogoImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FooterDescription = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    FooterImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Facx = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInformation", x => x.InformationId);
                });

            migrationBuilder.CreateTable(
                name: "TbInfoTeamPage",
                columns: table => new
                {
                    InfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    PageTitel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PagePhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInfoTeamPage", x => x.InfoId);
                });

            migrationBuilder.CreateTable(
                name: "TbLocation",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbLocation", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "TbLocationHomePage",
                columns: table => new
                {
                    LocationHomePageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbLocationHomePage", x => x.LocationHomePageId);
                });

            migrationBuilder.CreateTable(
                name: "TbReviewBage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    description = table.Column<string>(type: "nvarchar(Max)", maxLength: 250, nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false),
                    disLike = table.Column<int>(type: "int", nullable: false),
                    src = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CretaedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbReviewBage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TbTeamMember",
                columns: table => new
                {
                    TeamMeberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMeberName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TeamMemberPhoto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TeamMebmerJob = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TeamMemberJobDescription = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbTeamMember", x => x.TeamMeberId);
                });

            migrationBuilder.CreateTable(
                name: "TbBlogDescriptoinPhoto",
                columns: table => new
                {
                    BlogPhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPhotoSrc = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BlogDescription = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBlogDescriptoinPhoto", x => x.BlogPhotoId);
                    table.ForeignKey(
                        name: "FK_TbBlogDescriptoinPhoto_TbBlog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "TbBlog",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbTours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isNew = table.Column<bool>(type: "bit", nullable: false),
                    Sale = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    Description = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    TourPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    TourTitel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    VideoSrc = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    LocationHomePageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbTours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_TbTours_TbCategores_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TbCategores",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbTours_TbLocation_LocationId",
                        column: x => x.LocationId,
                        principalTable: "TbLocation",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbTours_TbLocationHomePage_LocationHomePageId",
                        column: x => x.LocationHomePageId,
                        principalTable: "TbLocationHomePage",
                        principalColumn: "LocationHomePageId");
                });

            migrationBuilder.CreateTable(
                name: "TbDepartmentTour",
                columns: table => new
                {
                    DepartmentTourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDepartmentTour", x => x.DepartmentTourId);
                    table.ForeignKey(
                        name: "FK_TbDepartmentTour_DepartmentModels_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DepartmentModels",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbDepartmentTour_TbTours_TourId",
                        column: x => x.TourId,
                        principalTable: "TbTours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbInvoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TbCustomerUsersId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInvoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_TbInvoice_TbCustomer_TbCustomerUsersId",
                        column: x => x.TbCustomerUsersId,
                        principalTable: "TbCustomer",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbInvoice_TbTours_TourId",
                        column: x => x.TourId,
                        principalTable: "TbTours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbPhotos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoSrc = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPhotos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_TbPhotos_TbTours_TourId",
                        column: x => x.TourId,
                        principalTable: "TbTours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbReviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ReviewDescription = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TbCustomerUsersId = table.Column<int>(type: "int", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbReviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_TbReviews_TbBlog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "TbBlog",
                        principalColumn: "BlogId");
                    table.ForeignKey(
                        name: "FK_TbReviews_TbCustomer_TbCustomerUsersId",
                        column: x => x.TbCustomerUsersId,
                        principalTable: "TbCustomer",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbReviews_TbTours_TourId",
                        column: x => x.TourId,
                        principalTable: "TbTours",
                        principalColumn: "TourId");
                });

            migrationBuilder.CreateTable(
                name: "TbTourOption",
                columns: table => new
                {
                    TourOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxPeople = table.Column<int>(type: "int", nullable: false),
                    MinPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    MinAge = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OptionDescription = table.Column<string>(type: "varchar(Max)", maxLength: 250, nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    HourCount = table.Column<int>(type: "int", nullable: false),
                    isSelected = table.Column<bool>(type: "bit", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbTourOption", x => x.TourOptionId);
                    table.ForeignKey(
                        name: "FK_TbTourOption_TbTours_TourId",
                        column: x => x.TourId,
                        principalTable: "TbTours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbbOptionIncluded",
                columns: table => new
                {
                    IncludedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncludedName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    isIncluded = table.Column<bool>(type: "bit", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbbOptionIncluded", x => x.IncludedId);
                    table.ForeignKey(
                        name: "FK_TbbOptionIncluded_TbTourOption_OptionId",
                        column: x => x.OptionId,
                        principalTable: "TbTourOption",
                        principalColumn: "TourOptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbOptionNeeded",
                columns: table => new
                {
                    NeedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tourNeededName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbOptionNeeded", x => x.NeedId);
                    table.ForeignKey(
                        name: "FK_TbOptionNeeded_TbTourOption_OptionId",
                        column: x => x.OptionId,
                        principalTable: "TbTourOption",
                        principalColumn: "TourOptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbBlogDescriptoinPhoto_BlogId",
                table: "TbBlogDescriptoinPhoto",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_TbbOptionIncluded_OptionId",
                table: "TbbOptionIncluded",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TbDepartmentTour_DepartmentId",
                table: "TbDepartmentTour",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TbDepartmentTour_TourId",
                table: "TbDepartmentTour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TbHomePageImages_MainImage",
                table: "TbHomePageImages",
                column: "MainImage",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbHomePageImages_SubImage1",
                table: "TbHomePageImages",
                column: "SubImage1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbInvoice_TbCustomerUsersId",
                table: "TbInvoice",
                column: "TbCustomerUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TbInvoice_TourId",
                table: "TbInvoice",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TbOptionNeeded_OptionId",
                table: "TbOptionNeeded",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TbPhotos_TourId",
                table: "TbPhotos",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TbReviews_BlogId",
                table: "TbReviews",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_TbReviews_TbCustomerUsersId",
                table: "TbReviews",
                column: "TbCustomerUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TbReviews_TourId",
                table: "TbReviews",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TbTourOption_TourId",
                table: "TbTourOption",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TbTours_CategoryId",
                table: "TbTours",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TbTours_LocationHomePageId",
                table: "TbTours",
                column: "LocationHomePageId");

            migrationBuilder.CreateIndex(
                name: "IX_TbTours_LocationId",
                table: "TbTours",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbBlogDescriptoinPhoto");

            migrationBuilder.DropTable(
                name: "TbbOptionIncluded");

            migrationBuilder.DropTable(
                name: "TbDepartmentTour");

            migrationBuilder.DropTable(
                name: "TbFAQ");

            migrationBuilder.DropTable(
                name: "TbHomePageImages");

            migrationBuilder.DropTable(
                name: "TbInetegram");

            migrationBuilder.DropTable(
                name: "TbInformation");

            migrationBuilder.DropTable(
                name: "TbInfoTeamPage");

            migrationBuilder.DropTable(
                name: "TbInvoice");

            migrationBuilder.DropTable(
                name: "TbOptionNeeded");

            migrationBuilder.DropTable(
                name: "TbPhotos");

            migrationBuilder.DropTable(
                name: "TbReviewBage");

            migrationBuilder.DropTable(
                name: "TbReviews");

            migrationBuilder.DropTable(
                name: "TbTeamMember");

            migrationBuilder.DropTable(
                name: "DepartmentModels");

            migrationBuilder.DropTable(
                name: "TbTourOption");

            migrationBuilder.DropTable(
                name: "TbBlog");

            migrationBuilder.DropTable(
                name: "TbCustomer");

            migrationBuilder.DropTable(
                name: "TbTours");

            migrationBuilder.DropTable(
                name: "TbCategores");

            migrationBuilder.DropTable(
                name: "TbLocation");

            migrationBuilder.DropTable(
                name: "TbLocationHomePage");
        }
    }
}
