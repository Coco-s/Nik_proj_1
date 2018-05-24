using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_proj_1
{
    class Program
    {
        static bool Prost(int value)
        {
            bool flag = true;
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
          }

        static int NProst(int value)
        {
            int pnext = value + 1;
            if (Prost(value))
            {
                while (!Prost(pnext))
                {
                    pnext += 1;
                }
                return pnext;
            }
            else return -1;
        }

        static void Main(string[] args)
        {
            bool fl = true;
            int anch = 0;
            int pnext = 0;
            int plast = 0;
           
            Console.WriteLine("Введите число\n");
            int ch = int.Parse(Console.ReadLine());
            for (int i = 2; i <= ch / 2; i++)
            {
                if (ch % i == 0 && fl == true) 
                {
                    anch = i;
                    fl = false;
                }
            }
            int first = anch;
            pnext = NProst(anch);
            if (ch % pnext == 0)
            {
                anch = pnext;
            }
            plast = NProst(pnext);
            if (ch % plast == 0)
            {
                Console.WriteLine("Succes");
                Console.WriteLine(first);
                Console.WriteLine(pnext);
                Console.WriteLine(plast);
            } 
            else Console.WriteLine("Sosat'!");
        }
    }
}
