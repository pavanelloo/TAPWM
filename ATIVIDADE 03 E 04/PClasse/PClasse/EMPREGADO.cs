using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    abstract class EMPREGADO
    {
        private int matricula; // atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula // propriedade
        {
            get { return matricula; }
            set { matricula = value; }

        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //métodos

        public String VerificaHome()//método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado NÃO trabalha em home Office";
        }
        //virtual --> pode ser sobreescrito

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);

            return (span.Days);
        }
        public abstract double SalarioBruto();

        public EMPREGADO()
        {
            System.Windows.Forms.MessageBox.Show("PASSEI POR AQUI");
        }

        public EMPREGADO(int mat, string nome, DateTime datax)
        {
            matricula = mat;
            nomeEmpregado = nome;
            dataEntradaEmpresa = datax;
        }
    }


}
