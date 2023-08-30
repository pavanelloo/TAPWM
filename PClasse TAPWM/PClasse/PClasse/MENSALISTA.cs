using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    class MENSALISTA : EMPREGADO
    {
        public double SalarioMensal { get; set; }

        public static String Empresa = "Finka Tech Ltda";


        public override double SalarioBruto()
        {
         return SalarioMensal;
        }

        public MENSALISTA(int matx, string nomex, DateTime datax,
            double salx)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salx;
        }
        public MENSALISTA()
        {

        }



    }
}
