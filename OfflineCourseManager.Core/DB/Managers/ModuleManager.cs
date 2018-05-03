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
  public  class ModuleManager:Repository<Module>
    {
        public ModuleManager(DbContext ctx):base(ctx)
        {

        }
    }
}
