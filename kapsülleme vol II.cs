using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen kaydedilecek müşteri sayısını giriniz:");
        int user = Convert.ToInt32(Console.ReadLine());
        Customer[] customers = new Customer[user];

        for (int i = 0; i < customers.Length; i++)
        {
            Console.Write("Lütfen kullanıcı ID'ini giriniz:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz:");
            }
            Console.Write("Lütfen kullanıcı adınız giriniz:");
            string name = Console.ReadLine();
            Console.Write("Lütfen kullanıcı yaşını giriniz:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz:");
                age = 0;
            }
            Console.Write("Lütfen kullanıcı mail adresini giriniz:");
            string email= Console.ReadLine();
            Console.Write("Lütfen kullanıcı telefon numarasını giriniz:");
            long phone;
            while (!long.TryParse(Console.ReadLine(), out phone) || phone <= 0)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz:");
            }
            Console.Write("Lütfen kullanıcının yaşadığı şehri giriniz:");
            string city = Console.ReadLine();
            
            customers[i] = new Customer(id, name, age, email, phone,city);  
            Console.Clear();
        }
        foreach(var i  in customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.id}");
                Console.WriteLine($"Ad: {customer.name}");
                Console.WriteLine($"Yaş: {customer.age}");
                Console.WriteLine($"Email: {customer.email}");
                Console.WriteLine($"Telefon: {customer.phone}");
                Console.WriteLine($"Şehir: {customer.city}");
                Console.WriteLine("--------------------------------");
            }

        }

    }
}

public class Customer
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string email { get; set; }
    public long phone { get; set; }
    public string city { get; set; }

    public Customer(int id, string name,int age, string email, long phone,string city)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.email = email;
        this.phone = phone;
        this.city = city;
    }

}
