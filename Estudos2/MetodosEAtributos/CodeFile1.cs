public class Conta // definição de atributos dentro da classe // 
{
    public string titular;
    public int numeroDaConta;
    public double saldo { get; set; }
    //public double deposito;
  
    public bool Deposita(double valor) // outro metodo 
    {
        if (saldo >= valor)
        {
            this.saldo += valor;
            return true;
        }
        else
            return false;
    }
   
    public bool Saca(double valor) // Atribuindo um metodo // 
    {

        if (saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
            return false;
    }
}

public class Cliente:Conta
{
    
}