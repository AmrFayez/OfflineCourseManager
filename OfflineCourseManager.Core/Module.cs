using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCourseManager.Core
{
    class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Clip> Clips { get; set; }
        public DirectoryInfo DirectoryInfo { get; set; }

        public Module(string filePath)
        {

        }
    }
}
