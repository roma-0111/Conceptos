namespace _2_Collection_Listas
{
    internal class Persona
    {
        //  Atributos
        private int num;
        private string nombre;
        private int edad;

        //  Constructores
        public Persona(int num, string nombre, int edad)
        {
            this.num = num;
            this.nombre = nombre;
            this.edad = edad;
        }
        // public Persona() { }

        //  Getter y Setter
        //num
        public int GetNum()
        {
            return num;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }

        //nombre
        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        //edad
        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Número: " + num);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }
}
