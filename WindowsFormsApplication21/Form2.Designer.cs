namespace WindowsFormsApplication21 {
    partial class FormFinalJogo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelVitoria = new System.Windows.Forms.Label();
            this.labelDerrota = new System.Windows.Forms.Label();
            this.radioButtonFacil = new System.Windows.Forms.RadioButton();
            this.radioButtonIntermedio = new System.Windows.Forms.RadioButton();
            this.radioButtonDificil = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNovoJogo = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVitoria
            // 
            this.labelVitoria.AutoSize = true;
            this.labelVitoria.Location = new System.Drawing.Point(29, 20);
            this.labelVitoria.Name = "labelVitoria";
            this.labelVitoria.Size = new System.Drawing.Size(177, 13);
            this.labelVitoria.TabIndex = 0;
            this.labelVitoria.Text = "Parabéns. Acertou no valor secreto.";
            this.labelVitoria.Visible = false;
            // 
            // labelDerrota
            // 
            this.labelDerrota.AutoSize = true;
            this.labelDerrota.Location = new System.Drawing.Point(29, 20);
            this.labelDerrota.Name = "labelDerrota";
            this.labelDerrota.Size = new System.Drawing.Size(182, 13);
            this.labelDerrota.TabIndex = 0;
            this.labelDerrota.Text = "Fail. Esgotou o número de tentativas.";
            this.labelDerrota.Visible = false;
            // 
            // radioButtonFacil
            // 
            this.radioButtonFacil.AutoSize = true;
            this.radioButtonFacil.Location = new System.Drawing.Point(32, 36);
            this.radioButtonFacil.Name = "radioButtonFacil";
            this.radioButtonFacil.Size = new System.Drawing.Size(47, 17);
            this.radioButtonFacil.TabIndex = 1;
            this.radioButtonFacil.TabStop = true;
            this.radioButtonFacil.Text = "Fácil";
            this.radioButtonFacil.UseVisualStyleBackColor = true;
            this.radioButtonFacil.CheckedChanged += new System.EventHandler(this.radioButtonFacil_CheckedChanged);
            // 
            // radioButtonIntermedio
            // 
            this.radioButtonIntermedio.AutoSize = true;
            this.radioButtonIntermedio.Location = new System.Drawing.Point(32, 59);
            this.radioButtonIntermedio.Name = "radioButtonIntermedio";
            this.radioButtonIntermedio.Size = new System.Drawing.Size(74, 17);
            this.radioButtonIntermedio.TabIndex = 1;
            this.radioButtonIntermedio.TabStop = true;
            this.radioButtonIntermedio.Text = "Intermédio";
            this.radioButtonIntermedio.UseVisualStyleBackColor = true;
            this.radioButtonIntermedio.CheckedChanged += new System.EventHandler(this.radioButtonIntermedio_CheckedChanged);
            // 
            // radioButtonDificil
            // 
            this.radioButtonDificil.AutoSize = true;
            this.radioButtonDificil.Location = new System.Drawing.Point(32, 82);
            this.radioButtonDificil.Name = "radioButtonDificil";
            this.radioButtonDificil.Size = new System.Drawing.Size(52, 17);
            this.radioButtonDificil.TabIndex = 1;
            this.radioButtonDificil.TabStop = true;
            this.radioButtonDificil.Text = "Difícil";
            this.radioButtonDificil.UseVisualStyleBackColor = true;
            this.radioButtonDificil.CheckedChanged += new System.EventHandler(this.radioButtonDificil_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha o grau de dificuldade para o próximo jogo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonDificil);
            this.panel1.Controls.Add(this.radioButtonIntermedio);
            this.panel1.Controls.Add(this.radioButtonFacil);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 111);
            this.panel1.TabIndex = 3;
            // 
            // buttonNovoJogo
            // 
            this.buttonNovoJogo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNovoJogo.Location = new System.Drawing.Point(76, 164);
            this.buttonNovoJogo.Name = "buttonNovoJogo";
            this.buttonNovoJogo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoJogo.TabIndex = 4;
            this.buttonNovoJogo.Text = "Novo jogo";
            this.buttonNovoJogo.UseVisualStyleBackColor = true;
            this.buttonNovoJogo.Click += new System.EventHandler(this.buttonNovoJogo_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSair.Location = new System.Drawing.Point(157, 164);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormFinalJogo
            // 
            this.AcceptButton = this.buttonNovoJogo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(305, 202);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonNovoJogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDerrota);
            this.Controls.Add(this.labelVitoria);
            this.Name = "FormFinalJogo";
            this.Text = "Final do Jogo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVitoria;
        private System.Windows.Forms.Label labelDerrota;
        private System.Windows.Forms.RadioButton radioButtonFacil;
        private System.Windows.Forms.RadioButton radioButtonIntermedio;
        private System.Windows.Forms.RadioButton radioButtonDificil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNovoJogo;
        private System.Windows.Forms.Button buttonSair;
    }
}