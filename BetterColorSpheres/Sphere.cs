using System;
using System.Drawing;

namespace BetterColorSpheres
{
    class Sphere{
        private readonly Color cor;
        private float raio;
        private  int quantasVezesAtirada;

        private  const int quantasVezesAtiradaMin = 0;
        private  const float raioreset = 0f;
        public Sphere(Color cor,float r){
            this.cor = cor;
            raio = r;
            quantasVezesAtirada = quantasVezesAtiradaMin;

        }  
        public float Pop{
            set
            {
                raio = raioreset;
            }
            
            
        }
        public int Throw
        {
            set
            {
                if (raio > 0){
                    quantasVezesAtirada += value; 
                    Console.WriteLine("Sphere was Thrown");
                } else{
                    Console.WriteLine("Sphere is popped cannot be thrown");
                }
            }           
            get
            {
                return quantasVezesAtirada;
            }


        }
        public int GetTimesThrown{
            get { return quantasVezesAtirada;}
            
        }

    }
}