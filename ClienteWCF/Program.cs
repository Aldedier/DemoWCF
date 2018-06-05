using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Proxy.Service1Client service = new Proxy.Service1Client())
            {
                Console.WriteLine("Ingrese un numero para consumir el servicio");
                string valueResponse = service.GetData(Convert.ToInt16(Console.ReadLine()));
                Console.WriteLine(valueResponse);
            }

            using (ProxyCalculadora.CalculadoraClient operacion = new ProxyCalculadora.CalculadoraClient())
            {
                Console.WriteLine("Ingrese un numero para consumir el servicio de suma");
                int num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese un otro numero!!!!");
                int num2 = Convert.ToInt16(Console.ReadLine());
                double suma = operacion.Suma(num1,num2);
                Console.Write("La suma es:");
                Console.WriteLine(suma);

            }

            Console.ReadKey();
        }
    }
}
