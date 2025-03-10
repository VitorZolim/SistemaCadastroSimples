namespace SistemaCadastro
{
    public class Cliente
    {//{ get { return Nome; } set { if(value!= null){Nome = value;} } }
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

        public static Cliente CriarConta(string nome, int idade, string email)
        {
            return new Cliente(nome, idade, email);
        }
        public static Cliente NovoCadastro()
        {
            Console.Clear();
            Console.WriteLine("\n===Novo Cadastro===\n");
            Console.Write("Nome: ");
            string _nome = Console.ReadLine();
            Console.Write("Idade: ");
            int _idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            string _email = Console.ReadLine();
            if(string.IsNullOrEmpty(_nome)|| string.IsNullOrEmpty(_email)|| !_email.Contains("@"))
            {
                Console.WriteLine("[ERRO] - Nova Conta Negada");
                return null;
            }
            Console.WriteLine("\n[Adicionado com Sucesso]\n");
            return Cliente.CriarConta(_nome, _idade, _email);
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Email: {Email}");
        }

    }
}
