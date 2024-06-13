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
        public int ID { get; private set; }
        Dictionary<int, Reservation> _reservations;
        


        public Reservationer()
        { 
         _reservations = new Dictionary<int, Reservation>(); // Aggregation: Reservationer contains a collection of Reservation objects
        //Unikt ID der bliver lavet i forhold til tiden
        ID = DateTime.Now.Year;
        }

        #region CRUD opgave6

        public void RegistrerReservation(Reservation reservation) {
            // Lavet for validering, så folk ikke bare kan trygge 5 milioner tilmeldte :)
            //ReservationOK(reservation);

            /*Tjek for eksistens: if (!_reservations.ContainsKey(reservation.ID)) tjekker, 
             om reservationen allerede findes i _reservations-ordbogen. 
            _reservations er en dictionary (Dictionary<int, Reservation>), hvor ID er nøglen.   */

            if (!_reservations.ContainsKey(reservation.ID))
            {
                _reservations.Add(reservation.ID, reservation);
            }

        }
        public void PrintReservation() {
            foreach (Reservation reservation in _reservations.Values)
            {
                Console.WriteLine(reservation);
            }

        }
        public void FjernReservation(Reservation reservation) {
            if (_reservations.ContainsKey(reservation.ID))
            {
                _reservations.Remove(reservation.ID);
               
            }
        }


        #endregion
        #region opgave7
        public int AntalReservationer(Boernegruppe bGruppe) {
            int result = 0;
            foreach (Reservation res in  _reservations.Values)
            {
                if (res.Boernegruppe.ID == bGruppe.ID)
                {
                    result++;
                }
            }
            return result;
        }

        public bool ReservationLedig(Reservation reservation) {
            
            foreach (Reservation res in _reservations.Values)
            {
                if (res.DateTime == reservation.DateTime)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ReservationsTidspunktOK(Reservation reservation) {


        }


        #endregion

    }
}
