namespace Cadastro_Aluno_Windowns_Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.MintCream;
            labelNome.Location = new Point(11, 9);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(38, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "nome";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(581, 323);
            Controls.Add(labelNome);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Notas/Frequencia";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
    }
}