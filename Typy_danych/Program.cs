namespace Typy_danych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Zadanie nr 1 - dane pracownika");
            string firstname;
            string lastname;
            int age; 
            char maleOrFemale;
            string pesel;
            string personId;

            Console.WriteLine("\n Zadanie nr 2 - zmienne w odwrotnej kolejności");
            char first = 'x';
            char second = 'y';
            char third = 'z';
            Console.WriteLine($" In the correct order: {first}, {second}, {third}");
            Console.WriteLine($" In reverse order: {third}, {second}, {first}");

            Console.WriteLine("\n Zadanie nr 3 - długość przekątnej");

            double sideA = 10;
            double sideB = 20;
            double diagonal;
            double temporaryValue = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            diagonal = Math.Pow(temporaryValue, 1 / 2d);
            double diagonalRound = Math.Round(diagonal, 2, MidpointRounding.AwayFromZero); // zrobiłem zaokraglenie do 2 miejsc bo wynik kitowo wyglądał
            Console.WriteLine($" Długość przekątnej wynosi {diagonalRound} .");

            Console.WriteLine("\n Zadanie nr 4 ");
            int a; ;
            double b;
            string text;
            a = 10;
            b = 12.5;
            text = "Szkoła Dotneta";
            Console.WriteLine($" {a} \n {text} \n {b} ");

            Console.WriteLine("\n Zadanie nr 5 - dane personalne");
            Console.Write(" Firstname: ");
            firstname = Console.ReadLine();
            Console.WriteLine($" Your firstname: {firstname}");
            
            Console.Write(" Lastname: ");
            lastname = Console.ReadLine();
            Console.WriteLine($" Your lastname: ");

            Console.Write(" Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine($" Your phone number {phoneNumber} ");

            Console.Write(" Email: ");
            string email = Console.ReadLine();
            Console.WriteLine($" Your email: {email}");

            Console.Write(" Height [cm] : ");
            string height = Console.ReadLine();
            double.Parse(height);
            Console.WriteLine($" Your height is {height} cm");

            Console.Write(" Weight [kg] : ");
            string weight = Console.ReadLine();
            double.Parse(weight);
            Console.WriteLine($" Your weight: {weight} kg");

            Console.Write(" Sex, m or f : ");
            sex = Console.ReadLine();
            Console.WriteLine($" Your sex is: {sex} ");

            Console.Write($" Pesel: ");
            pesel = Console.ReadLine();
            Console.WriteLine($" Your pesel: {pesel} ");
            
        }

    }
}