using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cores
            Color red = new Color(255,0,0,255);
            Color green = new Color(0,255,0,255);
            Color blue = new Color(0,0,255,255);

            //TodasEsferas
            Sphere RedSphere = new Sphere(red, 2f);
            Sphere GreenSphere = new Sphere(green, 4f);
            Sphere BlueSphere = new Sphere(blue, 6f);

            RedSphere.pop();
            GreenSphere.Throw();
            BlueSphere.Throw();
            BlueSphere.Throw();
            GreenSphere.Throw();
            RedSphere.GetTimesThrown();
            BlueSphere.GetTimesThrown();
        }
    }
}
