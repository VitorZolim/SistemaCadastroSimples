namespace SistemaCadastro
{
    public class Cliente
    {
        private string Nome { get; set; }
        private int Idade {get;set;}
        private string Email { get; set; }
        public string _Email { get { return Email; } set { Email = value; } }

        private Cliente(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }
        public Cliente()
        {
        }

        public static Cliente CriarConta(string nome, int idade, string email)
        {
            return new Cliente(nome, idade, email);
        }
        public Cliente NovoCadastro()
        {
            Console.Clear();
            Console.WriteLine("\n===Novo Cadastro===\n");
            Console.Write("Nome: ");
            string _nome = Console.ReadLine();
            Console.Write("Idade: ");
            string _idade = Console.ReadLine();
            Console.Write("Email: ");
            string _email = Console.ReadLine();
            if(Validar.VerificarConta(_nome,_idade,_email))
            {
                Console.WriteLine("[ERRO] - (Informações Invalidas) - Nova Conta Negada");
                return null;
            }
            int _idadeNUM;
            int.TryParse(_idade, out _idadeNUM);
            Console.WriteLine("\n[Adicionado com Sucesso]\n");
            return Cliente.CriarConta(_nome, _idadeNUM, _email);
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Email: {Email}");
        }

    }
}
