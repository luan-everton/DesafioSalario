using ReajusteSalario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Salario
{
    class Vendedor : funcionario
    {
        public override double Bonus()
        {
            return salario * 0.07;
           
        }
    }
}
