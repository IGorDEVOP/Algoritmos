using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Nodo
    {
        private Nodo pai_Nome = null;

        private Nodo no_Direita = null;

        private Nodo no_Esquerda = null;

        private int Valor = 0;

        public int get_valor() { return Valor; }

        public void set_Data(int v) { Valor = v; }

        public void set_no_pai(Nodo no) { pai_Nome = no; }

        public void set_no_NomeDireita(Nodo no) { no_Direita = no; }

        public void set_no_NomeEsquerda(Nodo no) { no_Esquerda = no; }

        public Nodo get_no_PaiNome() { return pai_Nome; }

        public Nodo get_no_NomeDireita() { return no_Direita; }

        public Nodo get_no_NomeEsquerda() { return no_Esquerda; }

    }
    public class ArvoreBoloSemanal
    {
        private Nodo raizBolo = null;

        private int qtde = 0;

        private string resultado = " ";

        public int qtd_nos_Internos()
        {
            return qtde;
        }


        public bool no_e_Externo(Nodo no)
        {
            return (no.get_no_NomeDireita() == null) && (no.get_no_NomeEsquerda() == null);
        }

        public Nodo create_No_externo(Nodo Nopai) // nodo externo
        {
            Nodo no = new Nodo();
            no.set_no_pai(Nopai);
            return no;
        }

        public void insere(int valor)
        {
            Nodo no_aux;

            if (qtde == 0)
            {
                Console.WriteLine("Bolo semanal vazio\n");
                no_aux = new Nodo();
                raizBolo = no_aux;
            }
            else
            {
                no_aux = raizBolo;
                while (no_e_Externo(no_aux) == false)
                {
                    if (valor > no_aux.get_valor())
                        no_aux = no_aux.get_no_NomeDireita();
                    else
                        no_aux = no_aux.get_no_NomeEsquerda();
                }
            }

            no_aux.set_Data(valor);
            no_aux.set_no_NomeDireita(create_No_externo(no_aux));
            no_aux.set_no_NomeEsquerda(create_No_externo(no_aux));
            qtde++;
        }

        private void Read_Nodo(Nodo no)
        {
            if (no_e_Externo(no))
                return;

            Read_Nodo(no.get_no_NomeEsquerda());
            resultado = resultado + " " + Convert.ToInt32(no.get_valor());
            Read_Nodo(no.get_no_NomeDireita());
        }

        public string Listagem()
        {
            resultado = "";
            Read_Nodo(raizBolo);
            return resultado;
        }
    }
}
