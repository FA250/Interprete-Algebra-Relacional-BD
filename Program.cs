using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public String comprobareq_msj(String[] atributos, String tabla1, String tabla2)
        {
            String mensj = "";
            foreach (String atrib in atributos)
            {
                mensj += tabla1 + "." + atrib + "=" + tabla2 + "." + atrib + " and ";
            }
            mensj = mensj.Remove(mensj.Length - 5);
            return mensj;
        }
        static void Main(string[] args)
        {
            Program a=new Program();
            string[] atributos = { "atr1", "atr2", "atr3" };
            Console.WriteLine(a.comprobareq_msj(atributos, "tabla1", "tabla2"));
            Console.Read();
        }
    }
}
