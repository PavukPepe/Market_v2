using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Market_v2
{
    internal class Order
    {
        static public int z = 0;
        static public List<string> m = new List<string>() { "Процессор", "Видеокарта", "ОЗУ", "Материнская плата", "БП", "Корпус", "Куллер" };
        static public Dictionary<string, Harki> zak = new Dictionary<string, Harki>()
        {
            ["Процессор"] = new Harki("", 0),
            ["Видеокарта"] = new Harki("", 0),
            ["ОЗУ"] = new Harki("", 0),
            ["Материнская плата"] = new Harki("", 0),
            ["БП"] = new Harki("", 0),
            ["Корпус"] = new Harki("", 0),
            ["Куллер"] = new Harki("", 0)
        };
        public void Setter(string key, Harki value)
        {
            zak[key] = value;
        }
        public void Vivid(int k, List<string> m)
        {
            if (k == 1)
            {
                Console.Clear();
                int cl = 0;
                foreach (var kvp in m)
                {
                    Console.WriteLine("  " + kvp);
                    Console.SetCursorPosition(28, m.IndexOf(kvp));
                    if (Harki.Price(zak[kvp]) != 0)
                    {
                        Console.WriteLine("| " + Harki.Getter(zak[kvp]) + " руб.");
                    }
                    else
                    {
                        Console.WriteLine("| ");
                    }
                    cl++;
                }
                Console.WriteLine("################################################################");
                Console.WriteLine("Итого:                                               " + this.Summa() + " руб.");
                Console.WriteLine("Для сохранения и начала следущего заказа нажмите ESC");
            }
            else
            {
                z++;
                Console.Clear();
                int cl = 0;
                string file = "ZAKAZ" + z + ".txt";
                File.WriteAllText(file, "################################################################\n");
                foreach (var kvp in m)
                {
                    
                    if (Harki.Price(zak[kvp]) != 0)
                    {
                        File.AppendAllText(file, kvp);
                        File.AppendAllText(file ,"| " + Harki.Getter(zak[kvp]) + " руб.\n");
                    }
                    cl++;
                }
                File.AppendAllText(file, "################################################################\n");
                File.AppendAllText(file,"Итого:                                               " + this.Summa() + " руб.");
            }

            
        }
        private int Summa()
        {
            var h = Harki.list;
            int s = 0;
            for (int i = 0; i < m.Count; i++)
            {
                if (Harki.Price(zak[m[i]]) != 0)
                {
                    s = s + Harki.Price(zak[m[i]]);
                }
            }
            return s;
        }
    };
}

