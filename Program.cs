using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ejerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora unaCalculadora = new Calculadora(3,5);

            unaCalculadora.valorX = 6;
            unaCalculadora.valorY = 3;

            //Console.WriteLine(unaCalculadora.dividir());
            Console.WriteLine(unaCalculadora.factorial());
            
        }
       

    }
    class Calculadora
    {
        public  Calculadora(int pX, int pY)
        {
            x = pX;
            y = pY;
            //?
        }
        private int x;
        private int y;
        public int sumar()
        {            
            
            return valorX + valorY;
        }
        public int restar()
        {

            return valorX - valorY;
        }
        public int multiplicar()
        {

            return valorX * valorY;
        }

        // #1Funcion: Divide...
        public double dividir()
        {
            if (valorY == 0) valorY=1;
                
            return valorX / valorY;
        }

        private int factoriali(int x)
        {

            if (x == 0) return 1;
            else

                return x * factoriali(x - 1);
        }
        public int factorial()
        {

            return factoriali(x);
        }

        private int potenciai(int x, int y)
        {
            if (y == 0) return 1;
            else

                return x * potenciai(x, y - 1);
        }

        public int potencia()
        {

            return potenciai(x,y);
        }
        public int valorX
        {

            get
            {
                return x;

            }

            set
            {
                x = value;
            }
        }


        public int valorY
        {

            get
            {
                return y;

            }

            set
            {
                y = value;
            }
        }
    
    }

    

    
}
