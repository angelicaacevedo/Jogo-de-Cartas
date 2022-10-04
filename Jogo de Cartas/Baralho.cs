using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Cartas
{

    //embaralhar as cartas
    //dar a mao para os player com 5 cartas sorteadas
    //ganha quem tiver na soma total das cartas maior pontuacao
    //desempate quem tiver uma carta As, Rei e Dama ganha
    internal class Baralho
    {
        public Collection<Carta> cartas = new Collection<Carta>();
        private static Random rng = new Random();
        public Collection<Carta> maoPlayer1 = new Collection<Carta>();
        public Collection<Carta> maoPlayer2 = new Collection<Carta>();

        public int vitorias = 0;
        public int empates = 0;
        public int derrotas = 0;

        public Baralho()
        {
            string[] numeros = new string[] {
                "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Rainha", "Rei", "As"
            };

            string[] naipes = new string[] { "ouro", "espadas", "copas", "paus" };

            int pontos = 2;

            foreach (string naipe in naipes)
            {
                foreach(string numero in numeros)
                {
                    Carta carta = new Carta();
                    carta.Valor = numero;
                    carta.Naipe = naipe;
                    carta.pontos = pontos;
                    cartas.Add(carta);
                    pontos++;
                }
                pontos = 2;
            }
        }

        public void embaralharCartas()
        {
            int tamanho = cartas.Count;

            while(tamanho > 1)
            {
                tamanho--;

                int k = rng.Next(tamanho + 1);
                Carta value = cartas[k];
                cartas[k] = cartas[tamanho];
                cartas[tamanho] = value;
            }
        }

        public void sortearCartas()
        {
            bool alternar = true;

            maoPlayer1.Clear();
            maoPlayer2.Clear();

           for(int i = 0; i < 10; i++)
            {
                Carta carta = cartas[i];

                if (alternar)
                {
                    maoPlayer1.Add(carta);
                }
                else
                {
                    maoPlayer2.Add(carta);
                }

                alternar = !alternar;
            }
        }
        public string organizarCartas(Collection<Carta> maoPlayer)
        {
            string cartas = "";

            for (int i = 0; i < maoPlayer.Count; i++)
            {
                if (i != 0)
                {
                    cartas = cartas + " | ";
                }

                cartas += maoPlayer[i].Valor.ToUpper() + " - " + maoPlayer[i].Naipe.ToUpper();
            }

            return cartas;
        }

        public int calcularPontos(Collection<Carta> maoPlayer)
        {
            int pontos = 0;

            for (int i = 0; i < maoPlayer.Count; i++)
            {
                pontos += maoPlayer[i].pontos;
            }

            return pontos;
        }

        public string comparar(int pontosPlayer1, int pontosPlayer2)
        {
            string resultado = "";

            if (pontosPlayer1 > pontosPlayer2)
            {
                resultado = "PARABENS VOCE VENCEU!!";
                vitorias += 1;
            }
            else if (pontosPlayer1 < pontosPlayer2)
            {
                resultado = "VOCE PERDEU!!";
                derrotas += 1;
            }
            else
            {
                resultado = "EMPATE!!";
                empates += 1;
            }

            return resultado;
        }
    }
}
