
namespace NewApp
{
    partial class F_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Report));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApplyCustomDate = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.buttonThisYear = new System.Windows.Forms.Button();
            this.buttonLast30Days = new System.Windows.Forms.Button();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonLast7Days = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelatorioVendasDALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendasLiquidasPorPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioVendasDALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendasLiquidasPorPeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonApplyCustomDate);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Controls.Add(this.buttonCustom);
            this.panel1.Controls.Add(this.buttonThisYear);
            this.panel1.Controls.Add(this.buttonLast30Days);
            this.panel1.Controls.Add(this.buttonThisMonth);
            this.panel1.Controls.Add(this.buttonLast7Days);
            this.panel1.Controls.Add(this.buttonToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 961);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "From:";
            // 
            // buttonApplyCustomDate
            // 
            this.buttonApplyCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonApplyCustomDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonApplyCustomDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonApplyCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyCustomDate.Location = new System.Drawing.Point(47, 504);
            this.buttonApplyCustomDate.Name = "buttonApplyCustomDate";
            this.buttonApplyCustomDate.Size = new System.Drawing.Size(139, 35);
            this.buttonApplyCustomDate.TabIndex = 8;
            this.buttonApplyCustomDate.Text = "Apply";
            this.buttonApplyCustomDate.UseVisualStyleBackColor = true;
            this.buttonApplyCustomDate.Click += new System.EventHandler(this.buttonApplyCustomDate_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(57, 469);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerToDate.TabIndex = 7;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(57, 437);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerFromDate.TabIndex = 6;
            // 
            // buttonCustom
            // 
            this.buttonCustom.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonCustom.FlatAppearance.BorderSize = 0;
            this.buttonCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom.Location = new System.Drawing.Point(0, 354);
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(230, 60);
            this.buttonCustom.TabIndex = 5;
            this.buttonCustom.Text = "Custom";
            this.buttonCustom.UseVisualStyleBackColor = true;
            this.buttonCustom.Click += new System.EventHandler(this.buttonCustom_Click);
            // 
            // buttonThisYear
            // 
            this.buttonThisYear.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonThisYear.FlatAppearance.BorderSize = 0;
            this.buttonThisYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonThisYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonThisYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThisYear.Location = new System.Drawing.Point(0, 297);
            this.buttonThisYear.Name = "buttonThisYear";
            this.buttonThisYear.Size = new System.Drawing.Size(230, 60);
            this.buttonThisYear.TabIndex = 4;
            this.buttonThisYear.Text = "This Year";
            this.buttonThisYear.UseVisualStyleBackColor = true;
            this.buttonThisYear.Click += new System.EventHandler(this.buttonThisYear_Click);
            // 
            // buttonLast30Days
            // 
            this.buttonLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonLast30Days.FlatAppearance.BorderSize = 0;
            this.buttonLast30Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonLast30Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast30Days.Location = new System.Drawing.Point(0, 241);
            this.buttonLast30Days.Name = "buttonLast30Days";
            this.buttonLast30Days.Size = new System.Drawing.Size(230, 60);
            this.buttonLast30Days.TabIndex = 3;
            this.buttonLast30Days.Text = "Last 30 Days";
            this.buttonLast30Days.UseVisualStyleBackColor = true;
            this.buttonLast30Days.Click += new System.EventHandler(this.buttonLast30Days_Click);
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonThisMonth.FlatAppearance.BorderSize = 0;
            this.buttonThisMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonThisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThisMonth.Location = new System.Drawing.Point(0, 184);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(230, 60);
            this.buttonThisMonth.TabIndex = 2;
            this.buttonThisMonth.Text = "This Month";
            this.buttonThisMonth.UseVisualStyleBackColor = true;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonLast7Days
            // 
            this.buttonLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonLast7Days.FlatAppearance.BorderSize = 0;
            this.buttonLast7Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonLast7Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast7Days.Location = new System.Drawing.Point(0, 128);
            this.buttonLast7Days.Name = "buttonLast7Days";
            this.buttonLast7Days.Size = new System.Drawing.Size(230, 60);
            this.buttonLast7Days.TabIndex = 1;
            this.buttonLast7Days.Text = "Last 7 Days";
            this.buttonLast7Days.UseVisualStyleBackColor = true;
            this.buttonLast7Days.Click += new System.EventHandler(this.buttonLast7Days_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.Location = new System.Drawing.Point(0, 72);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(230, 60);
            this.buttonToday.TabIndex = 0;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 51;
            reportDataSource1.Name = "relatorioVendas";
            reportDataSource1.Value = this.RelatorioVendasDALBindingSource;
            reportDataSource2.Name = "listaVendas";
            reportDataSource2.Value = this.ListaVendasBindingSource;
            reportDataSource3.Name = "vendasLiquidasPorPeriodo";
            reportDataSource3.Value = this.VendasLiquidasPorPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIPrincipal.Report.RelatorioVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(230, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(854, 961);
            this.reportViewer1.TabIndex = 2;
            // 
            // RelatorioVendasDALBindingSource
            // 
            this.RelatorioVendasDALBindingSource.DataSource = typeof(DAL.RelatorioVendasDAL);
            // 
            // ListaVendasBindingSource
            // 
            this.ListaVendasBindingSource.DataSource = typeof(Model.ListaVendas);
            // 
            // VendasLiquidasPorPeriodoBindingSource
            // 
            this.VendasLiquidasPorPeriodoBindingSource.DataSource = typeof(Model.VendasLiquidasPorPeriodo);
            // 
            // F_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 961);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "F_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Relatório";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioVendasDALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendasLiquidasPorPeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCustom;
        private System.Windows.Forms.Button buttonThisYear;
        private System.Windows.Forms.Button buttonLast30Days;
        private System.Windows.Forms.Button buttonThisMonth;
        private System.Windows.Forms.Button buttonLast7Days;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApplyCustomDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RelatorioVendasDALBindingSource;
        private System.Windows.Forms.BindingSource ListaVendasBindingSource;
        private System.Windows.Forms.BindingSource VendasLiquidasPorPeriodoBindingSource;
    }
}