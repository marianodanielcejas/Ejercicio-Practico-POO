using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practico_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane avion = new Plane();
            truck camion = new truck();
            Car auto = new Car();
            MeansOfTransport[] medios = new MeansOfTransport[3];
            medios[0] = avion;
            medios[1] = camion;
            medios[2] = auto;

            for (int i = 0; i < 3; i = i + 1)
            {
                medios[i].Drive();
            }

        }
    }
    class MeansOfTransport
    {
        public void Tear()
        {
            Console.WriteLine("Método para arrancar el motor de MeansOfTransport");
        }
        public void Stop()
        {
            Console.WriteLine("Método para parar el motor");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Método para conducir rapidamente");
        }
    }
    class Plane: MeansOfTransport
    {
        public void SpeedBoost()
        {
            Console.WriteLine("Método para el aumento de velocidad");
        }
        public override void Drive()
        {
            Console.WriteLine("Método para conducir a una velocidad media");
        }
    }
    class Car: MeansOfTransport
    {
        public void CleanWindshiel()
        {
            Console.WriteLine("Método para limbiar parabrisas");
        }
        public override void Drive()
        {
            Console.WriteLine("Método para conducir a una velocidad baja");
        }
    }
    class truck: MeansOfTransport
    {
        public void HeavyLoad()
        {
            Console.WriteLine("Método para acceder a la carga pesada");
        }
    }
}
