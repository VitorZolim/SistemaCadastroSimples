using System.IO;

namespace SistemaCadastro
{
    class Lista
    {
        private List<Cliente> ContasArmazenadas = new List<Cliente>();

        private string Path = @"C:\Users\vitor\Documents\Banco\ContasSalvas.txt";

        public Lista()
        {

        }
        public IEnumerable<Cliente> ListarContas()
        {
            return ContasArmazenadas.AsEnumerable();
        }
        public void AdicionarConta(Cliente _conta)
        {
            ContasArmazenadas.Add(_conta);
        }
        public void RemoverConta(Cliente _conta)
        {
            ContasArmazenadas.Remove(_conta);
        }

        public bool VerificarLista()
        {
            if(!ContasArmazenadas.Any()) { return true;}
            else {return false;}
        }
    }
}
