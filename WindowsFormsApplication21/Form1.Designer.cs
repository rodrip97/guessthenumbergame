namespace WindowsFormsApplication21 {
    partial class FormJogo {
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
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelMaior = new System.Windows.Forms.Label();
            this.buttonAdivinhar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fácilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermédioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMenor = new System.Windows.Forms.Label();
            this.labelTentativa = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(0, 30);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(494, 45);
            this.trackBar.TabIndex = 0;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(240, 81);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelMaior
            // 
            this.labelMaior.AutoSize = true;
            this.labelMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaior.Location = new System.Drawing.Point(153, 125);
            this.labelMaior.Name = "labelMaior";
            this.labelMaior.Size = new System.Drawing.Size(193, 13);
            this.labelMaior.TabIndex = 2;
            this.labelMaior.Text = "O valor secreto é maior que a tentativa.";
            this.labelMaior.Visible = false;
            // 
            // buttonAdivinhar
            // 
            this.buttonAdivinhar.Location = new System.Drawing.Point(199, 170);
            this.buttonAdivinhar.Name = "buttonAdivinhar";
            this.buttonAdivinhar.Size = new System.Drawing.Size(100, 39);
            this.buttonAdivinhar.TabIndex = 3;
            this.buttonAdivinhar.Text = "Adivinhar";
            this.buttonAdivinhar.UseVisualStyleBackColor = true;
            this.buttonAdivinhar.Click += new System.EventHandler(this.buttonAdivinhar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.dificuldadeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dificuldadeToolStripMenuItem
            // 
            this.dificuldadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fácilToolStripMenuItem,
            this.intermédioToolStripMenuItem,
            this.difícilToolStripMenuItem});
            this.dificuldadeToolStripMenuItem.Name = "dificuldadeToolStripMenuItem";
            this.dificuldadeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.dificuldadeToolStripMenuItem.Text = "Dificuldade";
            // 
            // fácilToolStripMenuItem
            // 
            this.fácilToolStripMenuItem.Checked = true;
            this.fácilToolStripMenuItem.CheckOnClick = true;
            this.fácilToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fácilToolStripMenuItem.Name = "fácilToolStripMenuItem";
            this.fácilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fácilToolStripMenuItem.Text = "Fácil";
            this.fácilToolStripMenuItem.Click += new System.EventHandler(this.fácilToolStripMenuItem_Click);
            // 
            // intermédioToolStripMenuItem
            // 
            this.intermédioToolStripMenuItem.CheckOnClick = true;
            this.intermédioToolStripMenuItem.Name = "intermédioToolStripMenuItem";
            this.intermédioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.intermédioToolStripMenuItem.Text = "Intermédio";
            this.intermédioToolStripMenuItem.Click += new System.EventHandler(this.intermédioToolStripMenuItem_Click);
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.CheckOnClick = true;
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.difícilToolStripMenuItem.Text = "Difícil";
            this.difícilToolStripMenuItem.Click += new System.EventHandler(this.difícilToolStripMenuItem_Click);
            // 
            // labelMenor
            // 
            this.labelMenor.AutoSize = true;
            this.labelMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenor.Location = new System.Drawing.Point(153, 125);
            this.labelMenor.Name = "labelMenor";
            this.labelMenor.Size = new System.Drawing.Size(197, 13);
            this.labelMenor.TabIndex = 2;
            this.labelMenor.Text = "O valor secreto é menor que a tentativa.";
            this.labelMenor.Visible = false;
            // 
            // labelTentativa
            // 
            this.labelTentativa.AutoSize = true;
            this.labelTentativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTentativa.Location = new System.Drawing.Point(161, 84);
            this.labelTentativa.Name = "labelTentativa";
            this.labelTentativa.Size = new System.Drawing.Size(73, 13);
            this.labelTentativa.TabIndex = 5;
            this.labelTentativa.Text = "Tentativa x/y:";
            this.labelTentativa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMin
            // 
            this.labelMin.Location = new System.Drawing.Point(7, 62);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(54, 13);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "0";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMax
            // 
            this.labelMax.Location = new System.Drawing.Point(428, 62);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(63, 13);
            this.labelMax.TabIndex = 6;
            this.labelMax.Text = "10";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormJogo
            // 
            this.AcceptButton = this.buttonAdivinhar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 241);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelTentativa);
            this.Controls.Add(this.buttonAdivinhar);
            this.Controls.Add(this.labelMenor);
            this.Controls.Add(this.labelMaior);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormJogo";
            this.Text = "Jogo do adivinho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJogo_FormClosing);
            this.Load += new System.EventHandler(this.FormJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelMaior;
        private System.Windows.Forms.Button buttonAdivinhar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificuldadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fácilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermédioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
        private System.Windows.Forms.Label labelMenor;
        private System.Windows.Forms.Label labelTentativa;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
    }
}

