using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_Cartas
{
    public partial class Form1 : Form
    {
        Baralho baralho = new Baralho();

        public Form1()
        {
            InitializeComponent();
            limparComponentesVisuais();
        }
        private void embaralharCartas()
        {
            baralho.embaralharCartas();
        }

        private void sortearCartas()
        {
            baralho.sortearCartas();
        }

        private void preencherCartasPlayers()
        {
            labelCartasPlayer1.Text = baralho.organizarCartas(baralho.maoPlayer1);
            labelCartasPlayer2.Text = baralho.organizarCartas(baralho.maoPlayer2);
        }

        private void calcularPontosDasCartas()
        {
            int resultadoPlayer1 = baralho.calcularPontos(baralho.maoPlayer1);
            int resultadoPlayer2 = baralho.calcularPontos(baralho.maoPlayer2);

            labelTotalDePontosPlayer1.Text = resultadoPlayer1.ToString();
            labelTotalDePontosPlayer2.Text = resultadoPlayer2.ToString();
            labelResultado.Text = baralho.comparar(resultadoPlayer1, resultadoPlayer2);

            labelQuantidadeDeVitorias.Text = baralho.vitorias.ToString();
            labelQuantidadeDeEmpates.Text = baralho.empates.ToString();
            labelQuantidadeDeDerrotas.Text = baralho.derrotas.ToString();
        }

        private void limparComponentesVisuais()
        {
            labelCartasPlayer1.Text = "Suas cartas";
            labelCartasPlayer2.Text = "Cartas do CPU";
            labelTotalDePontosPlayer1.Text = "0";
            labelTotalDePontosPlayer2.Text = "0";
            labelResultado.Text = "";
            labelQuantidadeDeVitorias.Text = "0";
            labelQuantidadeDeEmpates.Text = "0";
            labelQuantidadeDeDerrotas.Text = "0";
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            limparComponentesVisuais();
            embaralharCartas();
            sortearCartas();
            preencherCartasPlayers();
            calcularPontosDasCartas();
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            limparComponentesVisuais();
            baralho.vitorias = 0;
            baralho.empates = 0;
            baralho.derrotas = 0;
        }
    }
}
