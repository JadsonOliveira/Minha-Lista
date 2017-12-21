using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Lista
{
    public partial class FrmCadPro : Form
    {
        public FrmCadPro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmCadPro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_CONTROLE_COMPRASDataSet.TB_PRECO_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_PRECO_PRODUTOTableAdapter.Fill(this.dB_CONTROLE_COMPRASDataSet.TB_PRECO_PRODUTO);

        }

        private void btnFrmSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
