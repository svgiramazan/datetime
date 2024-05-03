using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_str
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(value:simdi);//metodlarıyla ayrı ayrı ay yıl gün saat dakika saniye istenebilir.
            Console.WriteLine(value: simdi.Month);
            Console.WriteLine(value: simdi.DayOfWeek);

            DateTime dt = new DateTime(2003, 4, 21);
            Console.WriteLine(dt);
            DateTime dt2 = dt.AddHours(5);//.add ekleme işlemi yapar
            Console.WriteLine(dt2);
            var fark = simdi - dt;
            Console.WriteLine(fark);
            Console.WriteLine(fark.TotalDays);
            Console.ReadLine();
        }
    }
}
