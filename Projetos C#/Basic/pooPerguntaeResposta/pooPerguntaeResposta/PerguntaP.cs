using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaeResposta
{
    public class PerguntaP:Pergunta
    {
        public PerguntaP():base()
        {
            this.Texto = "";
            this.Resposta = "";
            this.Dica = "";
        }

        public PerguntaP(String texto, String resposta, String dica):base(texto, resposta)
        {
            this.Dica = dica;
        }

        public String Dica { get; set; }
    }
}
