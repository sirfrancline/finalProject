using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Persistence.FileSingleAccessControlObjects
{

    //http://stackoverflow.com/questions/13763917/c-sharp-lock-statement-what-object-to-lock-on

    public static class LockObjects
    {
        public static object StaffLocker = new object();
        public static object EqLocker = new object();
        public static object StLocker = new object();
        public static object RentalLocker = new object();
    }
}
