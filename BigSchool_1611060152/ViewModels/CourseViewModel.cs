using BigSchool_1611060152.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_1611060152.ViewModels
{
    public class CourseViewModel
    {
        [Required] // hien thi thong bao neu khong rang buoc
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

       public DateTime GetDateTime()
        {
            // ep kieu string sang datetime
            return DateTime.Parse(string.Format(" {0} {1} ", Date, Time));
        }

    }
}