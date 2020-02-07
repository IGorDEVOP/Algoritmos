using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçoeDeVariaveis
{

     abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public string Endereco { get; protected set; }
        public  string getNome()
        {
            return Nome;
        }

        public  void setNome(string nome)
        {
            this.Nome = nome; 
        }

    }
    class PessoaFisica : Pessoa
    {

        public int rg  { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string getCpf()
        {
            return CPF;
        }
        public void setcpf(string cpf)
        {
            this.CPF = cpf;
        }

        

        
    }
    class PessoaJuridica : Pessoa
    { 

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string getcnpj()
        {
            return Cnpj;
        }
        public void setcnpj(string cnpj)
        {
            this.Cnpj = cnpj;
        }
    }
}
