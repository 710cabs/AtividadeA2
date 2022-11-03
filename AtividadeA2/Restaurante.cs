namespace AtividadeA2;

public class Restaurante 
{
    private string endereco;

    private string nome;

    private string descricao;

    private int id;
    

    public string Endereco { get => endereco; set => endereco = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public int Id { get => id; set => id = value; }

    public Restaurante(string endereco, string nome, string descricao, int id)
    {
        this.endereco = endereco;
        this.nome = nome;
        this.descricao = descricao;
        this.id = id;
    }

}