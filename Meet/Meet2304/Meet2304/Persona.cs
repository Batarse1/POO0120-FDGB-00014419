using System;

namespace Meet2304
{
    public class Persona
    {
        private String nombre, apellido;
        private int edad;

        public Persona(String nombre = "Sin nombre", String apellido = "Sin edad", int edad = 0)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"{nameof(nombre)}: {nombre}, {nameof(apellido)}: {apellido}, {nameof(edad)}: {edad}";
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public String saludar(String SaludoP)
        {
            return nombre + " " + SaludoP;
        }
    }
}