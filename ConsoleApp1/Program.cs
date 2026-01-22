using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число разности:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число разности:");
            double b = double.Parse(Console.ReadLine());
            HalfDifference numbers =new HalfDifference(a, b);
            Console.WriteLine(numbers.GetInfo());
            Console.WriteLine($"Результат полу-разности:{numbers.CalculationHD()}");

            Console.Write("Введите название книги:");
            string n = Console.ReadLine();
            Console.Write("Введите количество страниц в книге:");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Введите цену за книгу:");
            int p = int.Parse(Console.ReadLine());
            Book info = new Book(n, q, p);
            info.PriceIncrease();
            Console.WriteLine(info.FullInfo());
            Console.WriteLine($"Стоимость страницы в книге:{info.AveragePageCost()}");
        }
        public class HalfDifference
        {
            double field1;
            double field2;
            public HalfDifference(double a, double b)
            {
                field1 = a;
                field2 = b;
            }
            public string GetInfo()
            {
                return $"Первое Число={field1},Второе число={field2}";
            }
            public double CalculationHD()
            {
                return (field1 - field2) / 2;
            }
        }
        public class Book
        {
            string name;
            int quantity;
            int price;

            public Book(string n, int q, int p)
            {
                name = n;
                quantity = q;
                price = p;
            }
            ~Book()
            {
                Console.WriteLine("Объект Книга уничтожен.");
            }
            
            public string FullInfo()
            {
                return $"Имя книги:{name}, Количество страниц:{quantity}, Стоимость книги:{price}";
            }
            public double AveragePageCost()
            {
                if (quantity == 0) return 0;
                else return (price / quantity);
            }
            public void PriceIncrease()
            {
                if (name.StartsWith("Программирование"))
                {
                   price = price * 2;

                }

            }
        }
    }
}
