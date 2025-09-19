using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello World!");
        }
        static void F2()
        {
            Console.WriteLine("Mi a neved: ");
            string name = Console.ReadLine();
            Console.WriteLine("Szia {0}", name);
        }
        static void F3()
        {
            Console.WriteLine("Írj be egy számot: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A szám kétszerese: {0}", num * 2);
        }
        static void F4()
        {
            Console.WriteLine("Írj be egy számot: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Írj be megint egy számot: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A két szám összege: {0} \n különbsége: {1} \n szorzata: {2} \n hányadosa: {3}", num2 + num3, num2 - num3, num2 * num3, num2 / num3);
        }
        static void F5()
        {
            Console.WriteLine("Első egész szám:");
            int fullnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Második egész szám:");
            int fullnum2 = Convert.ToInt32(Console.ReadLine());

            if (fullnum > fullnum2)
            {
                Console.WriteLine("{0} nagyobb mint {1}", fullnum, fullnum2);
            }
            else if (fullnum < fullnum2)
            {
                Console.WriteLine("{0} nagyobb mint {1}", fullnum2, fullnum);
            }
            else
            {
                Console.WriteLine("A két szám egyenlő");
            }
        }
        static void F6()
        {
            Console.WriteLine("1. szám: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. szám: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. szám: ");
            int szam3 = Convert.ToInt32(Console.ReadLine());

            if (szam1 < szam2 && szam1 < szam3)
            {
                Console.WriteLine("{0}a legkisebb", szam1);
            }
            else if (szam2 < szam1 && szam2 < szam3)
            {
                Console.WriteLine("{0} a legkisebb", szam2);
            }
            else
            {
                Console.WriteLine("{0} a legkisebb", szam3);
            }
        }
        static void F7()
        {
            Console.WriteLine("a oldal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b oldal: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c oldal: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c || a + c > b || b + c > a)
            {
                Console.WriteLine("A háromszög szerkezthető");
            }
            else
            {
                Console.WriteLine("Nem");
            }
        }
        static void F8()
        {
            Console.WriteLine("Első szám: ");
            int number8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. szám: ");
            int number9 = Convert.ToInt32(Console.ReadLine());

            if (number8 < 0 || number9 < 0)
            {
                Console.WriteLine("Hiba");
            }
            else
            {
                Console.WriteLine("Számtani közép: {0},\n Mértani közép: {1}", (number8 + number9) % 2, Math.Sqrt(number8 * number9));
            }
        }
        static void F9()
        {
            Console.WriteLine("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Nem jó");
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    Console.WriteLine("2 valós megoldás");
                }
                else if (b == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Egy megoldás");
                }
                else
                {
                    Console.WriteLine("Nincs megoldás");
                }
            }
        }
        static void F10()
        {
            Console.WriteLine("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Nem jó");
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("2 valós megoldás: x1:{0}, x2{1}", x1, x2);
                }
                else if (b == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Egy megoldás: {0}", x);
                }
                else
                {
                    Console.WriteLine("Nincs megoldás");
                }
            }
        }
        static void F11()
        {
            Console.WriteLine("Első befogó: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. befogó: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Átfogó: {0:0.00}", c);
        }
        static void F12()
        {
            Console.WriteLine("Első él: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. él: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3. él: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;

            Console.WriteLine("Felszín: {0:0.00}", felszin);
            Console.WriteLine("Térfogat: {0:0.00}", terfogat);
        }
        static void F13()
        {
            Console.WriteLine("Kör átmérő");
            double d = Convert.ToDouble(Console.ReadLine());

            double kerulet = Math.PI * d;
            double terulet = Math.PI * d * d / 4;

            Console.WriteLine("Kerület: {0:0.00}", kerulet);
            Console.WriteLine("Terület: {0:0.00}", terulet);
        }
        static void F14()
        {
            Console.WriteLine("Kör sugár: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Középpont szög: ");
            double fok = Convert.ToDouble(Console.ReadLine());

            double terulet = Math.PI * r * r * (fok / 360);
            double ivhossz = 2 * Math.PI * r * (fok / 360);

            Console.WriteLine("Körszelet területe: {0:0.00}", terulet);
            Console.WriteLine("Ív hossza: {0:0.00}", ivhossz);
        }
        /*15. Feladattól*/
        static void F15()
        {
            Console.WriteLine("Írj be egy számot: ");
            int positive = Convert.ToInt32(Console.ReadLine());

            if (positive < 0)
            {
                Console.WriteLine("Hiba");
            }
            else
            {
                for (int i = 0; i <= positive; i++)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
        static void F16()
        {
            Console.WriteLine("Írj be egy számot: ");
            int positive2 = Convert.ToInt32(Console.ReadLine());

            if (positive2 < 0)
            {
                Console.WriteLine("Hiba");
            }
            else
            {
                for (int i = 0; i <= positive2; i++)
                {
                    Console.WriteLine("{0}\n ", i);
                }
            }
        }
        static void F17()
        {
            Console.WriteLine("Adj meg egy számot: ");
            int osztos = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= osztos; i++)
            {
                if (osztos % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void F18()
        {
            Console.WriteLine("Adj meg egy számot: ");
            int osztos = Convert.ToInt32(Console.ReadLine());

            int osztok = 0;
            for (int i = 1; i <= osztos; i++)
            {
                if (osztos % i == 0)
                {
                    osztok += i;
                }
            }
            Console.WriteLine("Osztók összege: {0}", osztok);
        }
        static void F19()
        {
            Console.WriteLine("Ad meg a számot:");
            int perfectnumber = Convert.ToInt32(Console.ReadLine());

            int osztokosszege = 0;
            if (perfectnumber < 0)
            {
                Console.WriteLine("Hiba");
            }
            else
            {
                for (int i = 1; i < perfectnumber; i++)
                {
                    if (perfectnumber % i == 0)
                    {
                        osztokosszege += i;
                    }
                }
                if (osztokosszege == perfectnumber * 2)
                {
                    Console.WriteLine("Tökéletes szám");
                }
                else
                {
                    Console.WriteLine("Nem az");
                }
            }
        }
        static void F20()
        {
            Console.WriteLine("Hatvány alap:");
            int alap = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kitevő:");
            int kitevo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hatványérték: {0}", Math.Pow(alap, kitevo));
        }
        static void F21()
        {
            int szam;

            do
            {
                Console.WriteLine("Írj be egy számot");
                szam = Convert.ToInt32(Console.ReadLine());
            } while (szam > 0);
        }
        static void F22()
        {
            int szam;
            int osszeg = 0;
            do
            {
                Console.WriteLine("Kell egy szám: ");
                szam = Convert.ToInt32(Console.ReadLine());

                if (szam < 10)
                {
                    osszeg += szam;
                }

            } while (szam < 10);
            Console.WriteLine("Összeg: {0}", osszeg);
        }
        static void F23()
        {
            Console.Write("Kérek egy egész számot: ");
            int eredetiSzam = Convert.ToInt32(Console.ReadLine());
            int szam = eredetiSzam;

            List<string> tenyezok = new List<string>();

            while (szam % 2 == 0)
            {
                tenyezok.Add("2");
                szam /= 2;
            }

            if (szam > 1 || tenyezok.Count == 0)
            {
                tenyezok.Add(szam.ToString());
            }

            Console.WriteLine(String.Format("{0} = {1}", eredetiSzam, string.Join("*", tenyezok)));
        }
        static void F24()
        {
            string szo;
            string alma = "alma";

            do
            {
                Console.WriteLine("Írj be egy szót");
                szo = Console.ReadLine();
            } while (szo != alma);
        }
        static void F25()
        {
            Console.WriteLine("Írj be egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            while(szam > 3)
            {
                szam -= 3;
                if(szam < 3)
                {
                    Console.WriteLine("Maradékos osztás: {0}", szam / 3);
                }
            }
        }
        static void F26()
        {
            Console.WriteLine("Kérek egy számot: ");
            int prim = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= prim; i++)
            {
                if(prim % i == 0 && i != 1 || i != prim)
                {
                    Console.WriteLine("Nem prím");
                }
                else
                {
                    Console.WriteLine("Prím");
                }
            }
        }
        static void F27()
        {
            Console.WriteLine("Írj be egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
             
            for(int i = 2; i <= szam; i++)
            {
                bool prime = true;
                for(int oszto = 2; oszto <= Math.Sqrt(i); oszto++)
                {
                    if(i % oszto == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime)
                {
                    Console.WriteLine(i);
                }
            }   
        }
        static void F28()
        {

        }

        static void Main(string[] args)
        {
            F1();F2();F3();F4();F5();F6();F7();F8();F9();F10();F11();F12();F13();F14();
            F15();F16();F17();F18();F19();F20();F21();F22();F23();F24();F25();F26();F27();
        }
    }
}
