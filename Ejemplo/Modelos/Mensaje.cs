namespace Ejemplo.Modelos
{
    public class Mensaje
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Mensaje(string NombreIn, int EdadIn)
        {
            Nombre = NombreIn;
            Edad = EdadIn;

        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public int GetEdadMeses()
        {
            return Edad * 12;
        }
    }
    public class PersonaPuesto : Persona
    {
        public double Sueldo { get; set; }
        public int PersonaId { get; set; }

    }

    public class Animal
    {
        public string Especie { get; set; }
        public string Habitat { get; set; }
    }

    public class Perro : Animal
    {
        public string Raza { get; set; }
    }
}
