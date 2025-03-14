namespace SistemaCadastro
{
    class Lista
    {
        private List<Cliente> ContasArmazenadas = new List<Cliente>();

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
            if(ContasArmazenadas.Count() == 0) { return true;}
            else {return false;}
        }
    }
}
