﻿namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            Boernegruppe grp1 = new Boernegruppe("1","GrønStue","pusling",12);
            Boernegruppe grp2 = new Boernegruppe("2", "BlåStue", "tumling", 8);
            Boernegruppe grp3 = new Boernegruppe("3", "RødStue", "pilt", 6);
            Boernegruppe grp4 = new Boernegruppe("4", "BautaStue", "seniorvæbner", 18);
            // Specifikt tidspunkt for reservation
            DateTime reservationTime1 = new DateTime(2024, 6, 15, 14, 30, 0); // 15. juni 2024 kl. 14:30
            DateTime reservationTime2 = new DateTime(2024, 6, 17, 10, 00, 0); // 17. juni 2024 kl. 10:00

            Reservation reservation1 = new Reservation(1,reservationTime1,grp1);
            Reservation reservation2 = new Reservation(2, reservationTime2, grp2);
            Reservation reservation3 = new Reservation(3, reservationTime1, grp3);
            Reservation reservation4 = new Reservation(4, reservationTime2, grp4);
            //Console.WriteLine(reservation1);

            Console.WriteLine("Opgave 6:");
            Console.WriteLine();
            Reservationer reslist = new Reservationer();
            Console.WriteLine("Vores resliste med dens unikke id er lavet " + reslist.ID);
            Console.WriteLine();
            Console.WriteLine("Register reservationer og display dem:" + reslist.ID);
            reslist.RegistrerReservation(reservation1);
            reslist.RegistrerReservation(reservation2);
            reslist.RegistrerReservation(reservation3);
            reslist.RegistrerReservation(reservation4);
            reslist.PrintReservation();
            Console.WriteLine();
            Console.WriteLine("Fjern reservation 1 og derefter display den nye liste");
            reslist.FjernReservation(reservation1);
            reslist.PrintReservation();

            //Opgave 7: Valideringsfunktioner
           
            Console.WriteLine("Opgave 7:");
            Console.WriteLine();
            Console.WriteLine("Tester AntalReservationer");
            Console.WriteLine($"Antal reservationer for {grp1.Name} : {reslist.AntalReservationer(grp2)}");
            Console.WriteLine($"Antal reservationer for {grp2.Name} : {reslist.AntalReservationer(grp2)}");
            Console.WriteLine();

            Console.WriteLine("Tester ReservationLedig");
            Console.WriteLine($"Reservation #{reservation1.ID} ledig: {reslist.ReservationLedig(reservation1)}");
            reslist.FjernReservation(reservation3);
            Console.WriteLine($"Reservation #{reservation3.ID} ledig: {reslist.ReservationLedig(reservation3)}");
            reslist.RegistrerReservation(reservation3);
            Console.WriteLine();









            Console.ReadKey();
        }
    }
}
