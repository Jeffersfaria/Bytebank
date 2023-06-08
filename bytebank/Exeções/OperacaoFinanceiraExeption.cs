namespace ByteBank.Exeções;

public class OperacaoFinanceiraExeption : Exception
{
    public OperacaoFinanceiraExeption(string mensagem) : base(mensagem)
    {
        
    }

    public OperacaoFinanceiraExeption(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
    {
        
    }
}