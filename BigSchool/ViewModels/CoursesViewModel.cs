using BigSchool.Models;
using System.Collections.Generic;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public IEnumerable<ApplicationUser> UpcommingFollowing { get; set; }
    }
}