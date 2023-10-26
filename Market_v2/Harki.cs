using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_v2
{
    internal class Harki
    {
        string name;
        int price;
        public Harki(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        /////////////////////////////////////////////////////////////
        static public List<List<Harki>> list = new List<List<Harki>>()
        {
            new List<Harki>()
            {
                new Harki("Ryzen 5 5500", 12000),
                new Harki("Ryzen 5 5600", 15000),
                new Harki("Ryzen 7 5700", 18000),
                new Harki("Ryzen 7 5800", 21000),
                new Harki("Ryzen 9 5900", 24000),
            },
            new List<Harki>()
            {
                new Harki("RTX 3050", 25000),
                new Harki("RTX 3060", 35000),
                new Harki("RTX 3070", 45000),
                new Harki("RTX 3080", 55000),
                new Harki("RTX 3090", 65000),

            },
            new List<Harki>()
            {
                new Harki("8 GB 3200Mhz", 6000),
                new Harki("16 GB 3200Mhz", 12000),
                new Harki("32 GB 3200Mhz", 24000),
                new Harki("32 GB 3200Mhz", 30000),
                new Harki("64 GB 3200Mhz", 60000),

            },
            new List<Harki>()
            {
                new Harki("MSI B550-A PRO", 12000),
                new Harki("MSI B550 GAMING PRO", 15000),
                new Harki("MSI B550 TOMAHAWK WIFI", 25000),
                new Harki("GIGABITE X570", 20000),

            },
            new List<Harki>()
            {
                new Harki("Be quite 700w", 9000),
                new Harki("Seasonic 700w", 12000),
                new Harki("KSAS 1000w", 5000),
            },
            new List<Harki>()
            {
                new Harki("ZALMAN i3", 4500),
                new Harki("Deepcool Matrexx Mesh", 5000),
                new Harki("Lian Li LANCOOL ", 12000),
            },
            new List<Harki>()
            {
                new Harki("DEEPCOOL GAMMAX 300", 1000),
                new Harki("DEEPCOOL AK620", 7000),
                new Harki("DEEPCOOL GAMMAX 400", 2300),
            }
        };

        static public string Getter(Harki c)
        {
            return (c.name + " " +  c.price);
        }

        static public int Price(Harki c)
        {
            return c.price;
        }

        static public void Podpunkt(int pos)
        {
            Console.Clear();
            Console.WriteLine(Order.m[pos]);
            foreach (var i in Harki.list[pos])
            {
                Console.WriteLine("  " + Harki.Getter(i));
            }
        }

        public List<string> m = new List<string>() { "Процессор", "Видеокарта", "ОЗУ", "Материнская плата", "БП", "Корпус", "Куллер" };


    }
}
