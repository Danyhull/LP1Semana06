using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolasAtiradasTotal = 0;
            //making colors
            Color red = new Color(255, 0,0,255);
            Color green = new Color(0, 255,0,255);
            Color blue = new Color(0, 0,255,255);
            //creates all spheres
            Sphere RedSphere = new Sphere(red, 2f);
            Sphere greenSphere = new Sphere(green, 4f);
            Sphere blueSphere = new Sphere(blue, 6f);

            RedSphere.Pop = 11;
            RedSphere.Throw = 13;
            greenSphere.Throw = 12;
            greenSphere.Throw = 13;
            greenSphere.Throw = 7;
            greenSphere.Throw = 2;
            blueSphere.Throw = 2;
            bolasAtiradasTotal += RedSphere.GetTimesThrown;
            bolasAtiradasTotal += greenSphere.GetTimesThrown;
            bolasAtiradasTotal += blueSphere.GetTimesThrown;

            Console.WriteLine(bolasAtiradasTotal);
        }
    }
}