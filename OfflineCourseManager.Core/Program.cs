using OfflineCourseManager.Core.Application;
using OfflineCourseManager.Core.DB.DAL;
using RPG.DB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCourseManager.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath= @"D:\PluralSight Course\1";

            Manager m = new Manager(dirPath, new OCMEntities());
            m.Retrive();
            Console.Read();
           
        }
    }

}
