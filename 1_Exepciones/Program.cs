namespace _1_Exepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaramos a las variables.
            int zero = 0, uno = 1;

            //Creamos una exepción dentro del try a propósito.
            try
            {
                //En el try es siempre que donde tiene que ir la posible exepción.
                int num1 = uno / zero;
            }
            //En caso de haber una excepción se ejecuta el catch
            catch (Exception e) //Exception: Al no saber cuál exepción es, se utiliza "Exception" para ser general.
            {
                //Mostramos un mensaje que no se hizo la operación y mostramos la exepción que ocurre.
                Console.WriteLine("No se puede realizar esa operación !!!");
                Console.WriteLine($"El error es: {e}");
            }
            finally
            {
                //Para esperar y salir
                Console.WriteLine("Presione cualquier tecla para salir.");
                Console.ReadKey(true);
            }
        }
    }
}
