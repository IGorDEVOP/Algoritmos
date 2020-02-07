public class Conta
{
    private string titular { get; set; }
    private int numero { get; set; }
    private double saldo = 1000;
    public double taxa { get; protected set; }

    public Conta()
    {
        taxa = 0.10;
    }

    // manuseio de acesso aos properties get and set // 
    public double Saldo
    {
        get
        {
          return this.saldo;
        }
    }
    public int Numero
    {
        get
        {   return this.numero;
        }
        set
        { this.numero = value;
        }
    }
        // Metodos de atributos // 
    public bool Saca(double valor)
    {
        if (saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
            return false;
    }
    
    public double PegaSaldo()
    {
        return this.saldo;
    }

    public void ColocaNumero(int numero)
    {
        this.numero = numero;
    }

    public bool Deposita(double valor)
    {
        if (saldo >= valor)
        {
            this.saldo += valor;
            return true;
        }
        else
            return false;
    }


}

public class ContaFisica : Conta
{

}

public class  ContaPoupanca : Conta
{                                                                                                                     
    
}