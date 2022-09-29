using Microsoft.EntityFrameworkCore;
using Tourest.Models.CustomsTables;
using Tourest.Models.OrderTables;
using Tourest.Models.TourTabels;
using Tourest.Models.TourTabels.Tour_Option;
using Tourest.Models.HomePage;
using Tourest.Models.Blogs;
using Tourest.Models.OurTeam;
using Tourest.Models.VB;
using Tourest.Models.UsersTabel;

namespace Tourest.Models
{
    public class TouristContext : DbContext
    {
        public TouristContext()
        {

        }
        const string ServerName = "DESKTOP-GRDA6E7\\SQL2022";
        public virtual DbSet<HomePageImages> TbHomePageImages { get; set; }
        public virtual DbSet<ReviewsBageModel> TbReviewBage { get; set; }
        #region Users Tables
        public virtual DbSet<CustomerModel> TbCustomer { get; set; }
        #endregion
        #region Tours Tables
        public virtual DbSet<OptionIncludedModel> TbbOptionIncluded { get; set; }
        public virtual DbSet<OptionNeedModel> TbOptionNeeded { get; set; }
        public virtual DbSet<ToursModel> TbTours { get; set; }
        public virtual DbSet<PhotoModel> TbPhotos { get; set; }
        public virtual DbSet<CategoryModel> TbCategores { get; set; }
        public virtual DbSet<LocationModel> TbLocation { get; set; }
        public virtual DbSet<DepartmentToursModel> TbDepartmentTour { get; set; }
        public virtual DbSet<DepartmentModel> DepartmentModels { get; set; }
        public virtual DbSet<ConcatModel> TbConcat { get; set; }
        #region TourOption Tables
        public virtual DbSet<ToursOptionModel> TbTourOption { get; set; }
        // public virtual DbSet<ToursOptionModel> TbToursOption { get; set; } 
        #endregion
        #endregion

        #region Customs Tables
        public virtual DbSet<InestegramModel> TbInetegram { get; set; }
        public virtual DbSet<BlogModel> TbBlog { get; set; }
        public virtual DbSet<ReviewsModel> TbReviews { get; set; }
        public virtual DbSet<InformationModel> TbInformation { get; set; }
        public virtual DbSet<BlogPhotoModel> TbBlogDescriptoinPhoto { get; set; }
        public virtual DbSet<InformationTeamPageModel> TbInfoTeamPage { get; set; }
        public virtual DbSet<FAQModel> TbFAQ { get; set; }
        public virtual DbSet<LocationHomePage> TbLocationHomePage { get; set; }
        public virtual DbSet<SectionNamesModel> TbSectionNames { get; set; }
        #endregion

        #region Invoice Tables
        public virtual DbSet<InvoiceModel> TbInvoice { get; set; }
        #endregion


        #region TeamMember Tabel

        public virtual DbSet<TeamMemberModel> TbTeamMember { get; set; }


        #endregion

        #region Views

        public virtual DbSet<VbToursLocationCategory> VbToursLocationCategory { get; set; }


        #endregion
        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server=SQL8001.site4now.net;Database=db_a8c224_tour;User ID=db_a8c224_tour_admin;Password=2881774aA;");
              //  Data Source = SQL8001.site4now.net; Initial Catalog = db_a8c224_tour; User Id = db_a8c224_tour_admin; Password = YOUR_DB_PASSWORD
              //  "Data Source=SQL8004.site4now.net;Initial Catalog=db_a8c224_test;User Id=db_a8c224_test_admin;Password=YOUR_DB_PASSWORD
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            #region Users Builder
            modelBuilder.Entity<ConcatModel>(entity =>
            {
                entity.HasKey(key => key.id);
            });
            #endregion

            #region Tours Builder
            modelBuilder.Entity<ToursOptionModel>(entity =>
                {
                    entity.HasKey(key => key.TourOptionId);
                    entity.HasOne(one => one.TbTours)
                    .WithMany(Many => Many.TbTourOptions)
                    .HasForeignKey(fk => fk.TourId);
                });
            modelBuilder.Entity<ToursModel>(entity =>
            {
                entity.HasKey(key => key.TourId);


                entity.HasOne(one => one.TbLocationHomePage)
                .WithMany(many => many.TbTours)
                .HasForeignKey(fk => fk.LocationHomePageId);

                entity.Property(prop => prop.isDeleted).HasDefaultValue(false);

                entity.Property(prop => prop.VideoSrc).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.Description).HasColumnType("varchar(Max)");
                entity.HasOne(one => one.TbCategory)
                .WithMany(many => many.TbTours)
                .HasForeignKey(fk => fk.CategoryId);


                entity.HasOne(one => one.TbLocation)
                .WithMany(many => many.TbTour)
                .HasForeignKey(fk => fk.LocationId);
            });
            modelBuilder.Entity<PhotoModel>(entity =>
                      {
                          entity.HasKey(key => key.PhotoId);
                          entity.HasOne(one => one.TbTours)
                          .WithMany(Many => Many.TbPhotos)
                          .HasForeignKey(fk => fk.TourId);
                      });
            modelBuilder.Entity<LocationModel>(entity =>
            {
                entity.HasKey(key => key.LocationId);
            });
            modelBuilder.Entity<OptionNeedModel>(entity =>
            {
                entity.HasKey(key => key.NeedId);

                entity.HasOne(one => one.TbOption)
                .WithMany(many => many.TbNeeded)
                .HasForeignKey(fk => fk.OptionId);
            });
            modelBuilder.Entity<OptionIncludedModel>(entity =>
            {
                entity.HasKey(key => key.IncludedId);

                entity.HasOne(one => one.TbOption)
                .WithMany(many => many.TbIncludded)
                .HasForeignKey(fk => fk.OptionId);
            });
            modelBuilder.Entity<DepartmentToursModel>(entity =>
            {
                entity.HasKey(key => key.DepartmentTourId);
            });

