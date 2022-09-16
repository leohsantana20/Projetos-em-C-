using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public class Retangulo
    {

        public Retangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }
    
        // Base Retangulo

        private Double baseret;

        public Double Base
        {
            get { return baseret; }
            set { 
                if (value >=0)
                    baseret = value; 
                else baseret = 0;
                }
        }

        // Altura Retangulo

        private Double alturaret;

        public Double Altura
        {
            get { return alturaret; }
            set {
                if (value >= 0)
                    alturaret = value;
                else alturaret = 0;
                }
        }

        public Double Area
        {
            get { return alturaret * baseret; }
        }


        public void ExibirDados()
        {
            Console.WriteLine("Base: "+this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }



















    }
}
