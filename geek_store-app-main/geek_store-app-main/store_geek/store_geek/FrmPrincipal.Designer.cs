namespace store_geek
{
    partial class FrmPrincipal
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxVendas = new System.Windows.Forms.PictureBox();
            this.pbxClientes = new System.Windows.Forms.PictureBox();
            this.pbxTipoProduto = new System.Windows.Forms.PictureBox();
            this.pbxProdutos = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTipoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(690, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Vendas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo de produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Clientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.tipoDoProdutoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // tipoDoProdutoToolStripMenuItem
            // 
            this.tipoDoProdutoToolStripMenuItem.Name = "tipoDoProdutoToolStripMenuItem";
            this.tipoDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.tipoDoProdutoToolStripMenuItem.Text = "Tipo do produto";
            this.tipoDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.tipoDoProdutoToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::store_geek.Properties.Resources.transferir;
            this.pbxSair.Location = new System.Drawing.Point(651, 55);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(137, 134);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 14;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // pbxVendas
            // 
            this.pbxVendas.Image = global::store_geek.Properties.Resources.venda;
            this.pbxVendas.Location = new System.Drawing.Point(488, 55);
            this.pbxVendas.Name = "pbxVendas";
            this.pbxVendas.Size = new System.Drawing.Size(137, 134);
            this.pbxVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVendas.TabIndex = 12;
            this.pbxVendas.TabStop = false;
            this.pbxVendas.Click += new System.EventHandler(this.pbxVendas_Click);
            // 
            // pbxClientes
            // 
            this.pbxClientes.Image = global::store_geek.Properties.Resources.client;
            this.pbxClientes.Location = new System.Drawing.Point(175, 55);
            this.pbxClientes.Name = "pbxClientes";
            this.pbxClientes.Size = new System.Drawing.Size(137, 134);
            this.pbxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClientes.TabIndex = 13;
            this.pbxClientes.TabStop = false;
            this.pbxClientes.Click += new System.EventHandler(this.pbxClientes_Click);
            // 
            // pbxTipoProduto
            // 
            this.pbxTipoProduto.Image = global::store_geek.Properties.Resources.tipo;
            this.pbxTipoProduto.Location = new System.Drawing.Point(329, 55);
            this.pbxTipoProduto.Name = "pbxTipoProduto";
            this.pbxTipoProduto.Size = new System.Drawing.Size(137, 134);
            this.pbxTipoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTipoProduto.TabIndex = 11;
            this.pbxTipoProduto.TabStop = false;
            this.pbxTipoProduto.Click += new System.EventHandler(this.pbxTipoProduto_Click);
            // 
            // pbxProdutos
            // 
            this.pbxProdutos.Image = global::store_geek.Properties.Resources.produto;
            this.pbxProdutos.Location = new System.Drawing.Point(12, 55);
            this.pbxProdutos.Name = "pbxProdutos";
            this.pbxProdutos.Size = new System.Drawing.Size(137, 134);
            this.pbxProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProdutos.TabIndex = 10;
            this.pbxProdutos.TabStop = false;
            this.pbxProdutos.Click += new System.EventHandler(this.pbxProdutos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxVendas);
            this.Controls.Add(this.pbxClientes);
            this.Controls.Add(this.pbxTipoProduto);
            this.Controls.Add(this.pbxProdutos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTipoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.PictureBox pbxVendas;
        private System.Windows.Forms.PictureBox pbxClientes;
        private System.Windows.Forms.PictureBox pbxTipoProduto;
        private System.Windows.Forms.PictureBox pbxProdutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

