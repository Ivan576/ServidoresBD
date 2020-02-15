using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class clsModificar
    {
        int id;
        int isbn;
        String titulo;
        int numEdicion;
        int añoP;
        String autor;
        String paisP;
        String sinopsis;
        String carrera;
        String materia;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public String Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public int NumEdicion
        {
            get
            {
                return numEdicion;
            }
            set
            {
                numEdicion = value;
            }
        }

        public int AñoP
        {
            get
            {
                return añoP;
            }
            set
            {
                añoP = value;
            }
        }

        public String Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }


        public String PaisP
        {
            get
            {
                return paisP;
            }
            set
            {
                paisP = value;
            }
        }

        public String Sinopsis
        {
            get
            {
                return sinopsis;
            }
            set
            {
                sinopsis = value;
            }
        }

        public String Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public String Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }
    }
}
