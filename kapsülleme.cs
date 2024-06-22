using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program

{
    static void Main()
    {
        Console.WriteLine("Kaç kullanıcı gireceğinizi giriniz:");
        int user = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < user; i++)
        {
            Console.Write("Lütfen ID'nizi giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen adınızı giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyadınzı giriniz: ");
            string lastname = Console.ReadLine();
            Console.Write("Lütfen yaşınızı giriniz: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen yaşadığınız şehri giriniz: ");
            string city = Console.ReadLine();
            Console.Write("Lütfen yaşadığınız ülkeyi giriniz: ");
            string country = Console.ReadLine();
            Customer customer = new Customer(id,name,lastname,age,city,country);
            
        }
    }
}
public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Customer(int id, string name, string lastname, int age, string city,string country)
    {
        ID = id;
        Name = name;
        Lastname = lastname;
        Age = age;
        City = city;
        Country = country;

    }
}

