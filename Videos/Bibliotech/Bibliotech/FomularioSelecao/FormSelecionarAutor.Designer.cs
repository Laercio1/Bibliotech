namespace Bibliotech.FomularioSelecao
{
    partial class FormSelecionarAutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecionarAutor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogoInvisivel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton2 = new Bibliotech.ControlePersonalizado.RJButton();
            this.rjButton1 = new Bibliotech.ControlePersonalizado.RJButton();
            this.buttonGravar = new Bibliotech.ControlePersonalizado.RJButton();
            this.TextBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new Bibliotech.ControlePersonalizado.RJButton();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorDataGridView = new System.Windows.Forms.DataGridView();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEAUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInvisivel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.pictureBoxLogoInvisivel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 40);
            this.panel1.TabIndex = 42;
            // 
            // pictureBoxLogoInvisivel
            // 
            this.pictureBoxLogoInvisivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogoInvisivel.Image = global::Bibliotech.Properties.Resources._33_preview_rev_1;
            this.pictureBoxLogoInvisivel.Location = new System.Drawing.Point(223, 3);
            this.pictureBoxLogoInvisivel.Name = "pictureBoxLogoInvisivel";
            this.pictureBoxLogoInvisivel.Size = new System.Drawing.Size(31, 34);
            this.pictureBoxLogoInvisivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoInvisivel.TabIndex = 5;
            this.pictureBoxLogoInvisivel.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bibliotech - Seleção de Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.buttonGravar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 60);
            this.panel2.TabIndex = 43;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = global::Bibliotech.Properties.Resources.icons8_adicionar_regra_50__1_;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(676, 9);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rjButton2.Size = new System.Drawing.Size(150, 48);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "         &Cadastrar";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::Bibliotech.Properties.Resources.icons8_excluir_arquivo_50__1_;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(161, 9);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjButton1.Size = new System.Drawing.Size(150, 48);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "       &Cancelar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.Color.Transparent;
            this.buttonGravar.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonGravar.BorderColor = System.Drawing.Color.White;
            this.buttonGravar.BorderRadius = 15;
            this.buttonGravar.BorderSize = 1;
            this.buttonGravar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGravar.FlatAppearance.BorderSize = 0;
            this.buttonGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravar.ForeColor = System.Drawing.Color.White;
            this.buttonGravar.Image = global::Bibliotech.Properties.Resources.icons8_verificar_arquivo_50__1_;
            this.buttonGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGravar.Location = new System.Drawing.Point(5, 9);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonGravar.Size = new System.Drawing.Size(150, 48);
            this.buttonGravar.TabIndex = 2;
            this.buttonGravar.Text = "         &Selecionar";
            this.buttonGravar.TextColor = System.Drawing.Color.White;
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // TextBoxBuscar
            // 
            this.TextBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBuscar.Location = new System.Drawing.Point(12, 73);
            this.TextBoxBuscar.Multiline = true;
            this.TextBoxBuscar.Name = "TextBoxBuscar";
            this.TextBoxBuscar.Size = new System.Drawing.Size(677, 31);
            this.TextBoxBuscar.TabIndex = 44;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.buttonBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.buttonBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBuscar.BorderRadius = 5;
            this.buttonBuscar.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = global::Bibliotech.Properties.Resources.icons8_pesquisar_50__1___1_;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(695, 67);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(122, 40);
            this.buttonBuscar.TabIndex = 45;
            this.buttonBuscar.Text = "    &Pesquisar";
            this.buttonBuscar.TextColor = System.Drawing.Color.White;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(Model.ClassesModel.Autor);
            // 
            // autorDataGridView
            // 
            this.autorDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.autorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.autorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autorDataGridView.AutoGenerateColumns = false;
            this.autorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.autorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.autorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.autorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.autorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.nOMEAUTORDataGridViewTextBoxColumn});
            this.autorDataGridView.DataSource = this.autorBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.autorDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.autorDataGridView.EnableHeadersVisualStyles = false;
            this.autorDataGridView.Location = new System.Drawing.Point(12, 113);
            this.autorDataGridView.Name = "autorDataGridView";
            this.autorDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.autorDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.autorDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.autorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.autorDataGridView.Size = new System.Drawing.Size(805, 325);
            this.autorDataGridView.TabIndex = 46;
            this.autorDataGridView.DoubleClick += new System.EventHandler(this.autorDataGridView_DoubleClick);
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cODIGODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODIGODataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMEAUTORDataGridViewTextBoxColumn
            // 
            this.nOMEAUTORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMEAUTORDataGridViewTextBoxColumn.DataPropertyName = "NOME_AUTOR";
            this.nOMEAUTORDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nOMEAUTORDataGridViewTextBoxColumn.Name = "nOMEAUTORDataGridViewTextBoxColumn";
            this.nOMEAUTORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormSelecionarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 504);
            this.Controls.Add(this.autorDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.TextBoxBuscar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 543);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(845, 543);
            this.Name = "FormSelecionarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Autor";
            this.Load += new System.EventHandler(this.FormSelecionarAutor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInvisivel)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogoInvisivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ControlePersonalizado.RJButton rjButton1;
        private ControlePersonalizado.RJButton buttonGravar;
        private ControlePersonalizado.RJButton rjButton2;
        private System.Windows.Forms.TextBox TextBoxBuscar;
        private ControlePersonalizado.RJButton buttonBuscar;
        public System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.DataGridView autorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEAUTORDataGridViewTextBoxColumn;
    }
}