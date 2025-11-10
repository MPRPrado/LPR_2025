using System;
using System.Collections.Generic;
using System.Linq;

namespace Reserva
{
    internal class Cliente
    {
        public string Nome;
        public List<Reserva> Reservas;

        public Cliente(string nome)
        {
            Nome = nome;
            Reservas = new List<Reserva>();
        }

        public void AdicionarReserva(Reserva reserva)
        {
            Reservas.Add(reserva);
            reserva.Cliente = this;
        }

        public List<Reserva> ListarReservas()
        {
            return Reservas;
        }
    }
}