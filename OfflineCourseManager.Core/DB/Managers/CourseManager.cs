using OfflineCourseManager.Core.DB.DAL;
using RPG.DB.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCourseManager.Core.DB.Managers
{
    public class CourseManager:Repository<Course>
    {

        public CourseManager(DbContext ctx):base(ctx)
        {

        }
    }
}
