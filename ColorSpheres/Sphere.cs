using System;
using System.Drawing;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float raio;
        private int vezesat;
        private const int vezesati = 0;
        public Sphere(Color color, float r)
        {
            this.color = color;
            raio = r;
            vezesat = vezesati;
        }
        public void pop()
        {
            Console.WriteLine("Sphere was popped");
            raio = 0f;
        }
        public void Throw()
        {
            if (raio > 0)
            {
            vezesat +=1;
            Console.WriteLine("Sphere was thrown");
            }
            else
            {
                Console.WriteLine("Sphere is popped can't be thrown");
            }
        }
        public void Gettime()
        {
            Console.WriteLine($"Sphere was Thrown {vezesat} times");
        }
    }
}