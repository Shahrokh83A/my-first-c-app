using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace فرمول های دایره
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // متغییر ها
            double Pi = Math.PI;
            double ghotr;
            double mohit;
            double masahat;
            double voroodi;
            // شرط ها
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                  mohasebat DAYERE                                       ");
            Console.WriteLine();
            // تابع
            void mohasebe(double shoa)
            {
                ghotr = shoa * 2;
                mohit = ghotr * Pi;
                masahat = (shoa * shoa) * Pi;
                Console.Write("ghotr = ");
                Console.WriteLine(ghotr);
                Console.Write("mohite = ");
                Console.WriteLine(mohit);
                Console.Write("masahat = ");
                Console.WriteLine(masahat);
                ghotr = 0; masahat = 0; mohit = 0;
                Console.WriteLine();
            }
            // حلقه
            while (true)
            {
                try
                {

                    while (true)
                    {
                        Console.WriteLine("shoaye dayere khod ra vared konid : ");
                        voroodi = Convert.ToDouble(Console.ReadLine());
                        if (voroodi < 0)
                        {
                            Console.WriteLine("lotfan adad mosbat vared konid!!!!\n");
                            break;
                        }
                        mohasebe(voroodi);
                    }
                }
                catch
                {
                    Console.WriteLine("lotfan adad vared konid !!!");
                }
            }
        }
    }
}
