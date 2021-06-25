using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosPOO
{
    class PruebaCoche
    {
        public void probar()
        {
            List<Coche> coches = new List<Coche>();

            CargarCoches(coches);
            MostrarCoches(coches);

            coches[1].color = "Verde";
            coches[3].color = "Azul";

            MostrarCoches(coches);



        }
        void CargarCoches(List<Coche> coches)
        {
            string salir = "n";
            int contador = 0;
            Console.WriteLine("desae cargar algún coche(s/n");
            salir = Console.ReadLine();

            while (salir.ToLower() != "s")
            {
                contador++;
                Console.WriteLine("desea cargar mas coches(s/n");
                salir = Console.ReadLine();
                Coche miCoche = new Coche("LMN12" + contador);
                Console.WriteLine("Ingrese el color:");
                miCoche.color = Console.ReadLine();
                Console.WriteLine("Ingrese la marca:");
                miCoche.marca = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo:");
                miCoche.modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de puertas:");
                miCoche.puertas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese los CV:");
                miCoche.caballos = Convert.ToInt32(Console.ReadLine());
                coches.Add(miCoche);

            }
        }
        void MostrarCoches(List<Coche> coches)
        {
            foreach (Coche unCoche in coches)
            {
                Console.WriteLine(unCoche.caballos);
                Console.WriteLine(unCoche.color);
                Console.WriteLine(unCoche.marca);
                Console.WriteLine(unCoche.matricula);
                Console.WriteLine(unCoche.modelo);
                Console.WriteLine(unCoche.puertas);
            }
        }

    }

    class Coche
    {
        public Coche(string pMatricula)
        {
            matricula = pMatricula;
        }

        int lasPuertas;
        public string color { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int caballos { get; set; }
        public int puertas
        {

            get
            {
                if (lasPuertas > 5)
                    return 4;
                else return lasPuertas;
            }


            set
            {
                lasPuertas = value;

            }
        }
        public string matricula { get; set; }

        public int test()
        {
            return puertas * 2;
        }
    }
}
