using System;

namespace ContaBancaria.Entidades.Excecao
{
    class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string mensagem)
            : base(mensagem)
        {
        }
    }
}