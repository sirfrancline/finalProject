using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
  public  class student
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public int  MaxRentalDays { get; set; }
        public string Description { get; set; }

      
    }

    public class EquimpmentDisplay : student {

        public string Display { get { return $"id: {ID}"; } }
    }
}
