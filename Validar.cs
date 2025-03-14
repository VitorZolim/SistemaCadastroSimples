namespace SistemaCadastro
{
    class Validar
    {
        public static bool VerificarEmail(string RemoveConta, List<Cliente> ListaConta)
        {
            for (int i = ListaConta.Count - 1; i >= 0; i--)
            {
                if (ListaConta[i]._Email == RemoveConta)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool VerificarConta(string _nome, string _idade, string _email)
        {
            if (string.IsNullOrEmpty(_nome) || string.IsNullOrEmpty(_email) || !_email.Contains("@") || string.IsNullOrEmpty(_idade))
            {
                return true;
            }
            return false;
        }

    }
}
