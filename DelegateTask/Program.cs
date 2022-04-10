using System;

namespace DelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            //Console.WriteLine("Kitabin adini daxil edin :");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Kitabin muellifini daxil edin : ");
            //string authorName1 = Console.ReadLine();
            //Console.WriteLine("Kitabin qiymetini daxil edin : ");
            //double price1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Kitabin tipini daxil edin : 1.Qorxu , 2.Mehebbet , 3.Dram ");
            //string genre1 = Console.ReadLine();

            book1.AuthorName = "Dostoyevski";
            book1.Name = "Cinayet";
            book1.Price = 17;
            book1.Type = Genre.Qorxu;

            Book book2 = new Book();
            //Console.WriteLine("Kitabin adini daxil edin :");
            //string name2 = Console.ReadLine();
            //Console.WriteLine("Kitabin muellifini daxil edin : ");
            //string authorName2 = Console.ReadLine();
            //Console.WriteLine("Kitabin qiymetini daxil edin : ");
            //double price2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Kitabin tipini daxil edin : 1.Qorxu , 2.Mehebbet , 3.Dram ");
            //string genre2 = Console.ReadLine();
            book2.AuthorName = "Ceyn Ostin";
            book2.Name = "Qurur";
            book2.Price = 37;
            book2.Type = Genre.Mehebbet;

            Book book3 = new Book();
            //Console.WriteLine("Kitabin adini daxil edin :");
            //string name3 = Console.ReadLine();
            //Console.WriteLine("Kitabin muellifini daxil edin : ");
            //string authorName3 = Console.ReadLine();
            //Console.WriteLine("Kitabin qiymetini daxil edin : ");
            //double price3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Kitabin tipini daxil edin : 1.Qorxu , 2.Mehebbet , 3.Dram ");
            //string genre3 = Console.ReadLine();
            book3.AuthorName = "Ceyn Ostin";
            book3.Name = "Son";
            book3.Price = 33;
            book3.Type = Genre.Qorxu;

            Console.WriteLine("min qiymet daxil edin");
            var minValue = double.Parse(Console.ReadLine());
            Console.WriteLine("max qiymet daxil edin");
            var maxValue = double.Parse(Console.ReadLine());


            Console.WriteLine("=======SONUCLAR======");
            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);

            Console.WriteLine("Secdiyiniz qiymet araligindaki kitablar:");
            foreach (var item in library.Books.FindAll(x => x.Price >= minValue && x.Price <= maxValue))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Qorxu janrindaki kitablar:");
            foreach (var itemm in library.Books.FindAll(x => x.Type == Genre.Qorxu))
            {
                Console.WriteLine(itemm.Name);
            }

            Console.WriteLine("1 nomreli kitab : ");
            foreach (var item in library.Books.FindAll(x => x.No == 1))
            {
                Console.WriteLine(item.Name + " " + item.AuthorName);
            }
            //Console.WriteLine(library.Books.Find(x => x.No == 1));
            Console.WriteLine("4 nomreli kitab movcuddur mu? ");
            Console.WriteLine(library.Books.Exists(x => x.No == 4));
            
            library.Books.RemoveAll(x => x.Name.Length == 5);


        }
    }
}