            // ToursDuration Tables
            modelBuilder.Entity<ToursOptionModel>(entity =>
            {
                entity.HasKey(key => key.TourOptionId);
                entity.Property(prop => prop.OptionDescription).HasColumnType("varchar(Max)");
            });
            // ToursDuration Tables  
            #endregion


            #region Customs Builder
            modelBuilder.Entity<SectionNamesModel>(entity =>
            {
                entity.HasKey(key => key.id);
            });
            modelBuilder.Entity<LocationHomePage>(entity =>
            {
                entity.HasKey(key => key.LocationHomePageId);
            });
            modelBuilder.Entity<InestegramModel>(entity =>
            {
                entity.HasKey(key => key.InstagramId);
                entity.Property(p => p.InstagramSrc).HasColumnType("varchar(Max)");
                entity.Property(p => p.PhotoSrc).HasColumnType("varchar(Max)");
            });
            modelBuilder.Entity<ReviewsBageModel>(entity =>
            {
                entity.HasKey(key => key.id);
                entity.Property(prop => prop.description).HasColumnType("nvarchar(Max)");
            });
            modelBuilder.Entity<BlogModel>(entity =>
            {
                entity.HasKey(key => key.BlogId);
            });
            modelBuilder.Entity<FAQModel>(entity =>
            {
                entity.HasKey(key => key.id);
                entity.Property(prop => prop.question).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.Answer).HasColumnType("varchar(Max)");
            });
            modelBuilder.Entity<ReviewsModel>(entity =>
                {
                    entity.HasKey(key => key.ReviewId);
                    entity.Property(prop => prop.ReviewDescription).HasColumnType("varchar(Max)");
                    entity.HasOne(one => one.TbTours)
                   .WithMany(many => many.TbReviews)
                   .HasForeignKey(fk => fk.TourId);

                    entity.HasOne(one => one.TbBlog)
                    .WithMany(many => many.TbRiviews)
                    .HasForeignKey(fk => fk.BlogId);
                });


            modelBuilder.Entity<InformationTeamPageModel>(entity =>
            {
                entity.HasKey(key => key.InfoId);
                entity.Property(prop => prop.Description).HasColumnType("varchar(Max)");
            });
            #endregion

            #region Invoice Builder
            modelBuilder.Entity<InvoiceModel>(entity =>
            {


                entity.HasOne(one => one.TbTours)
               .WithMany(many => many.TbInvoices)
               .HasForeignKey(fk => fk.TourId);
            });
            #endregion

            modelBuilder.Entity<TeamMemberModel>(entity =>
            {
                entity.HasKey(key => key.TeamMeberId);
                entity.Property(prop => prop.TeamMemberJobDescription).HasColumnType("varchar(Max)");
            });

            modelBuilder.Entity<HomePageImages>(entity =>
            {
                entity.HasIndex(index => index.MainImage).IsUnique();
                entity.HasIndex(index => index.SubImage1).IsUnique();
            });
            modelBuilder.Entity<InformationModel>(entity =>
            {
                entity.Property(prop => prop.DescriptionInfo).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.FooterDescription).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.FaceBookAccount).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.TwitterAcount).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.InstagramAccount).HasColumnType("varchar(Max)");
                entity.Property(prop => prop.InformationEmail).HasColumnType("varchar(Max)");
            });

            modelBuilder.Entity<BlogPhotoModel>(entity =>
            {
                entity.HasKey(key => key.BlogPhotoId);
                entity.HasOne(one => one.TbBlog)
                .WithMany(many => many.TbBlogPhotos)
                .HasForeignKey(fk => fk.BlogId);
                entity.Property(prop => prop.BlogDescription).HasColumnType("varchar(Max)");
            });

            #region Views
            modelBuilder.Entity<VbToursLocationCategory>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("VbToursLocationCategory");
            });
            #endregion

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(250);
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime");
            configurationBuilder.Properties<decimal>().HaveColumnType("decimal(8,2)");
        }
        #endregion

    }
}
