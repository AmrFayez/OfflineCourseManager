using OfflineCourseManager.Core.DB.DAL;
using RPG.DB.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace OfflineCourseManager.Core.Application
{
  public  class Manager
    {
        public string DirectoryPath { get; set; }
        private UnitOfWork uow;
        public string SearchPattern { get; set; }
        public Manager(string dirPath, DbContext ctx)
        {
            DirectoryPath = dirPath;
            uow = new UnitOfWork(ctx);
            SearchPattern = "*.mp4";
        }

        public void Retrive()
        {
            AddCourses(DirectoryPath);
        }
        private void AddCourses(string dirPath)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            DirectoryInfo[] courses = dir.GetDirectories();
            foreach (var course in courses)
            {
                Course c = new Course();
                c.Name = course.Name;
                c.FullPath = course.FullName;
                c.StartDate = "";
                c.EndDate = "";
                c.IsFinished = 0;
                c.IsStarted = 0;

                //add to db
                uow.Courses.Insert(c);
                uow.SaveChanges();
                AddModules(c);
            }


        }

        private void AddModules( Course c)
        {
            DirectoryInfo dir = new DirectoryInfo(c.FullPath);
            
            DirectoryInfo[] modules = dir.GetDirectories();
            foreach (var module in modules)
            {
                Module m = new Module();
                m.Name = module.Name;
                m.FullPath = module.FullName;
                m.Course_Fk = c.Id;
                uow.Modules.Insert(m);
                uow.SaveChanges();
                AddClips(m);
            }
            
        }
        private void AddClips(Module m)
        {
            DirectoryInfo module = new DirectoryInfo(m.FullPath);
            FileInfo[] clips = module.GetFiles(SearchPattern);
            foreach (var clip in clips)
            {
                Clip c = new Clip();
                c.Name = clip.Name;
                c.FullPath = clip.FullName;
                c.Duration = (long)GetDuration(c.FullPath).TotalSeconds;
                c.Module_Fk = m.Id;
                c.StartDate = "";
                c.EndDate = "";
                c.IsFinished = 0;
                c.IsStarted = 0;
                uow.Clips.Insert(c);
                uow.SaveChanges();
            }
            
        }

        private  TimeSpan GetDuration(string fileName)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia mediaInfo = wmp.newMedia(fileName);
            TimeSpan ts = TimeSpan.FromSeconds(mediaInfo.duration);
            return ts;
        }
    }
}
