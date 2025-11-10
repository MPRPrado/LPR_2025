using System;

namespace Reserva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" =====> Welcome to the Reservation System! <===== ");
            Console.WriteLine("Please enter your name to continue:");
            string userName = Console.ReadLine();
            
            Cliente cliente = new Cliente(userName);
            
            Console.WriteLine("\nQuantas reservas deseja fazer?");
            int quantidade = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"\nDigite o nome do local para a reserva {i}:");
                string local = Console.ReadLine();
                
                Reserva reserva = new Reserva(i, local);
                cliente.AdicionarReserva(reserva);
            }
            
            Console.WriteLine($"\nReservas para {cliente.Nome}:");
            var reservas = cliente.ListarReservas();
            
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"ID: {reserva.Id} - {reserva.Local}");
            }
        }
    }
}