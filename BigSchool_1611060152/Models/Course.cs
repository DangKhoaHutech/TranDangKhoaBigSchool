using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_1611060152.Models
{
    public class Course
    {
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength (225)]
        public String Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; } 
        [Required]
        public byte CategoryId { get; set; }

    }
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength (225)]
        public string Name { get; set; }
    }
}