using System.Linq;

namespace SistemaCadastro
{
    class Inicializar
    {
        
        Lista ContasSalvas = new Lista();
        public void ExibirMenu()
        {
            bool Repeticao = true;
            while (Repeticao)
            {
                Display();
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        ContasSalvas.AdicionarConta(Cliente.NovoCadastro());
                        break;
                    case "2":
                        if (ContasSalvas.VerificarLista()) 
                        {
                            Console.WriteLine("\n[Sem contas]\n");
                            break;
                        }
                        foreach (Cliente conta in ContasSalvas.ListarContas())
                        {
                            conta.ExibirInfo();
                        }
                        break;
                    case "3":
                        if (ContasSalvas.VerificarLista())
                        {
                            Console.WriteLine("\n[Sem contas]\n");
                            break;
                        }
                        Console.WriteLine("Escreva o Email (Corretamente) para remover:");
                        string ContaRemove = Console.ReadLine();
                        List<Cliente> TotalContas = ContasSalvas.ListarContas().ToList();
                        if (Validar.VerificarEmail(ContaRemove, TotalContas))
                        {
                            for (int i = TotalContas.Count - 1; i >= 0; i--)
                            {
                                if (TotalContas[i]._Email == ContaRemove)
                                {
                                    ContasSalvas.RemoverConta(TotalContas[i]);
                                    Console.WriteLine("\n[Conta Removida]\n");
                                }
                            }
                        }
                        else { Console.WriteLine("\n[Email não Encontrado]\n"); }
                            break;
                    case "4":
                        Repeticao = false;
                        Console.WriteLine("[Finalizado]");
                        break;
                    default:
                        Console.WriteLine("[Opção Inválida]");
                        break;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("\n---Sistema de Cadastro---\n");
            Console.WriteLine("[1] Cadastrar Cliente\n[2] Listar Cliente\n[3] Remover Cliente\n[4] Fechar");
        }
    }
}
