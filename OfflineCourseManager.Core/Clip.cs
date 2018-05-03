using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCourseManager.Core
{
    class Clip
    {

        public int Id { get; set; }
        public bool  IsStarted { get; set; }
        public TimeSpan Duration { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public FileInfo FileInfo { get; set; }
        public Clip(int id,FileInfo fileInfo)
        {
            FileInfo = fileInfo;
            Id = id;
            Initalize();
        }

        private void Initalize()
        {
            Name = FileInfo.Name;
        }
    }
}
