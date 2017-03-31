using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Equipment
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string MaxRentalDays { get; set; }
        public string Description { get; set; }

        public Equipment()
        {
        }
        public Equipment(string id, string type, string maxdays, string description)
        {
            this.ID = id;
            this.Type = type;
            this.MaxRentalDays = maxdays;
            this.Description = description;
        }

        public void Display()
        {
            Console.WriteLine(ID + "\t" + Type + "\t" + MaxRentalDays + "\t" + Description);
        }




    }
}
