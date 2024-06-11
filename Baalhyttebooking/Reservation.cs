using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    internal class Reservation
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public Boernegruppe Boernegruppe {  get; set; } 


        public Reservation(int id, DateTime datetime, Boernegruppe boernegruppe) 
        {
            ID = id;
            DateTime = datetime;
            Boernegruppe = boernegruppe; // Aggregation: Reservation contains a reference to Boernegruppe
        }

        public override string ToString() {
            string Message = "Jeres id er " + ID + " Tidspunkt for jeres reservation er " + DateTime+ " med gruppen "+Boernegruppe.AgeGroup;
            return Message;
        }

    }
}
