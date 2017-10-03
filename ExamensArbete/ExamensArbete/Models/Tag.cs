using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamensArbete.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}