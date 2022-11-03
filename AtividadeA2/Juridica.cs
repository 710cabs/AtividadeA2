namespace AtividadeA2;

public class Juridica : Pessoa 
{
    private string cnpj;


    public string Cnpj { get => cnpj; set => cnpj = value; }


    public Juridica(string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, string id, string cnpj) : base(nome, email, dataNascimento, telefone, cidade, password, id)
    {
        this.cnpj = cnpj;
    }


}
