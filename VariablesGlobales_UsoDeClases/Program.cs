//Se usa la clase Variables que se puede ver en el "Explorador de soluciones".
using Variables; 

namespace VariablesGlobales_UsoDeClases
{
    internal class Program
    {
        //Algo que sea "public" quiere decir que se puede usar desde donde sea, no tiene restricción, en cambio algo "private" solo se puede usar en el documento mismo.
        //Una "static class" es aquella Clase que se usa sin necesidad de realizar una instancia.
        /*private static class Global
        {
            public static string nombre;
        }*/

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("¡Hola mundo!");
                //Pedimos que ingrese un dato
                Console.Write("Hola, por favor ingrese su nombre por favor: ");
                //Lo guardamos en el Atributo de la Clase Global
                Global.nombre = Console.ReadLine(); //Ahora se usa la Clase Global, en el documento llamado "Variables"
                //Luego lo usamos.
                Console.WriteLine($"\nComo está {Global.nombre}?");
            }
            catch (Exception e)
            {
                Console.WriteLine("Lamentablemente, ha ocurrido un problema, adios.");
                Console.WriteLine($"Error presentado: {e}");
            }
            finally
            {
                //Para esperar y salir
                Console.WriteLine("Presione cualquier tecla para salir.");
                Console.ReadKey();
            }
        }
    }
}
