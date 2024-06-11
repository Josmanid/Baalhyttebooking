using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    //Internal betyder at denne klasse kun kan benyttes i dette projekt ikke andre projekter jeg har lavet
    internal class Reservationer
    {
        public int ID { get; set; }
        Dictionary<int, Reservation> _reservations;



        public Reservationer(Reservation reservation)
        { 
         _reservations = new Dictionary<int, Reservation>(); // Aggregation: Reservationer contains a collection of Reservation objects
        //Unikt ID der bliver lavet i forhold til tiden
        ID = DateTime.Now.Year;
        }

        #region CRUD

        public void RegistrerReservation(Reservation reservation) {
            // Lavet for validering, så folk ikke bare kan trygge 5 milioner tilmeldte :)
            //ReservationOK(reservation);

            if (!_reservations.ContainsKey(reservation.ID))
            {
                _reservations.Add(reservation.ID, reservation);
            }

        }

        #endregion


    }
}
