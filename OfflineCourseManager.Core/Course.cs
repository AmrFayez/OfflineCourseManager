using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCourseManager.Core
{
    class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Module> Modules { get; set; }
        public bool IsFinished { get; set; }
        public bool IsStarted { get; set; }
        public DirectoryInfo DirectoryInfo { get; set; }

        public List<Course> GetCourses(string filePath)
        {
            return null;
        }

        public Course(string filePath)
        {

        }
    }
}
