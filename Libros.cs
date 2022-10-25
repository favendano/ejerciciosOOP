using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosPOO
{
    //Queremos mantener una colección de los libros que hemos ido leyendo,
    //poniéndoles una calificación según nos haya gustado más o menos al leerlo.
    //Para ello, crear la clase Libro, cuyos atributos son el título, el autor, el número de páginas
    //y la calificación que le damos entre 0 y 10.  
    //Crear los métodos típicos para poder modificar y obtener los atributos
    //si tienen sentido. Posteriormente,
    //crear una clase ConjuntoLibros, que almacena un conjunto de libros
    //(con un array de un tamaño fijo).  
    //Se pueden añadir libros que no existan(siempre que haya espacio),
    //eliminar libros por título o autor, mostrar por pantalla los libros con la mayor y
    //menor calificación dada y, por último, mostrar un contenido de todo el conjunto.
    //Crear una clase PruebaLibros, que realice varias pruebas con las clases creadas.
    //En concreto, pruebe a: crear dos libros, añadirlos al conjunto,
    //eliminarlos por los dos criterios hasta que el conjunto esté vacío,
    //volver a añadir un libro y mostrar el contenido final.
    class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int numeroPaginas { get; set; }
        private int vCalificacion;
        public int calificacion
        {
            get
            {
                return vCalificacion;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    vCalificacion = value;
                else vCalificacion = 0;
            }
        }

    }
    class ConjuntoLibros
    {
        protected Libro[] listaLibros = new Libro[5];
        public int AgregaLibro(Libro unLibro)
        {
            int i = 0;
            int nuevo = 0;
            while (nuevo == 0 && i < 5)
            {
                if (listaLibros[i] == null && nuevo == 0)
                {
                    listaLibros[i] = unLibro;
                    nuevo = 1;
                }
                i++;

            }
            if (nuevo == 0)
                return 0;
            else return 1;

        }
        public int BorraLibro(Libro unLibro)
        {
            int borrado = 0;
            for (int i = 0; i < 5; i++)
            {
                if (listaLibros[i] != null)
                {
                    if (listaLibros[i].titulo == unLibro.titulo)
                    {
                        listaLibros[i] = null;
                        borrado = 1;
                    }
                }


            }
            return borrado;

        }
        public void MostrarLibros()
        {
            foreach (Libro l in listaLibros)
            {
                if (l != null)
                {
                    Console.WriteLine(l.autor);
                    Console.WriteLine(l.titulo);
                    Console.WriteLine(l.numeroPaginas);
                    Console.WriteLine(l.calificacion);
                }
            }
        }
    }
}
