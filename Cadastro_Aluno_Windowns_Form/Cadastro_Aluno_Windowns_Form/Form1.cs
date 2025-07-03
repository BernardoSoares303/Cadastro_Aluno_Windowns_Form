using System.Text.RegularExpressions;

namespace Cadastro_Aluno_Windowns_Form
{
    public partial class Form1 : Form
    {

        public class aluno
        {
            public string nome {  get; set; }
            public string cpf { get; set; }
            public string genero { get; set; }
            public string rg { get; set; }
            public string responsavel { get; set; }
            public string telefone {  get; set; }
            public string email { get; set; }
            public string endereco {  get; set; }
            public string matricula { get; set; }
            public string serie_turma { get; set; }
            public string turno { get; set; }
            public string status { get; set; }
        }

        aluno a = new aluno();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 Form2 = new Form2(a.nome,a.cpf,a.genero,a.responsavel,a.telefone,a.email,a.endereco,a.matricula,a.serie_turma,a.turno,a.status,a.rg);
            Form2.FormClosed += (s, e) => this.Show();
            Form2.Show();
            this.Hide();
        }

        private void TextNome_TextChanged(object sender, EventArgs e)
        {
            a.nome = Regex.Replace(TextNome.Text, @"Nome Completo:\s*", "");
        }

        private void TextCpf_TextChanged(object sender, EventArgs e)
        {
            a.cpf = Regex.Replace(TextCpf.Text, @"Cpf:\s*", "");
        }

        private void TextRg_TextChanged(object sender, EventArgs e)
        {
            a.rg = Regex.Replace(TextRg.Text, @"RG:\s*", "");
        }

        private void textResponzável_TextChanged(object sender, EventArgs e)
        {
            a.responsavel = Regex.Replace(textResponzável.Text, @"Nome do Responsável:\s*", "");
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {
            a.telefone = Regex.Replace(textTelefone.Text,@"Telefone:\s*", "");
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            a.email = Regex.Replace(textEmail.Text, @"Email:\s*", "");
        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {
            a.endereco = Regex.Replace(textEndereco.Text, @"Endereço:\s*","");
        }

        private void textMatricula_TextChanged(object sender, EventArgs e)
        {
            a.matricula = Regex.Replace(textMatricula.Text,@"Matricula:\s*","");
        }

        private void textSerieTurma_TextChanged(object sender, EventArgs e)
        {
            a.serie_turma = Regex.Replace(textSerieTurma.Text,@"Serie/Turma:\s*","");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a.turno = comboBox1.Text;
        }

        private void textStatus_TextChanged(object sender, EventArgs e)
        {
            a.status = Regex.Replace(textStatus.Text, @"Status \(ativo, trancado, evadido, concluído\):\s", "");
        }

        private void Genero_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Masculino.Checked == true)
            {
                a.genero = "Masculino";
            }
        }

        private void Genero_feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_feminino.Checked == true)
            {
                a.genero = "Feminino";
            }
        }

        private void Genero_NaoBinare_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_NaoBinare.Checked == true)
            {
                a.genero = "Não Binare";
            }

        }

    }
}
