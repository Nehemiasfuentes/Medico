using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicos
{
    class Medico
    {

        private string nombre;
        private string apellido;
        private string especialidad;
        private int telefono;
        private string direccionClinica;

        public void setnombre(string Nombre)
        {
            nombre = Nombre;
        }

        public string getnombre()
        {
            return nombre;
        }

        public void setapellido(string Apellido)
        {
            apellido = Apellido;
        }

        public string getapellido()
        {
            return apellido;
        }

        public void setespecialidad(string Especialidad)
        {
            especialidad = Especialidad;
        }

        public string getespecialidad()
        {
            return especialidad;
        }

        public void settelefono(int Telefono)
        {
            telefono = Telefono;
        }

        public int gettelefono()
        {
            return telefono;
        }

        public void setdireccion(string DireccionClinica)
        {
            direccionClinica = DireccionClinica;
        }

        public string getdireccion()
        {
            return direccionClinica;
        }
    }
}
