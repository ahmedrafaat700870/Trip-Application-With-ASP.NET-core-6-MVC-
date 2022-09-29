﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tourest.Models;

#nullable disable

namespace Tourest.Migrations
{
    [DbContext(typeof(TouristContext))]
    [Migration("20220830153608_Add-Tabel-Concat")]
    partial class AddTabelConcat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Tourest.Models.Blogs.BlogModel", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"), 1L, 1);

                    b.Property<string>("BlogCreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BlogCreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("BlogTitel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("BlogId");

                    b.ToTable("TbBlog");
                });

            modelBuilder.Entity("Tourest.Models.Blogs.BlogPhotoModel", b =>
                {
                    b.Property<int>("BlogPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogPhotoId"), 1L, 1);

                    b.Property<string>("BlogDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("BlogPhotoSrc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("BlogPhotoId");

                    b.HasIndex("BlogId");

                    b.ToTable("TbBlogDescriptoinPhoto");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.CustomerModel", b =>
                {
                    b.Property<int>("UsersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsersId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("UsersId");

                    b.ToTable("TbCustomer");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.FAQModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.HasKey("id");

                    b.ToTable("TbFAQ");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.InestegramModel", b =>
                {
                    b.Property<int>("InstagramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstagramId"), 1L, 1);

                    b.Property<string>("InstagramSrc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("PhotoSrc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.HasKey("InstagramId");

                    b.ToTable("TbInetegram");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.InformationModel", b =>
                {
                    b.Property<int>("InformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InformationId"), 1L, 1);

                    b.Property<string>("DescriptionInfo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("FaceBookAccount")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("Facx")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FooterDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("FooterImage")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("InformationEmail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("InformationPhone")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("InstagramAccount")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LogoImage")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TwitterAcount")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("WebSiteName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("InformationId");

                    b.ToTable("TbInformation");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.InformationTeamPageModel", b =>
                {
                    b.Property<int>("InfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InfoId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("PagePhoto")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PageTitel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("InfoId");

                    b.ToTable("TbInfoTeamPage");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.LocationHomePage", b =>
                {
                    b.Property<int>("LocationHomePageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationHomePageId"), 1L, 1);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("LocationHomePageId");

                    b.ToTable("TbLocationHomePage");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.ReviewsBageModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("CretaedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(Max)");

                    b.Property<int>("disLike")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("src")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id");

                    b.ToTable("TbReviewBage");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.ReviewsModel", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ReviewDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<int>("TbCustomerUsersId")
                        .HasColumnType("int");

                    b.Property<int?>("TourId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("BlogId");

                    b.HasIndex("TbCustomerUsersId");

                    b.HasIndex("TourId");

                    b.ToTable("TbReviews");
                });

            modelBuilder.Entity("Tourest.Models.HomePage.HomePageImages", b =>
                {
                    b.Property<int>("HomePageImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomePageImageId"), 1L, 1);

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SubImage1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SubImage2")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("HomePageImageId");

                    b.HasIndex("MainImage")
                        .IsUnique();

                    b.HasIndex("SubImage1")
                        .IsUnique();

                    b.ToTable("TbHomePageImages");
                });

            modelBuilder.Entity("Tourest.Models.OrderTables.InvoiceModel", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("TbCustomerUsersId")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("TbCustomerUsersId");

                    b.HasIndex("TourId");

                    b.ToTable("TbInvoice");
                });

            modelBuilder.Entity("Tourest.Models.OurTeam.TeamMemberModel", b =>
                {
                    b.Property<int>("TeamMeberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamMeberId"), 1L, 1);

                    b.Property<string>("TeamMeberName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TeamMebmerJob")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TeamMemberJobDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("TeamMemberPhoto")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("TeamMeberId");

                    b.ToTable("TbTeamMember");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.CategoryModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CategoryId");

                    b.ToTable("TbCategores");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.DepartmentModel", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("DepartmentId");

                    b.ToTable("DepartmentModels");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.DepartmentToursModel", b =>
                {
                    b.Property<int>("DepartmentTourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentTourId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentTourId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TourId");

                    b.ToTable("TbDepartmentTour");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.LocationModel", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("LocationId");

                    b.ToTable("TbLocation");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.OptionIncludedModel", b =>
                {
                    b.Property<int>("IncludedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncludedId"), 1L, 1);

                    b.Property<string>("IncludedName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("OptionId")
                        .HasColumnType("int");

                    b.Property<bool>("isIncluded")
                        .HasColumnType("bit");

                    b.HasKey("IncludedId");

                    b.HasIndex("OptionId");

                    b.ToTable("TbbOptionIncluded");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.OptionNeedModel", b =>
                {
                    b.Property<int>("NeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NeedId"), 1L, 1);

                    b.Property<int>("OptionId")
                        .HasColumnType("int");

                    b.Property<string>("tourNeededName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("NeedId");

                    b.HasIndex("OptionId");

                    b.ToTable("TbOptionNeeded");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.PhotoModel", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhotoId"), 1L, 1);

                    b.Property<string>("PhotoSrc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("PhotoId");

                    b.HasIndex("TourId");

                    b.ToTable("TbPhotos");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.Tour_Option.ToursOptionModel", b =>
                {
                    b.Property<int>("TourOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourOptionId"), 1L, 1);

                    b.Property<int?>("DayCount")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<int?>("HourCount")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MaxPeople")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MinAge")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("MinPeople")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("OptionDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<bool>("isSelected")
                        .HasColumnType("bit");

                    b.HasKey("TourOptionId");

                    b.HasIndex("TourId");

                    b.ToTable("TbTourOption");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.ToursModel", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<int?>("LocationHomePageId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Sale")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("TourPrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("TourTitel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("VideoSrc")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(Max)");

                    b.Property<bool>("isDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("isNew")
                        .HasColumnType("bit");

                    b.HasKey("TourId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LocationHomePageId");

                    b.HasIndex("LocationId");

                    b.ToTable("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.UsersTabel.ConcatModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id");

                    b.ToTable("TbConcat");
                });

            modelBuilder.Entity("Tourest.Models.VB.VbToursLocationCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("Sale")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<decimal>("TourPrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("TourTitel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("isNew")
                        .HasColumnType("bit");

                    b.ToView("VbToursLocationCategory");
                });

            modelBuilder.Entity("Tourest.Models.Blogs.BlogPhotoModel", b =>
                {
                    b.HasOne("Tourest.Models.Blogs.BlogModel", "TbBlog")
                        .WithMany("TbBlogPhotos")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbBlog");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.ReviewsModel", b =>
                {
                    b.HasOne("Tourest.Models.Blogs.BlogModel", "TbBlog")
                        .WithMany("TbRiviews")
                        .HasForeignKey("BlogId");

                    b.HasOne("Tourest.Models.CustomsTables.CustomerModel", "TbCustomer")
                        .WithMany()
                        .HasForeignKey("TbCustomerUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tourest.Models.TourTabels.ToursModel", "TbTours")
                        .WithMany("TbReviews")
                        .HasForeignKey("TourId");

                    b.Navigation("TbBlog");

                    b.Navigation("TbCustomer");

                    b.Navigation("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.OrderTables.InvoiceModel", b =>
                {
                    b.HasOne("Tourest.Models.CustomsTables.CustomerModel", "TbCustomer")
                        .WithMany()
                        .HasForeignKey("TbCustomerUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tourest.Models.TourTabels.ToursModel", "TbTours")
                        .WithMany("TbInvoices")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbCustomer");

                    b.Navigation("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.DepartmentToursModel", b =>
                {
                    b.HasOne("Tourest.Models.TourTabels.DepartmentModel", "Department")
                        .WithMany("TbDepartmentTour")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tourest.Models.TourTabels.ToursModel", "Tour")
                        .WithMany("TbDepartmentTour")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.OptionIncludedModel", b =>
                {
                    b.HasOne("Tourest.Models.TourTabels.Tour_Option.ToursOptionModel", "TbOption")
                        .WithMany("TbIncludded")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbOption");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.OptionNeedModel", b =>
                {
                    b.HasOne("Tourest.Models.TourTabels.Tour_Option.ToursOptionModel", "TbOption")
                        .WithMany("TbNeeded")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbOption");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.PhotoModel", b =>
                {
                    b.HasOne("Tourest.Models.TourTabels.ToursModel", "TbTours")
                        .WithMany("TbPhotos")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.Tour_Option.ToursOptionModel", b =>
                {
                    b.HasOne("Tourest.Models.TourTabels.ToursModel", "TbTours")
                        .WithMany("TbTourOptions")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.ToursModel", b =>
                {
                    b.HasOne("Tourest.Models.TourTabels.CategoryModel", "TbCategory")
                        .WithMany("TbTours")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tourest.Models.CustomsTables.LocationHomePage", "TbLocationHomePage")
                        .WithMany("TbTours")
                        .HasForeignKey("LocationHomePageId");

                    b.HasOne("Tourest.Models.TourTabels.LocationModel", "TbLocation")
                        .WithMany("TbTour")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TbCategory");

                    b.Navigation("TbLocation");

                    b.Navigation("TbLocationHomePage");
                });

            modelBuilder.Entity("Tourest.Models.Blogs.BlogModel", b =>
                {
                    b.Navigation("TbBlogPhotos");

                    b.Navigation("TbRiviews");
                });

            modelBuilder.Entity("Tourest.Models.CustomsTables.LocationHomePage", b =>
                {
                    b.Navigation("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.CategoryModel", b =>
                {
                    b.Navigation("TbTours");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.DepartmentModel", b =>
                {
                    b.Navigation("TbDepartmentTour");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.LocationModel", b =>
                {
                    b.Navigation("TbTour");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.Tour_Option.ToursOptionModel", b =>
                {
                    b.Navigation("TbIncludded");

                    b.Navigation("TbNeeded");
                });

            modelBuilder.Entity("Tourest.Models.TourTabels.ToursModel", b =>
                {
                    b.Navigation("TbDepartmentTour");

                    b.Navigation("TbInvoices");

                    b.Navigation("TbPhotos");

                    b.Navigation("TbReviews");

                    b.Navigation("TbTourOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
