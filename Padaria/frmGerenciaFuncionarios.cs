using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Padaria
{
    public partial class frmGerenciaFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmGerenciaFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmGerenciaFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;
            mskCep.Enabled = false;
            mskCpf.Enabled = false;
            mskTelefone.Enabled = false;
            cmbEstado.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void habilitarCamposNovo()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            mskCep.Enabled = true;
            mskCpf.Enabled = true;
            mskTelefone.Enabled = true;
            cmbEstado.Enabled = true;
           
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void habilitarCamposPesquisar()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            mskCep.Enabled = true;
            mskCpf.Enabled = true;
            mskTelefone.Enabled = true;
            cmbEstado.Enabled = true;

            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            mskCep.Text = "";
            mskCpf.Text = "";
            mskTelefone.Text = "";
            cmbEstado.Text = "";
            
            
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
           habilitarCamposNovo();
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Equals("") || txtCidade.Text.Equals("") || txtComplemento.Text.Equals("") ||
                txtEmail.Text.Equals("") || txtEndereco.Text.Equals("") || txtNumero.Text.Equals("") ||
                mskCep.Text.Equals("     -") || mskCpf.Text.Equals("   .   .   -") ||
                mskTelefone.Text.Equals("(  )      -") || cmbEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!");

            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!");
                limparCampos();
                desabilitarCampos();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            habilitarCamposPesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir ?", "Mensagem do sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes) {
                MessageBox.Show("Excluído com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            }
            else
            {
                txtNome.Focus();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            desabilitarCampos();
            limparCampos();
        }
    }
}
