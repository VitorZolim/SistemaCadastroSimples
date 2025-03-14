using System.Linq;

namespace SistemaCadastro
{
    class Inicializar
    {
        
        Lista ContasSalvas = new Lista();
        Cliente CriandoConta = new Cliente();
        public void ExibirMenu()
        {
            bool Repeticao = true;
            while (Repeticao)
            {
                Display();
                string opcao = Console.ReadLine();
                Console.WriteLine();
                switch (opcao)
                {
                    case "1":
                        var Conta = CriandoConta.NovoCadastro();
                        if(Conta == null)
                        {
                            break;
                        }
                        ContasSalvas.AdicionarConta(Conta);
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
                        Console.Clear();
                        break;
                    case "5":
                        Repeticao = false;
                        Console.WriteLine("[Finalizado]");
                        break;
                    default:
                        Console.WriteLine("[Opção Inválida]");
                        break;
                }
            }
        }
        private void Display()
        {
            Console.WriteLine("\n---Sistema de Cadastro---\n");
            Console.Write("[1] Cadastrar Cliente\n[2] Listar Cliente\n[3] Remover Cliente\n[4] Limpar tela\n[5] Fechar\nOpçao: ");
        }
    }
}
