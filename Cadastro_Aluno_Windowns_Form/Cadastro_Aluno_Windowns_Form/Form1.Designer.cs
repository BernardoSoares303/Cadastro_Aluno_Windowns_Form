namespace Cadastro_Aluno_Windowns_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            TextNome = new TextBox();
            TextCpf = new TextBox();
            Genero_Masculino = new RadioButton();
            Genero_feminino = new RadioButton();
            Genero_NaoBinare = new RadioButton();
            TextRg = new TextBox();
            textResponzável = new TextBox();
            textTelefone = new TextBox();
            textEmail = new TextBox();
            textEndereco = new TextBox();
            textMatricula = new TextBox();
            textSerieTurma = new TextBox();
            textStatus = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(394, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 433);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TextNome
            // 
            TextNome.BackColor = Color.YellowGreen;
            TextNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextNome.Location = new Point(1, 25);
            TextNome.Name = "TextNome";
            TextNome.Size = new Size(508, 31);
            TextNome.TabIndex = 1;
            TextNome.Text = "Nome Completo: ";
            // 
            // TextCpf
            // 
            TextCpf.BackColor = Color.YellowGreen;
            TextCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextCpf.Location = new Point(1, 74);
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(508, 31);
            TextCpf.TabIndex = 2;
            TextCpf.Text = "Cpf: ";
            // 
            // Genero_Masculino
            // 
            Genero_Masculino.AutoSize = true;
            Genero_Masculino.Location = new Point(12, 568);
            Genero_Masculino.Name = "Genero_Masculino";
            Genero_Masculino.Size = new Size(117, 29);
            Genero_Masculino.TabIndex = 3;
            Genero_Masculino.TabStop = true;
            Genero_Masculino.Text = "Masculino";
            Genero_Masculino.UseVisualStyleBackColor = true;
            // 
            // Genero_feminino
            // 
            Genero_feminino.AutoSize = true;
            Genero_feminino.Location = new Point(163, 568);
            Genero_feminino.Name = "Genero_feminino";
            Genero_feminino.Size = new Size(115, 29);
            Genero_feminino.TabIndex = 4;
            Genero_feminino.TabStop = true;
            Genero_feminino.Text = "Femenino";
            Genero_feminino.UseVisualStyleBackColor = true;
            // 
            // Genero_NaoBinare
            // 
            Genero_NaoBinare.AutoSize = true;
            Genero_NaoBinare.Location = new Point(310, 568);
            Genero_NaoBinare.Name = "Genero_NaoBinare";
            Genero_NaoBinare.Size = new Size(123, 29);
            Genero_NaoBinare.TabIndex = 5;
            Genero_NaoBinare.TabStop = true;
            Genero_NaoBinare.Text = "Não Binare";
            Genero_NaoBinare.UseVisualStyleBackColor = true;
            // 
            // TextRg
            // 
            TextRg.BackColor = Color.YellowGreen;
            TextRg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextRg.Location = new Point(1, 127);
            TextRg.Name = "TextRg";
            TextRg.Size = new Size(508, 31);
            TextRg.TabIndex = 6;
            TextRg.Text = "RG: ";
            // 
            // textResponzável
            // 
            textResponzável.BackColor = Color.YellowGreen;
            textResponzável.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textResponzável.Location = new Point(1, 177);
            textResponzável.Name = "textResponzável";
            textResponzável.Size = new Size(508, 31);
            textResponzável.TabIndex = 7;
            textResponzável.Text = "Nome do Responsável: ";
            // 
            // textTelefone
            // 
            textTelefone.BackColor = Color.YellowGreen;
            textTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textTelefone.Location = new Point(1, 232);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(508, 31);
            textTelefone.TabIndex = 8;
            textTelefone.Text = "Telefone: ";
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.YellowGreen;
            textEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textEmail.Location = new Point(1, 282);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(508, 31);
            textEmail.TabIndex = 9;
            textEmail.Text = "E-mail: ";
            // 
            // textEndereco
            // 
            textEndereco.BackColor = Color.YellowGreen;
            textEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textEndereco.Location = new Point(1, 333);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(508, 31);
            textEndereco.TabIndex = 10;
            textEndereco.Text = "Endereço: ";
            // 
            // textMatricula
            // 
            textMatricula.BackColor = Color.YellowGreen;
            textMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textMatricula.Location = new Point(1, 383);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(508, 31);
            textMatricula.TabIndex = 11;
            textMatricula.Text = "Matricula: ";
            // 
            // textSerieTurma
            // 
            textSerieTurma.BackColor = Color.YellowGreen;
            textSerieTurma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textSerieTurma.Location = new Point(1, 431);
            textSerieTurma.Name = "textSerieTurma";
            textSerieTurma.Size = new Size(508, 31);
            textSerieTurma.TabIndex = 12;
            textSerieTurma.Text = "Serie/Turma: ";
            // 
            // textStatus
            // 
            textStatus.BackColor = Color.YellowGreen;
            textStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textStatus.Location = new Point(1, 531);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(508, 31);
            textStatus.TabIndex = 14;
            textStatus.Text = "Status (ativo, trancado, evadido, concluído): ";
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(548, 544);
            button1.Name = "button1";
            button1.Size = new Size(271, 68);
            button1.TabIndex = 15;
            button1.Text = "Concluir Cadastro!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.YellowGreen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite" });
            comboBox1.Location = new Point(1, 478);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(508, 33);
            comboBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1287, 624);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textStatus);
            Controls.Add(textSerieTurma);
            Controls.Add(textMatricula);
            Controls.Add(textEndereco);
            Controls.Add(textEmail);
            Controls.Add(textTelefone);
            Controls.Add(textResponzável);
            Controls.Add(TextRg);
            Controls.Add(Genero_NaoBinare);
            Controls.Add(Genero_feminino);
            Controls.Add(Genero_Masculino);
            Controls.Add(TextCpf);
            Controls.Add(TextNome);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Colegio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TextNome;
        private TextBox TextCpf;
        private RadioButton Genero_Masculino;
        private RadioButton Genero_feminino;
        private RadioButton Genero_NaoBinare;
        private TextBox TextRg;
        private TextBox textResponzável;
        private TextBox textTelefone;
        private TextBox textEmail;
        private TextBox textEndereco;
        private TextBox textMatricula;
        private TextBox textSerieTurma;
        private TextBox textStatus;
        private Button button1;
        private ComboBox comboBox1;
    }
}
