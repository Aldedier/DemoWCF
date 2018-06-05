using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculadora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculadora.svc or Calculadora.svc.cs at the Solution Explorer and start debugging.
    public class Calculadora : ICalculadora
    {
        public double Division(double n1, double n2) => n1 / n2;
        

        public double Multiplicacion(double n1, double n2) => n1 * n2;


        public double Resta(double n1, double n2) => n1 - n2;


        public double Suma(double n1, double n2) => n1 + n2;
    }
}
