namespace Bibliotech.FomularioSelecao
{
    partial class FormCadastroAutor
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nomeAutorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAutor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogoInvisivel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjButton1 = new Bibliotech.ControlePersonalizado.RJButton();
            this.buttonGravar = new Bibliotech.ControlePersonalizado.RJButton();
            this.BindingSourceCadastroAutor = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeAutorTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            nomeAutorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInvisivel)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCadastroAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(28, 68);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(61, 20);
            codigoLabel.TabIndex = 66;
            codigoLabel.Text = "Código";
            // 
            // nomeAutorLabel
            // 
            nomeAutorLabel.AutoSize = true;
            nomeAutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeAutorLabel.Location = new System.Drawing.Point(163, 68);
            nomeAutorLabel.Name = "nomeAutorLabel";
            nomeAutorLabel.Size = new System.Drawing.Size(98, 20);
            nomeAutorLabel.TabIndex = 68;
            nomeAutorLabel.Text = "Nome Autor";
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
            this.panel1.TabIndex = 64;
            // 
            // pictureBoxLogoInvisivel
            // 
            this.pictureBoxLogoInvisivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogoInvisivel.Image = global::Bibliotech.Properties.Resources._33_preview_rev_1;
            this.pictureBoxLogoInvisivel.Location = new System.Drawing.Point(219, 3);
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
            this.label1.Text = "Bibliotech - Cadastro de Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.panel3.Controls.Add(this.rjButton1);
            this.panel3.Controls.Add(this.buttonGravar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 60);
            this.panel3.TabIndex = 65;
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
            this.rjButton1.Location = new System.Drawing.Point(161, 6);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjButton1.Size = new System.Drawing.Size(150, 48);
            this.rjButton1.TabIndex = 1;
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
            this.buttonGravar.Image = global::Bibliotech.Properties.Resources.icons8_salvar_arquivo_80__1_;
            this.buttonGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGravar.Location = new System.Drawing.Point(5, 6);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonGravar.Size = new System.Drawing.Size(150, 48);
            this.buttonGravar.TabIndex = 0;
            this.buttonGravar.Text = "       &Salvar";
            this.buttonGravar.TextColor = System.Drawing.Color.White;
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // BindingSourceCadastroAutor
            // 
            this.BindingSourceCadastroAutor.DataSource = typeof(Model.ClassesModel.Autor);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCadastroAutor, "CODIGO", true));
            this.codigoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTextBox.Location = new System.Drawing.Point(31, 91);
            this.codigoTextBox.Multiline = true;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(130, 31);
            this.codigoTextBox.TabIndex = 67;
            // 
            // nomeAutorTextBox
            // 
            this.nomeAutorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceCadastroAutor, "NOME_AUTOR", true));
            this.nomeAutorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAutorTextBox.Location = new System.Drawing.Point(167, 91);
            this.nomeAutorTextBox.Multiline = true;
            this.nomeAutorTextBox.Name = "nomeAutorTextBox";
            this.nomeAutorTextBox.Size = new System.Drawing.Size(632, 31);
            this.nomeAutorTextBox.TabIndex = 69;
            // 
            // FormCadastroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 532);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.nomeAutorTextBox);
            this.Controls.Add(nomeAutorLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 571);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(845, 571);
            this.Name = "FormCadastroAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Autor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInvisivel)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCadastroAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogoInvisivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private ControlePersonalizado.RJButton buttonGravar;
        private System.Windows.Forms.BindingSource BindingSourceCadastroAutor;
        private ControlePersonalizado.RJButton rjButton1;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeAutorTextBox;
    }
}