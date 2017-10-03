using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamensArbete.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        private string fileName;
        public string FileName
        {
            get
            {
                return "/Gallery/" + this.fileName;
            }
            set
            {
                this.fileName = value.Replace("/Gallery/", "");
            }
        }

        public string ImageName
        { get; set; }
        //datum, fixa till svenska datumschema
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

    }
}