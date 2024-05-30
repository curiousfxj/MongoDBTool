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
            this.txtDBExport = new System.Windows.Forms.TextBox();
            this.txtExportLocation = new System.Windows.Forms.TextBox();
            this.txtImportLocation = new System.Windows.Forms.TextBox();
            this.txtDatabaseImport = new System.Windows.Forms.TextBox();
            this.txtDBConImport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // txtDBExport
            // 
            this.txtDBExport.Location = new System.Drawing.Point(205, 96);
            this.txtDBExport.Name = "txtDBExport";
            this.txtDBExport.Size = new System.Drawing.Size(492, 22);
            this.txtDBExport.TabIndex = 1;
            // 
            // txtExportLocation
            // 
            this.txtExportLocation.Location = new System.Drawing.Point(205, 138);
            this.txtExportLocation.Name = "txtExportLocation";
            this.txtExportLocation.Size = new System.Drawing.Size(492, 22);
            this.txtExportLocation.TabIndex = 2;
            // 
            // txtImportLocation
            // 
            this.txtImportLocation.Location = new System.Drawing.Point(205, 453);
            this.txtImportLocation.Name = "txtImportLocation";
            this.txtImportLocation.Size = new System.Drawing.Size(492, 22);
            this.txtImportLocation.TabIndex = 6;
            // 
            // txtDatabaseImport
            // 
            this.txtDatabaseImport.Location = new System.Drawing.Point(205, 411);
            this.txtDatabaseImport.Name = "txtDatabaseImport";
            this.txtDatabaseImport.Size = new System.Drawing.Size(492, 22);
            this.txtDatabaseImport.TabIndex = 5;
            // 
            // txtDBConImport
            // 
            this.txtDBConImport.Location = new System.Drawing.Point(205, 374);
            this.txtDBConImport.Name = "txtDBConImport";
            this.txtDBConImport.Size = new System.Drawing.Size(492, 22);
            this.txtDBConImport.TabIndex = 4;
            this.txtDBConImport.Text = "mongodb://localhost:27017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Database Connection String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Export Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Import Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Database Connection String";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 707);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImportLocation);
            this.Controls.Add(this.txtDatabaseImport);
            this.Controls.Add(this.txtDBConImport);
            this.Controls.Add(this.txtExportLocation);
            this.Controls.Add(this.txtDBExport);
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
        private System.Windows.Forms.TextBox txtDBExport;
        private System.Windows.Forms.TextBox txtExportLocation;
        private System.Windows.Forms.TextBox txtImportLocation;
        private System.Windows.Forms.TextBox txtDatabaseImport;
        private System.Windows.Forms.TextBox txtDBConImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

