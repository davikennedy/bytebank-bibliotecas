using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url)) 
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazi.", nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = URL.Substring(++indiceInterrogacao);
        }
        public string GetValor(string nomeParametro)
        {
            return "";
            //int indiceParametro = _argumentos.IndexOf(nomeParametro);
        }
    }
}
