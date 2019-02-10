using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            TakeChar znak = new TakeChar();
            znak.TakeChars();
        }
    }
    class TakeChar
    {
        public void TakeChars()
        {
            Console.WriteLine("podaj ciag znakow do zakodowania w skroconej wersji");
            string mark = Console.ReadLine();
            char[] sentence = new char[mark.Length];
            int[] count = new int[mark.Length];
            int num = 1;
            sentence = mark.ToCharArray();
            
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i>0)
                {
                    
                    if (sentence[i] == sentence[i - 1])
                    { 
                        num++;
                    }
                    else
                    {
                        Console.WriteLine("" + num + "");
                        num = 1;
                        Console.WriteLine("" + sentence[i] + "");
                        Console.ReadKey();
                    }
                    
                }
                else
                {
                    Console.WriteLine("" + sentence[i] + "");
                }
                

            }
            
            
        }
    }
    
}
