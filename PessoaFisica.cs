public class PessoaFisica : Pessoa
{
    private string _cpf;
    private string _rg;

    // Propriedades (getters e setters)
   
    public string CPF {get; set;}
    public string RG {get; set;}

    // Construtor
    public PessoaFisica(string nome, string email, string telefone, string cpf, string rg)
        : base(nome, email, telefone)
    {
        _cpf = cpf;
        _rg = rg;
    }

    // Sobrescrita do método ValorDeCopia
    public override double ValorDeCopia(int quantidade)
    {
        return base.ValorDeCopia(quantidade) + (quantidade * 1.0);
    }
}
