using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication21 {
    public partial class FormFinalJogo : Form {

        public enum Resultado { Vitoria, Derrota };

        private FormJogo parentForm;

        public FormFinalJogo(Resultado r, FormJogo fJogo) {
            InitializeComponent();

            parentForm = fJogo;

            // Tornar visível o label de derrota ou vitória
            if (r == Resultado.Vitoria)
                labelVitoria.Visible = true;
            else
                labelDerrota.Visible = true;

            // Obter o grau de dificuldade atual e selecionar o radioButton adequado
            switch (fJogo.Dificuldade) { 
                case (int) FormJogo.NivelDificuldade.Facil:
                    radioButtonFacil.Select();
                    break;
                case (int) FormJogo.NivelDificuldade.Intermedio:
                    radioButtonIntermedio.Select();
                    break;
                case (int) FormJogo.NivelDificuldade.Dificil:
                    radioButtonDificil.Select();
                    break;
            }
        }

        private void radioButtonFacil_CheckedChanged(object sender, EventArgs e) {
            parentForm.Dificuldade = (int) FormJogo.NivelDificuldade.Facil;
        }

        private void radioButtonIntermedio_CheckedChanged(object sender, EventArgs e) {
            parentForm.Dificuldade = (int)FormJogo.NivelDificuldade.Intermedio;
        }

        private void radioButtonDificil_CheckedChanged(object sender, EventArgs e) {
            parentForm.Dificuldade = (int)FormJogo.NivelDificuldade.Dificil;
        }

        private void buttonNovoJogo_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
