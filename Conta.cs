public class Conta
{
    public int Codigo { get; }
    public double Saldo  { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        ValidarValor(valor);
        ValidarSaldo(valor);
        Saldo=Saldo-valor;
    }

    public void Depositar(double valor)
    {
        ValidarValor(valor);
        Saldo+=valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        Sacar(valor);
        conta.Depositar(valor);
    }

    public void ValidarValor(double valor)
    {
        if (valor <= 0.0) throw new ArgumentException("Valor precia ser maior que zero");
    }

    public void ValidarSaldo(double valor)
    {
        if(valor > Saldo) throw new ArgumentException("Saldo insuficiente para realizar a transação");
    }
}