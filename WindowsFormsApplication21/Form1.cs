using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication21 {
    public partial class FormJogo : Form {

        // tipos de dados
        public enum NivelDificuldade { Facil = 1, Intermedio = 2, Dificil = 3 };

        // ---------------  Campos e Propriedades ---------------  
        
        // O valor a adivinhar
        private int valorAlvo = 0;

        // A tentativa do utilizador
        private int valorDado = 0;

        // O número da tentativa atual
        private int tentativa = 0;

        // Grau de dificuldade
        private int limiteTentativas;
        private int limiteInferior;
        private int limiteSuperior;
        private int dificuldade;

        public int Dificuldade {
            get {
                return dificuldade;
            }

            set {
                if (value <= 1) {
                    dificuldade = 1;
                    limiteTentativas = 5;
                    limiteInferior = 0;
                    limiteSuperior = 10;
                }
                else if (value == 2) {
                    dificuldade = 2;
                    limiteTentativas = 10;
                    limiteInferior = 10;
                    limiteSuperior = 100;
                }
                else if (value >= 3) {
                    dificuldade = 3;
                    limiteTentativas = 15;
                    limiteInferior = 100;
                    limiteSuperior = 1000;
                }
            }
        }

        // ---------------  Membros ---------------  
        
        public FormJogo() {
            InitializeComponent();
        }

        /* Gerar e devolver um valor aleatório em função do grau de dificuldade estabelecido */        
        private int GenerateValue() {
            Random r = new Random();
            return r.Next(limiteInferior, limiteSuperior + 1);
        }

        /// <summary>
        /// Reinicia o jogo no grau de dificuldade atual.
        /// </summary>
        private void ResetGame() {
            // Reinicializar contador de tentativas
            tentativa = 0;

            // Reinicializar elementos gráficos
            trackBar.Minimum = limiteInferior;
            trackBar.Maximum = limiteSuperior;
            trackBar.Value = limiteInferior;
            textBox.Text = limiteInferior.ToString();
            labelMin.Text = limiteInferior.ToString();
            labelMax.Text = limiteSuperior.ToString();
            labelMaior.Visible = false;
            labelMenor.Visible = false;

            // Gerar novo valor alvo
            valorAlvo = GenerateValue();

            // Reinicializar a label do número de tentativas
            labelTentativa.Text = "Tentativa " + tentativa + "/" + limiteTentativas + ":";

            // Selecionar o texto da textBox para estar pronta para nova introdução
            textBox.SelectAll();
        }

        /* Uma tentativa do utilizador */
        private void buttonAdivinhar_Click(object sender, EventArgs e) {
            // Ler o valor da trackbar
            valorDado = trackBar.Value;

            // Incrementar o contador de tentativas e atualizar no ecrã
            tentativa++;
            labelTentativa.Text = "Tentativa " + tentativa + "/" + limiteTentativas + ":"; 

            // Hipotese 1: o jogador acerta no valor alvo
            if(valorDado == valorAlvo)
            {
                // Abrir o form de final do jogo
                FormFinalJogo f = new FormFinalJogo(FormFinalJogo.Resultado.Vitoria, this);
                DialogResult r = f.ShowDialog();

                // Conforme a resposta do utilizador, reiniciar o jogo ou sair
                ResetGame();
                if (r == DialogResult.Cancel)
                    this.Close();
            }
            // Hipotese 2: o jogador não acerta no valor alvo
            else
            {
                // Conforme o valor é maior ou menor, tornar visível a mensagem adequada
                if (valorAlvo < valorDado) {
                    labelMenor.Visible = true;
                    labelMaior.Visible = false;
                }
                else {
                    labelMaior.Visible = true;
                    labelMenor.Visible = false;
                }

                // Selecionar o texto da textBox para estar pronta para nova introdução
                textBox.SelectAll();

                // Se o número de tentativas está esgotado
                if (tentativa == limiteTentativas)
                {
                    // Abrir o form de final do jogo
                    FormFinalJogo f = new FormFinalJogo(FormFinalJogo.Resultado.Derrota, this);
                    DialogResult r = f.ShowDialog();
                    
                    // Conforme a resposta do utilizador, reiniciar o jogo ou sair
                    ResetGame();
                    if (r == DialogResult.Cancel)
                        this.Close();
                }
            }
        }

        /* Alterar o valor da trackBar em conformidade*/
        private void textBox_TextChanged(object sender, EventArgs e) {
            int val = 0;
            
            try {
                val = int.Parse(textBox.Text);
            }
            catch (Exception ex) {
                trackBar.Value = limiteInferior;
                textBox.Text = limiteInferior.ToString();
                textBox.SelectAll();
                buttonAdivinhar.Enabled = true;
                return;
            }

            if (val < limiteInferior) {
                trackBar.Value = limiteInferior;
                buttonAdivinhar.Enabled = false;
                return;
            }

            if (val > limiteSuperior) {
                trackBar.Value = limiteSuperior;
                buttonAdivinhar.Enabled = false;
                return;
            }

            trackBar.Value = val;
            buttonAdivinhar.Enabled = true;

        }

        /* Alterar o valor da textBox em conformidade*/
        private void trackBar_Scroll(object sender, EventArgs e) {
            textBox.Text = trackBar.Value.ToString();
            buttonAdivinhar.Enabled = true;
        }

        /* Novo jogo */
        private void novoToolStripMenuItem_Click(object sender, EventArgs e) {
            ResetGame();
        }

        /* Terminar a aplicação */
        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        /* Alterar o grau de dificuldade para "Fácil" */
        private void fácilToolStripMenuItem_Click(object sender, EventArgs e) {
            // Estabelecer o novo grau de dificuldade
            Dificuldade = 1;

            // Manter o estado do menu consistente com o grau de dificuldade escolhido
            intermédioToolStripMenuItem.Checked = false;
            difícilToolStripMenuItem.Checked = false;

            // Reiniciar o jogo
            ResetGame();
        }

        /* Alterar o grau de dificuldade para "Intermédio" */
        private void intermédioToolStripMenuItem_Click(object sender, EventArgs e) {
            // Estabelecer o novo grau de dificuldade
            Dificuldade = 2;

            // Manter o estado do menu consistente com o grau de dificuldade escolhido
            fácilToolStripMenuItem.Checked = false;
            difícilToolStripMenuItem.Checked = false;

            // Reiniciar o jogo
            ResetGame();
        }

        /* Alterar o grau de dificuldade para "Difícil" */
        private void difícilToolStripMenuItem_Click(object sender, EventArgs e) {
            // Estabelecer o novo grau de dificuldade
            Dificuldade = 3;

            // Manter o estado do menu consistente com o grau de dificuldade escolhido
            fácilToolStripMenuItem.Checked = false;
            intermédioToolStripMenuItem.Checked = false;

            // Reiniciar o jogo
            ResetGame();
        }

        /* Configuração inicial do Jogo */
        private void FormJogo_Load(object sender, EventArgs e) {
            // Grau de dificuldade no arranque da aplicação
            Dificuldade = 1;

            // Configurar a trackBar e a textBox
            trackBar.Minimum = limiteInferior;
            trackBar.Maximum = limiteSuperior;
            trackBar.Value = limiteInferior;
            textBox.Text = limiteInferior.ToString();
            labelMin.Text = limiteInferior.ToString();
            labelMax.Text = limiteSuperior.ToString();

            // Gerar novo valor alvo
            valorAlvo = GenerateValue();

            // Inicializar a label do número de tentativas
            labelTentativa.Text = "Tentativa " + tentativa + "/" + limiteTentativas + ":";

            // Selecionar o texto da textBox para estar pronta para nova introdução
            textBox.SelectAll();

        }

        private void FormJogo_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult dr;

            dr = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No)
                e.Cancel = true;
        }
    }
}
