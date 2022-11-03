namespace AtividadeA2;

public class Fisica : Pessoa
{
    private string cpf;
    
    public string Cpf { get => cpf; set => cpf = value; }

     public Fisica(string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, string id, string cpf) : base(nome, email, dataNascimento, telefone, cidade, password, id)
    {
        this.cpf = cpf;
    }
}
