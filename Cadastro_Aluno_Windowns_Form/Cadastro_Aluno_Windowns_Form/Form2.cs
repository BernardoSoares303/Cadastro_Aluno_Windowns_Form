using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Aluno_Windowns_Form
{
    public partial class Form2 : Form
    {
        private string nome;
        private string cpf;
        private string genero;
        private string responsavel;
        private string telefone;
        private string email;
        private string endereco;
        private string matricula;
        private string serie_turma;
        private string turno;
        private string status;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nome, string cpf, string genero, string responsavel, string telefone, string email, string endereco, string matricula, string serie_turma, string turno, string status)
        {
            InitializeComponent();
            this.nome = nome;
            this.cpf = cpf;
            this.genero = genero;
            this.responsavel = responsavel;
            this.telefone = telefone;
            this.email = email;
            this.endereco = endereco;
            this.matricula = matricula;
            this.serie_turma = serie_turma;
            this.turno = turno;
            this.status = status;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            labelNome.Text = this.nome;
        }

    }
}
