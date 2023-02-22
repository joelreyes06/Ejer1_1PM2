using Ejer1PM2.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer1PM2
{
    internal class Operaciones
    {
            private double num1;
            private double num2;

        
            public double Num1 
            { 
            get { return num1; } 
            set { num1=value; }
             }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }


        public double Suma()
        {
            return num1+num2;
        }

        public double Resta()
        {
            return num1-num2;
        }

        public double Multiplicacion()
        {
            return num1*num2;
        }

        public double Division()
        {
            return num1/num2;
        }
    }
}
