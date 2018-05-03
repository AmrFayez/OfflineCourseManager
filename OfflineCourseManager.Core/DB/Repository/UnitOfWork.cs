using OfflineCourseManager.Core.DB.Managers;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.DB.DAL
{
    public class UnitOfWork
    {
        private DbContext _ctx;



        public ClipManager Clips
        {
            get { return new ClipManager(_ctx); }

        }



        public ModuleManager Modules
        {
            get { return new ModuleManager(_ctx); }

        }

        public CourseManager Courses
        {
            get { return new CourseManager(_ctx); }
        }


        public UnitOfWork(DbContext ctx)
        {
            _ctx = ctx;
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
