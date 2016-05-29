﻿namespace mise
{
    partial class FrmRelatorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorios));
            this.txtDataIni = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.gridResumo = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataIni
            // 
            this.txtDataIni.Location = new System.Drawing.Point(16, 42);
            this.txtDataIni.Mask = "00/00/0000";
            this.txtDataIni.Name = "txtDataIni";
            this.txtDataIni.Size = new System.Drawing.Size(120, 26);
            this.txtDataIni.TabIndex = 25;
            this.txtDataIni.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data Inicial";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Location = new System.Drawing.Point(158, 42);
            this.txtDataFim.Mask = "00/00/0000";
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(120, 26);
            this.txtDataFim.TabIndex = 27;
            this.txtDataFim.ValidatingType = typeof(System.DateTime);
            this.txtDataFim.Enter += new System.EventHandler(this.txtDataFim_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Data Final";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVisualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.ForeColor = System.Drawing.Color.Black;
            this.btnVisualizar.Location = new System.Drawing.Point(320, 38);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(112, 35);
            this.btnVisualizar.TabIndex = 28;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // gridResumo
            // 
            this.gridResumo.AllowUserToAddRows = false;
            this.gridResumo.AllowUserToDeleteRows = false;
            this.gridResumo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridResumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.codigo,
            this.qtd,
            this.total});
            this.gridResumo.Location = new System.Drawing.Point(16, 91);
            this.gridResumo.Name = "gridResumo";
            this.gridResumo.ReadOnly = true;
            this.gridResumo.RowHeadersVisible = false;
            this.gridResumo.Size = new System.Drawing.Size(804, 616);
            this.gridResumo.TabIndex = 29;
            this.gridResumo.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.gridResumo_SortCompare);
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 340;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 200;
            // 
            // qtd
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qtd.DefaultCellStyle = dataGridViewCellStyle1;
            this.qtd.HeaderText = "Quantidade";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 120;
            // 
            // total
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 120;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(849, 741);
            this.Controls.Add(this.gridResumo);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataIni);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorios";
            this.Text = "Relatório Analítico de Vendas";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDataIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView gridResumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}