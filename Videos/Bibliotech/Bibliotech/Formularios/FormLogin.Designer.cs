using Microsoft.VisualBasic.PowerPacks;

namespace Bibliotech.Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 464);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bibliotech.Properties.Resources._33_preview_rev_1;
            this.pictureBox3.Location = new System.Drawing.Point(63, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.Color.White;
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.usuarioTextBox.Location = new System.Drawing.Point(303, 201);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(408, 19);
            this.usuarioTextBox.TabIndex = 3;
            this.usuarioTextBox.Text = "Usuário";
            this.usuarioTextBox.Enter += new System.EventHandler(this.usuarioTextBox_Enter);
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 301;
            this.lineShape1.X2 = 708;
            this.lineShape1.Y1 = 225;
            this.lineShape1.Y2 = 225;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 464);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Silver;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 304;
            this.lineShape2.X2 = 711;
            this.lineShape2.Y1 = 284;
            this.lineShape2.Y2 = 284;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(462, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.Color.White;
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.senhaTextBox.Location = new System.Drawing.Point(304, 260);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(408, 19);
            this.senhaTextBox.TabIndex = 11;
            this.senhaTextBox.Text = "Senha";
            this.senhaTextBox.Enter += new System.EventHandler(this.senhaTextBox_Enter);
            this.senhaTextBox.Leave += new System.EventHandler(this.senhaTextBox_Leave);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(306, 306);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.lblErrorMessage.TabIndex = 18;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Visible = false;
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkpass.Location = new System.Drawing.Point(444, 416);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(140, 16);
            this.linkpass.TabIndex = 20;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Esqueceu sua senha?";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(206)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlogin.Location = new System.Drawing.Point(309, 364);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(408, 40);
            this.btnlogin.TabIndex = 19;
            this.btnlogin.Text = "ENTRAR";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(741, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(15, 15);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 22;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(762, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 21;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 464);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private LineShape lineShape1;
        private ShapeContainer shapeContainer1;
        private LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}