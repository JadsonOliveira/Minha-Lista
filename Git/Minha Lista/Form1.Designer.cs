namespace Minha_Lista
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Consultar = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.DgResultado = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dB_CONTROLE_COMPRASDataSet = new Minha_Lista.DB_CONTROLE_COMPRASDataSet();
            this.tBPRECOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_PRECO_PRODUTOTableAdapter = new Minha_Lista.DB_CONTROLE_COMPRASDataSetTableAdapters.TB_PRECO_PRODUTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CONTROLE_COMPRASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRECOPRODUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.AutoSize = true;
            this.Consultar.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(-9, 11);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(235, 64);
            this.Consultar.TabIndex = 0;
            this.Consultar.Text = "Consultar";
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(807, 11);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(101, 52);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(936, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 52);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(418, 545);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 52);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.Location = new System.Drawing.Point(550, 545);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 52);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Location = new System.Drawing.Point(678, 545);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 52);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(936, 545);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 52);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold);
            this.btnConsultarTodos.Location = new System.Drawing.Point(2, 545);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(293, 52);
            this.btnConsultarTodos.TabIndex = 8;
            this.btnConsultarTodos.Text = "Consultar Tudo";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // DgResultado
            // 
            this.DgResultado.AllowUserToOrderColumns = true;
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.GridColor = System.Drawing.SystemColors.Control;
            this.DgResultado.Location = new System.Drawing.Point(2, 78);
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgResultado.Size = new System.Drawing.Size(1035, 461);
            this.DgResultado.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRECOPRODUTOBindingSource, "NM_PRODUTO", true));
            this.comboBox1.DataSource = this.tBPRECOPRODUTOBindingSource;
            this.comboBox1.DisplayMember = "NM_PRODUTO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dB_CONTROLE_COMPRASDataSet
            // 
            this.dB_CONTROLE_COMPRASDataSet.DataSetName = "DB_CONTROLE_COMPRASDataSet";
            this.dB_CONTROLE_COMPRASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPRECOPRODUTOBindingSource
            // 
            this.tBPRECOPRODUTOBindingSource.DataMember = "TB_PRECO_PRODUTO";
            this.tBPRECOPRODUTOBindingSource.DataSource = this.dB_CONTROLE_COMPRASDataSet;
            // 
            // tB_PRECO_PRODUTOTableAdapter
            // 
            this.tB_PRECO_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 609);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DgResultado);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.Consultar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CONTROLE_COMPRASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRECOPRODUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Consultar;
        public System.Windows.Forms.Button btnConsulta;
        public System.Windows.Forms.Button btnConsultarTodos;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.DataGridView DgResultado;
        public System.Windows.Forms.ComboBox comboBox1;
        private DB_CONTROLE_COMPRASDataSet dB_CONTROLE_COMPRASDataSet;
        private System.Windows.Forms.BindingSource tBPRECOPRODUTOBindingSource;
        private DB_CONTROLE_COMPRASDataSetTableAdapters.TB_PRECO_PRODUTOTableAdapter tB_PRECO_PRODUTOTableAdapter;
    }
}

