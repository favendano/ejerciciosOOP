using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ejerciciosPOO
{
    class Rectangulo
    {
        public Rectangulo(int unaBase, int unaAltura)
        {
            laBase = unaBase;
            laAltura = unaAltura;
            
        }
        private int laBase;
        private int laAltura;
     
        public double calcularArea()
        {

            return laBase * laAltura;
        }
        public double calcularPerimetro()
        {
            return laBase * 2 + laAltura * 2;
        }

   
        public int miBase
        {

            get
            {
                return laBase;
            }

            private set
            {

            }
        }
        public int miAltura
        {

            get
            {
                return laAltura;
            }

            private set
            {

            }
        }

    }
}
