using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExamensArbete.Models;

namespace ExamensArbete.DAL
{
    public class GalleryInitializer : DropCreateDatabaseAlways<GalleryContext>
    {
		int a = 0;
        protected override void Seed(GalleryContext context)
        {
            var tags = new List<Tag>
            {
            new Tag{TagName = "Color"},
            new Tag{TagName = "B&W"},
            new Tag{TagName = "Ink"},
            new Tag{TagName = "Sketches & Doodles"},
            new Tag{TagName = "Pencil"}
            };

            tags.ForEach(s => context.Tags.Add(s));
            context.SaveChanges();

            var images = new List<Image>
            {
                new Image {ImageName = "Flamingo", TagId = 1, Description = "Its a weird and big pink bird", DateAdded = DateTime.Parse("2011-08-30"), FileName = "Flammingo.jpg"},
                new Image {ImageName = "House and Wilson", TagId = 1, Description = "",DateAdded = DateTime.Parse("2016-08-27"), FileName = "house.png"},
                new Image {ImageName = "Husky dog", TagId = 5 , Description = "", DateAdded = DateTime.Parse("2015-02-02"), FileName = "dog.jpg"},
                new Image {ImageName = "Reinhardt doodle", Description = "doodle of Overwatch character Reinhardt", TagId =  4, DateAdded = DateTime.Parse("2016-02-02"), FileName = "reinhardt.png"},
                new Image {ImageName = "Flock of Birds", Description = "", TagId =  2, DateAdded = DateTime.Parse("2016-10-10"), FileName = "flock of birds.jpg"},
                new Image {ImageName = "Eye", Description = "it's an eye-mazing sight", TagId =  3, DateAdded = DateTime.Parse("2015-01-28"), FileName = "eye.jpg"},
                new Image {ImageName = "Gandalf", Description = "Gandalf from the Lord of the Rings movies (obviously)", TagId =  3, DateAdded = DateTime.Parse("2014-12-24"), FileName = "gandalf.png"},
                new Image {ImageName = "Sketch of Danny DevVito", TagId = 4, Description = "",DateAdded = DateTime.Parse("2013-01-15"), FileName = "devito.jpg"},
                new Image {ImageName = "Flamingo", TagId = 1, Description = "Its a weird and big pink bird", DateAdded = DateTime.Parse("2011-08-30"), FileName = "Flammingo.jpg"},
                new Image {ImageName = "House and Wilson", TagId = 1, Description = "",DateAdded = DateTime.Parse("2016-08-27"), FileName = "house.png"},
                new Image {ImageName = "Husky dog", TagId = 5 , Description = "", DateAdded = DateTime.Parse("2015-02-02"), FileName = "dog.jpg"},
                new Image {ImageName = "Reinhardt doodle", Description = "doodle of Overwatch character Reinhardt", TagId =  4, DateAdded = DateTime.Parse("2016-02-02"), FileName = "reinhardt.png"},
                new Image {ImageName = "Flock of Birds", Description = "", TagId =  2, DateAdded = DateTime.Parse("2016-10-10"), FileName = "flock of birds.jpg"},
                new Image {ImageName = "Eye", Description = "it's an eye-mazing sight", TagId =  3, DateAdded = DateTime.Parse("2015-01-28"), FileName = "eye.jpg"},
                new Image {ImageName = "Gandalf", Description = "Gandalf from the Lord of the Rings movies (obviously)", TagId =  3, DateAdded = DateTime.Parse("2014-12-24"), FileName = "gandalf.png"},
                new Image {ImageName = "Sketch of Danny DevVito", TagId = 4, Description = "",DateAdded = DateTime.Parse("2013-01-15"), FileName = "devito.jpg"},
                new Image {ImageName = "Flamingo", TagId = 1, Description = "Its a weird and big pink bird", DateAdded = DateTime.Parse("2011-08-30"), FileName = "Flammingo.jpg"},
                new Image {ImageName = "House and Wilson", TagId = 1, Description = "",DateAdded = DateTime.Parse("2016-08-27"), FileName = "house.png"},
                new Image {ImageName = "Husky dog", TagId = 5 , Description = "", DateAdded = DateTime.Parse("2015-02-02"), FileName = "dog.jpg"},
                new Image {ImageName = "Reinhardt doodle", Description = "doodle of Overwatch character Reinhardt", TagId =  4, DateAdded = DateTime.Parse("2016-02-02"), FileName = "reinhardt.png"},
                new Image {ImageName = "Flock of Birds", Description = "", TagId =  2, DateAdded = DateTime.Parse("2016-10-10"), FileName = "flock of birds.jpg"},
                new Image {ImageName = "Eye", Description = "it's an eye-mazing sight", TagId =  3, DateAdded = DateTime.Parse("2015-01-28"), FileName = "eye.jpg"},
                new Image {ImageName = "Gandalf", Description = "Gandalf from the Lord of the Rings movies (obviously)", TagId =  3, DateAdded = DateTime.Parse("2014-12-24"), FileName = "gandalf.png"},
                new Image {ImageName = "Sketch of Danny DevVito", TagId = 4, Description = "",DateAdded = DateTime.Parse("2013-01-15"), FileName = "devito.jpg"},
                new Image {ImageName = "Flamingo", TagId = 1, Description = "Its a weird and big pink bird", DateAdded = DateTime.Parse("2011-08-30"), FileName = "Flammingo.jpg"},
                new Image {ImageName = "House and Wilson", TagId = 1, Description = "",DateAdded = DateTime.Parse("2016-08-27"), FileName = "house.png"},
                new Image {ImageName = "Husky dog", TagId = 5 , Description = "", DateAdded = DateTime.Parse("2015-02-02"), FileName = "dog.jpg"},
                new Image {ImageName = "Reinhardt doodle", Description = "doodle of Overwatch character Reinhardt", TagId =  4, DateAdded = DateTime.Parse("2016-02-02"), FileName = "reinhardt.png"},
                new Image {ImageName = "Flock of Birds", Description = "", TagId =  2, DateAdded = DateTime.Parse("2016-10-10"), FileName = "flock of birds.jpg"},
                new Image {ImageName = "Eye", Description = "it's an eye-mazing sight", TagId =  3, DateAdded = DateTime.Parse("2015-01-28"), FileName = "eye.jpg"},
                new Image {ImageName = "Gandalf", Description = "Gandalf from the Lord of the Rings movies (obviously)", TagId =  3, DateAdded = DateTime.Parse("2014-12-24"), FileName = "gandalf.png"},
                new Image {ImageName = "Sketch of Danny DevVito", TagId = 4, Description = "",DateAdded = DateTime.Parse("2013-01-15"), FileName = "devito.jpg"}
            };

            images.ForEach(s => context.Images.Add(s));
            context.SaveChanges();
        }

    }
}