namespace _2_Collection_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Una lista de tipo Persona que se instancia a la Clase Persona.
            List<Persona> LPersona = new List<Persona>();
            //Es donde se podrá usar cada espacio de la lista como 1 persona.

            //En "LPersona", agregamos 5 personas con el método ".Add()".
            LPersona.Add(new Persona(1, "Brian", 3));
            LPersona.Add(new Persona(2, "Mariela", 1));
            LPersona.Add(new Persona(3, "Victor", 2));
            LPersona.Add(new Persona(4, "Jazmin", 5));
            LPersona.Add(new Persona(5, "Victor", 4));

            //Mostramos los datos:
            //Manual:

            
            //Automática con for:
            

            //Automática con for-each:
            foreach (Persona persona in LPersona)
            {
            }
        }
    }
}
