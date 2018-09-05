using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    public class Persona
    {
        public double salarios;
        public Persona(double salario)
        {
            salarios = salario;
        }

        public static double operator +(Persona x, Persona y)
        {
            return x.salarios + y.salarios;
        }

        
       
    }
}
