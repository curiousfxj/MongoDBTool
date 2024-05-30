using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBTool
{
    public partial class Form1 : Form
    {
        MongoImportExportCollections objMongoManager = new MongoImportExportCollections();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(txtDBConnExport.Text == string.Empty)
            {
                MessageBox.Show("Please provide database connection string", "Export Collections",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtDBExport.Text == string.Empty)
            {
                MessageBox.Show("Please enter database name", "Export Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtExportLocation.Text == string.Empty)
            {
                MessageBox.Show("Please provide a valid location to export the files", "Export Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Directory.Exists(txtExportLocation.Text))
            {
                if(objMongoManager.ExportAllCollectionsToJSON(txtDBConnExport.Text, txtDBExport.Text, txtExportLocation.Text))
                {
                    MessageBox.Show("Exported all collections to JSON successfully", "Export Collections", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error exporting collections to JSON", "Export Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Export location does not exist", "Export Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDBConImport.Text == string.Empty)
            {
                MessageBox.Show("Please provide database connection string", "Import Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDatabaseImport.Text == string.Empty)
            {
                MessageBox.Show("Please enter database name", "Import Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtImportLocation.Text == string.Empty)
            {
                MessageBox.Show("Please provide a valid location to Import the files", "Import Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Directory.Exists(txtImportLocation.Text))
            {
                if(objMongoManager.ImportJSONFilesToCollections(txtDBConImport.Text, txtDatabaseImport.Text, txtImportLocation.Text))
                {
                    MessageBox.Show("Imported all collections to JSON successfully", "Import Collections", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error ixporting collections to JSON", "Import Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Import location does not exist", "Import Collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
