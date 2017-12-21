namespace Minha_Lista
{
    partial class FrmCadPro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePro = new System.Windows.Forms.TextBox();
            this.tBPRECOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CONTROLE_COMPRASDataSet = new Minha_Lista.DB_CONTROLE_COMPRASDataSet();
            this.txtMercado = new System.Windows.Forms.TextBox();
            this.txtMarcaPro = new System.Windows.Forms.TextBox();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.btnFrmCad = new System.Windows.Forms.Button();
            this.btnFrmSair = new System.Windows.Forms.Button();
            this.btnFrmLimpar = new System.Windows.Forms.Button();
            this.tB_PRECO_PRODUTOTableAdapter = new Minha_Lista.DB_CONTROLE_COMPRASDataSetTableAdapters.TB_PRECO_PRODUTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRECOPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CONTROLE_COMPRASDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(109, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(-1, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mercado da Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data da Compra";
            // 
            // txtNomePro
            // 
            this.txtNomePro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRECOPRODUTOBindingSource, "NM_PRODUTO", true));
            this.txtNomePro.Location = new System.Drawing.Point(186, 91);
            this.txtNomePro.Multiline = true;
            this.txtNomePro.Name = "txtNomePro";
            this.txtNomePro.Size = new System.Drawing.Size(229, 20);
            this.txtNomePro.TabIndex = 5;
            // 
            // tBPRECOPRODUTOBindingSource
            // 
            this.tBPRECOPRODUTOBindingSource.DataMember = "TB_PRECO_PRODUTO";
            this.tBPRECOPRODUTOBindingSource.DataSource = this.dB_CONTROLE_COMPRASDataSet;
            // 
            // dB_CONTROLE_COMPRASDataSet
            // 
            this.dB_CONTROLE_COMPRASDataSet.DataSetName = "DB_CONTROLE_COMPRASDataSet";
            this.dB_CONTROLE_COMPRASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMercado
            // 
            this.txtMercado.Location = new System.Drawing.Point(186, 244);
            this.txtMercado.Name = "txtMercado";
            this.txtMercado.Size = new System.Drawing.Size(229, 20);
            this.txtMercado.TabIndex = 6;
            // 
            // txtMarcaPro
            // 
            this.txtMarcaPro.Location = new System.Drawing.Point(186, 164);
            this.txtMarcaPro.Name = "txtMarcaPro";
            this.txtMarcaPro.Size = new System.Drawing.Size(229, 20);
            this.txtMarcaPro.TabIndex = 7;
            // 
            // maskData
            // 
            this.maskData.Location = new System.Drawing.Point(186, 324);
            this.maskData.Mask = "00/00/0000";
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(229, 20);
            this.maskData.TabIndex = 8;
            this.maskData.ValidatingType = typeof(System.DateTime);
            this.maskData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnFrmCad
            // 
            this.btnFrmCad.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnFrmCad.Location = new System.Drawing.Point(95, 403);
            this.btnFrmCad.Name = "btnFrmCad";
            this.btnFrmCad.Size = new System.Drawing.Size(174, 47);
            this.btnFrmCad.TabIndex = 9;
            this.btnFrmCad.Text = "Cadastrar";
            this.btnFrmCad.UseVisualStyleBackColor = true;
            // 
            // btnFrmSair
            // 
            this.btnFrmSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmSair.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnFrmSair.Location = new System.Drawing.Point(516, 403);
            this.btnFrmSair.Name = "btnFrmSair";
            this.btnFrmSair.Size = new System.Drawing.Size(174, 47);
            this.btnFrmSair.TabIndex = 10;
            this.btnFrmSair.Text = "Sair";
            this.btnFrmSair.UseVisualStyleBackColor = true;
            this.btnFrmSair.Click += new System.EventHandler(this.btnFrmSair_Click);
            // 
            // btnFrmLimpar
            // 
            this.btnFrmLimpar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnFrmLimpar.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnFrmLimpar.Location = new System.Drawing.Point(304, 403);
            this.btnFrmLimpar.Name = "btnFrmLimpar";
            this.btnFrmLimpar.Size = new System.Drawing.Size(174, 47);
            this.btnFrmLimpar.TabIndex = 11;
            this.btnFrmLimpar.Text = "Limpar";
            this.btnFrmLimpar.UseVisualStyleBackColor = true;
            // 
            // tB_PRECO_PRODUTOTableAdapter
            // 
            this.tB_PRECO_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 514);
            this.Controls.Add(this.btnFrmLimpar);
            this.Controls.Add(this.btnFrmSair);
            this.Controls.Add(this.btnFrmCad);
            this.Controls.Add(this.maskData);
            this.Controls.Add(this.txtMarcaPro);
            this.Controls.Add(this.txtMercado);
            this.Controls.Add(this.txtNomePro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadPro";
            this.Load += new System.EventHandler(this.FrmCadPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBPRECOPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CONTROLE_COMPRASDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomePro;
        private System.Windows.Forms.TextBox txtMercado;
        private System.Windows.Forms.TextBox txtMarcaPro;
        public System.Windows.Forms.MaskedTextBox maskData;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private DB_CONTROLE_COMPRASDataSet dB_CONTROLE_COMPRASDataSet;
        private System.Windows.Forms.BindingSource tBPRECOPRODUTOBindingSource;
        private DB_CONTROLE_COMPRASDataSetTableAdapters.TB_PRECO_PRODUTOTableAdapter tB_PRECO_PRODUTOTableAdapter;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnFrmCad;
        public System.Windows.Forms.Button btnFrmSair;
        public System.Windows.Forms.Button btnFrmLimpar;
    }
}