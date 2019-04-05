using BigSchool_1611060152.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_1611060152.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}