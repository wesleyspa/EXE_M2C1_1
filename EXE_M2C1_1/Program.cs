using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pes = new Pessoa();
            pes.nome = "Joana (Pessoa)";
            pes.idade = 19;
            pes.Cumprimentar();
            pes.DizerIdade();

            Aluno alu = new Aluno();
            alu.nome = "Wesley (Aluno)";
            alu.idade = 20;
            alu.Cumprimentar();
            alu.DizerIdade();
            alu.IrParaEscola();

            Professor prof = new Professor();
            prof.nome = "Cleber (Professor)";
            prof.idade = 30;            
            prof.Cumprimentar();
            prof.DizerIdade();
            prof.Explicar("Banco de Dados");

        }
    }


    public class Pessoa
    {
        private string _nome;       
        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        private int _idade;
        public int idade
        {
            get
            {
                return _idade;
            }
            set
            {
                _idade = value;
            }
        }

        public void Cumprimentar()
        {
            string texto = String.Format("Ola, meu nome é {0}. \n", this._nome);
            Console.WriteLine(texto);
        }

        public void DizerIdade()
        {
            string texto = String.Format("Tenho {0} anos \n", this._idade);
            Console.WriteLine(texto);
        }

    }

    public class Aluno : Pessoa
    {
        public void IrParaEscola()
        {
            Console.WriteLine("Estou indo para a escola \n");
        }
    }

    public class Professor : Pessoa
    {
        public void Explicar(string assunto)
        {
            Console.WriteLine("Vou lhe explicar sobre o seguinte assunto {0} \n", assunto);
        }
    }
}
