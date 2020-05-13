using Desafio_Salario;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ReajusteSalario
{
    abstract class funcionario 
    {
        
        public string nome { get; set; }

        public  string sexo { get; set; }

        public DateTime nascimento { get; set; }
        public string cpf { get; set; }

        public double salario { get; set; }


        public abstract double Bonus();


    


    }
}
