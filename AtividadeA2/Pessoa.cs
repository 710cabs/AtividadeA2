namespace AtividadeA2
{
    public abstract class Pessoa
    {
        protected string nome;

        protected string email;

        protected DateTime dataNascimento;

        protected string telefone;

        protected string cidade;

        protected string password;

        protected string id;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Password { get => password; set => password = value; }
        public string Id { get => id; set => id = value; }


        public Pessoa(string nome, string email, DateTime dataNascimento, string telefone, string cidade, string password, string id)
        {
            this.nome = nome;
            this.email = email;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.cidade = cidade;
            this.password = password;
            this.id = id;
        }

        
    }

}

    
        
        
