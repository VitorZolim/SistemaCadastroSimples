﻿namespace SistemaCadastro
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

    }
}
