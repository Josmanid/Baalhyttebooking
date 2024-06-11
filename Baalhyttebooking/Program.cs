namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            Boernegruppe grp1 = new Boernegruppe("1","GrønStue","pusling",12);
            // Specifikt tidspunkt for reservation
            DateTime reservationTime = new DateTime(2024, 6, 15, 14, 30, 0); // 15. juni 2024 kl. 14:30

            Reservation reservation1 = new Reservation(1,reservationTime,grp1);
            Console.WriteLine(reservation1);


















            Console.ReadKey();
        }
    }
}
