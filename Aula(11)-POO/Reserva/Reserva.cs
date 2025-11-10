using System;

namespace Reserva
{
    internal class Reserva
    {
        public int Id;
        public string Local;
        public Cliente Cliente;

        public Reserva(int id, string local)
        {
            Id = id;
            Local = local;
        }
    }
}