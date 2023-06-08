namespace ByteBank.Exeções;

public class SaldoInsuficienteExeption : OperacaoFinanceiraExeption 
{
    public SaldoInsuficienteExeption(string mensagem) : base(mensagem)
    {
        
    }
}