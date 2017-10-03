using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamensArbete.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ExamensArbete.DAL
{
    public class GalleryContext: DbContext
    {
        public GalleryContext(): base("GalleryContext")
        { }
        
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}