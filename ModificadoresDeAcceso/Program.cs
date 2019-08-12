using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
                = new Cliente();

            cliente.Nombre = "Rubius";
            cliente.Telefono = "1313 6969";


            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("telefono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "12456789123456789";
                Console.WriteLine("Curp:" + cliente.Curp);


            }
            catch(Exception e)
            {
                Console.WriteLine("la curp debe ser de 18 caracteres");
            }

            Console.Read();

        }
    }
}
