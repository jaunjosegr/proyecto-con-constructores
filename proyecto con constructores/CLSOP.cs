using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_con_constructores
{
    internal class CLSOP
    {
        private double n1;
        private double n2;

        //constructor
        public CLSOP(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        //Encapsulamiento (las variables que se van a utilizar son N1 Y N2) 
        public double N1{ get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }

        //constructor vacio
        public CLSOP ()
        {

        }

        //Metodo
        public double DVSN()
        {
            return n1/ n2;
        }

    }

}
