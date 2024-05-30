namespace MongoDBTool
{
    partial class Form1
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
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDBConnExport = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDBExport = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtExportLocation = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtImportLocation = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatabaseImport = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDBConImport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(205, 181);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(176, 26);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Collections";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Import Collections";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDBConnExport
            // 
            this.txtDBConnExport.Location = new System.Drawing.Point(205, 59);
            this.txtDBConnExport.Name = "txtDBConnExport";
            this.txtDBConnExport.Size = new System.Drawing.Size(492, 22);
            this.txtDBConnExport.TabIndex = 0;
            this.txtDBConnExport.Text = "mongodb://localhost:27017";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Database Connection String";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Database";
            // 
            // txtDBExport
            // 
            this.txtDBExport.Location = new System.Drawing.Point(205, 96);
            this.txtDBExport.Name = "txtDBExport";
            this.txtDBExport.Size = new System.Drawing.Size(492, 22);
            this.txtDBExport.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Export Location";
            // 
            // txtExportLocation
            // 
            this.txtExportLocation.Location = new System.Drawing.Point(205, 138);
            this.txtExportLocation.Name = "txtExportLocation";
            this.txtExportLocation.Size = new System.Drawing.Size(492, 22);
            this.txtExportLocation.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 456);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 16);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Import Location";
            // 
            // txtImportLocation
            // 
            this.txtImportLocation.Location = new System.Drawing.Point(205, 453);
            this.txtImportLocation.Name = "txtImportLocation";
            this.txtImportLocation.Size = new System.Drawing.Size(492, 22);
            this.txtImportLocation.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 414);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Database";
            // 
            // txtDatabaseImport
            // 
            this.txtDatabaseImport.Location = new System.Drawing.Point(205, 411);
            this.txtDatabaseImport.Name = "txtDatabaseImport";
            this.txtDatabaseImport.Size = new System.Drawing.Size(492, 22);
            this.txtDatabaseImport.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 377);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(158, 16);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Database Connection String";
            // 
            // txtDBConImport
            // 
            this.txtDBConImport.Location = new System.Drawing.Point(205, 374);
            this.txtDBConImport.Name = "txtDBConImport";
            this.txtDBConImport.Size = new System.Drawing.Size(492, 22);
            this.txtDBConImport.TabIndex = 4;
            this.txtDBConImport.Text = "mongodb://localhost:27017";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 707);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtImportLocation);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDatabaseImport);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDBConImport);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtExportLocation);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDBExport);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDBConnExport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "MongoDB Export Importer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDBConnExport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtDBExport;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtExportLocation;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtImportLocation;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtDatabaseImport;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtDBConImport;
    }
}

