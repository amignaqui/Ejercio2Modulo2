using System.Linq.Expressions;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };

            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola
            var lstNumeros = new List<int>() { 25, 10, 99, 105, 1, 84, 22 };
            var lstNumerosFiltrada = lstNumeros.Max(m => m);
            Console.WriteLine("Ejercicio1 - El número más grande de la lista es: " + lstNumerosFiltrada);

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            var lstNombresOrdenada = lstNombres.OrderBy(nombre => nombre).ToList();
            Console.WriteLine("\nEjercicio2 - Lista ordenada: ");
            lstNombresOrdenada.ForEach(nombre =>
            {
                Console.WriteLine(" - " + nombre);
            });

            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            var lstClientesFiltrada = lstClientes.Where(cliente => cliente.Vip == true).ToList();
            Console.WriteLine("\nEjercicio3 - Lista filtrada, clientes VIP: ");
            lstClientesFiltrada.ForEach(i =>
            {
                Console.WriteLine(" - " + i.CodCliente + " " + i.Nombre + " " + i.Apellido);
            });

            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            var lstClientesNew = lstClientes.Select(s => new { s.Nombre }).ToList();
            Console.WriteLine("\nEjercicio4 - Lista de nombres de clientes: ");
            lstClientesNew.ForEach(nombre =>
            {
                Console.WriteLine(" - " + nombre.Nombre);
            });

            #endregion

            #region Ejercicio5

            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"
            var lstClientesActualizada = lstClientes.Select(s => new
            {
                Apellido = s.Apellido.ToUpper(),
                Nombre = s.Nombre.ToUpper(),
                s.CodCliente,                
                Vip = (s.Vip ? "Premium" : "Normal"),
            }).ToList();
            Console.WriteLine("\nEjercicio5 - Lista de clientes actualizada: ");
            lstClientesActualizada.ForEach(i =>
            {
                Console.WriteLine(" - " + i);
            });

            #endregion
        }
    }
}