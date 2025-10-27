using System;

namespace Herois
{
    internal class Heroi
    {
        public string Nome;
        public int Vida;
        public int Mana;
        public int Forca;
        public Arma? ArmaEquipada;

        public Heroi(string nome, int vida, int mana, int forca)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Forca = forca;
        }

        public int Atacar()
        {
            int dano = Forca;
            if (ArmaEquipada != null)
                dano += ArmaEquipada.Dano;
            return dano;
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }

    internal class Arma
    {
        public string Nome;
        public int Dano;
        public string Tipo;

        public Arma(string nome, int dano, string tipo)
        {
            Nome = nome;
            Dano = dano;
            Tipo = tipo;
        }

        public string UsarHabilidade()
        {
            return Nome + " causa " + Dano + " de dano!";
        }
    }

    internal class Inimigo
    {
        public string Nome;
        public int Vida;
        public int Ataque;
        public string Tipo;

        public Inimigo(string nome, int vida, int ataque, string tipo)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Tipo = tipo;
        }

        public int Atacar()
        {
            return Ataque;
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }
}