using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Minha_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_CONTROLE_COMPRASDataSet.TB_PRECO_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRECO_PRODUTOTableAdapter.Fill(this.dB_CONTROLE_COMPRASDataSet.TB_PRECO_PRODUTO);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String Stringcon = @"Data Source=DESKTOP-AOPO69T;Initial Catalog=DB_CONTROLE_COMPRAS;Integrated Security=True";
            Conexao conexao = new Conexao(Stringcon);
            try
            {
                conexao.Conectar();
                String SQL = "Select * from TB_PRECO_PRODUTO";

                var adapter = new SqlDataAdapter(SQL, Stringcon);

                var ds = new DataSet();

                adapter.Fill(ds, "TB_PRECO_PRODUTO");

                DgResultado.DataSource = ds.Tables["TB_PRECO_PRODUTO"];
            }
            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }
        public void CarregarClientes()
        {
            try
            {
                String Stringcon = @"Data Source=DESKTOP-AOPO69T;Initial Catalog=DB_CONTROLE_COMPRAS;Integrated Security=True";
                var conn = new SqlConnection(Stringcon);
                conn.Open();

                String SQL = "Select * from TB_PRECO_PRODUTO";

                var adapter = new SqlDataAdapter(SQL, conn);

                var ds = new DataSet();

                adapter.Fill(ds, "TB_PRECO_PRODUTO");

                DgResultado.DataSource = ds.Tables["TB_PRECO_PRODUTO"];



            }


            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadPro Frm = new FrmCadPro();
            Frm.Show();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
