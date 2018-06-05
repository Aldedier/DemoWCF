using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculadora" in both code and config file together.
    [ServiceContract]
    public interface ICalculadora
    {
        [OperationContract]
        double Suma(double n1, double n2);


        double Resta(double n1, double n2);

        [OperationContract]
        double Multiplicacion(double n1, double n2);

        [OperationContract]
        double Division(double n1, double n2);
    }
}
