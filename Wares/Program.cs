using System;
using System.Collections.Specialized;

class Wares
{
    short тип;
    short вид;
    short стан;

    public Wares()
    {
        Console.WriteLine("1 - одяг\n2 - харчування\n");
        while (тип <= 0 ||тип > 2) { тип = Convert.ToInt16(Console.ReadLine()); }

        if (тип == 1)
        {
            Console.WriteLine("1 - жіночий\n2 - чоловічий\n3 - дитячий\n");
            while (вид <= 0 || вид > 3) { вид = Convert.ToInt16(Console.ReadLine()); }
        }
        else if(тип == 2)
        {
            Console.WriteLine("1 - овочі\n2 - фрукти\n3 - крупи\n");
            while (вид <= 0 || вид > 3) { вид = Convert.ToInt16(Console.ReadLine()); }
        }

        Console.WriteLine("1 - прийшло\n2 - продано\n3 - списано\n4 - продано в інший магазин");
        while ( стан <= 0 || стан > 4) { стан = Convert.ToInt16(Console.ReadLine()); }

        Console.Clear();
    }
    public void see()
    {
        Console.WriteLine();
        if (тип == 1)
        {
            Console.Write("Oдяг, ");
            if(вид == 1)
            {
                Console.Write("жіночий, ");
            }
            else if (вид == 2)
            {
                Console.Write("чоловічий, ");
            }
            else if (вид == 3)
            {
                Console.Write("дитячий, ");
            }
            
        }
        else if(тип == 2)
        {
            Console.Write("Харчування, ");
            if (вид == 1)
            {
                Console.Write("овочі, ");
            }
            else if (вид == 2)
            {
                Console.Write("фрукти, ");
            }
            else if (вид == 3)
            {
                Console.Write("крупи, ");
            }
        }
        if (стан == 1)
        {
            Console.Write("прийшло.");
        }
        else if (стан == 2)
        {
            Console.Write("продано.");
        }
        else if (стан == 3)
        {
            Console.Write("списано.");
        }
        else if (стан == 4)
        {
            Console.Write("передано на інший магазин.");
        }
        Console.WriteLine();
    }
}

class Program
{
    

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        List<Wares> wares = new List<Wares>();
        int a = 0;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("\t\tТовари");
            Console.WriteLine("Меню:\n"
                + "1) Переглянути усі товари\n"
                + "2) Додати товар\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (a == 1)
            {
                for (int i = 0; i < wares.Count(); i++)
                {
                    wares[i].see();
                }
            }
            else if (a == 2)
            {
                wares.Add(new Wares());
            }
            else
            {
                Console.WriteLine("Такої команди не існує");           
            }
        }
    }
}
