using ncore.Data;
using System;
using System.Linq;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Test v1.0");
            using (var db = new MyContext())
            {
                Console.WriteLine($"DB deleted = {db.Database.EnsureDeleted()}");
                Console.WriteLine($"DB created = {db.Database.EnsureCreated()}");

                if (!db.Users.Any(u=>u.Name == "Oleg Lytvynenko"))
                {
                    db.Users.Add(new User { Name = "Oleg Lytvynenko", Email = "oleg_lytvynenko@epam.com" });
                    db.SaveChanges();
                }

                foreach(var t in db.Users.Select(u => u.Email))
                {
                    Console.WriteLine(t);
                }
            }

        }
    }
}
