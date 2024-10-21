public class PessoaJuridica : Pessoa
{
    private string _cnpj;
    private string _nomeFantasia;

    public string CNPJ
    {
        get { return _cnpj; }
        set { _cnpj = value; }
    }

    public string NomeFantasia
    {
        get { return _nomeFantasia; }
        set { _nomeFantasia = value; }
    }
    
    public PessoaJuridica(string nome, string email, string telefone, string cnpj, string nomeFantasia)
        : base(nome, email, telefone)
    {
        _cnpj = cnpj;
        _nomeFantasia = nomeFantasia;
    }
    public override double ValorDeCopia(int quantidade)
    {
        return base.ValorDeCopia(quantidade) + (quantidade * 2.0);
    }
}
