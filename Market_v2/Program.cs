namespace Market_v2
{


    internal class Program
    {
        static void Main(string[] args) 
        {
            Order n = new Order();
            while (true)
            {
                n.Vivid(1, Order.m);
                int pos = new Menu(0, Order.m.Count() - 1).Show();
                if (pos == 404)
                {
                    n.Vivid(2,Order.m);
                    Order.zak = new Dictionary<string, Harki>{
                    ["Процессор"] = new Harki("", 0),
                    ["Видеокарта"] = new Harki("", 0),
                    ["ОЗУ"] = new Harki("", 0),
                    ["Материнская плата"] = new Harki("", 0),
                    ["БП"] = new Harki("", 0),
                    ["Корпус"] = new Harki("", 0),
                    ["Куллер"] = new Harki("", 0)
                };//Пробывал через new Order, но оно не работает(((        
                    continue;
                }
                Harki.Podpunkt(pos);
                int pol = new Menu(1, Harki.list[pos].Count()).Show();
                if (pol == 404)
                {
                    continue;
                }
                n.Setter(Order.m[pos], Harki.list[pos][pol - 1]);
            }
            
        }
    }
}