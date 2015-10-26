using System;   
using System.ComponentModel;
using System.Windows.Forms;

namespace App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitializeXmlOpenDialog();
            InitializeXslOpenDialog();
        }

        private void InitializeXmlOpenDialog()
        {
            openXml.Multiselect = false;
            openXml.InitialDirectory = @"C:\";
            openXml.FileName = string.Empty;
            openXml.FileOk += OpenXmlOnFileOk;            
        }

        private void InitializeXslOpenDialog()
        {
            openXsl.Multiselect = false;
            openXsl.InitialDirectory = @"C:\";
            openXsl.FileName = string.Empty;
            openXsl.FileOk += OpenXslOnFileOk;   
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            openXml.ShowDialog();
        }

        private void OpenXmlOnFileOk(object sender, CancelEventArgs cancelEventArgs)
        {
            txtXmlFileName.Text = openXml.FileName;
        }

        private void OpenXslOnFileOk(object sender, CancelEventArgs cancelEventArgs)
        {
            txtXslFileName.Text = openXsl.FileName;
        }

        private void btnLoadXsl_Click(object sender, EventArgs e)
        {
            openXsl.ShowDialog();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtXmlFileName.Text) || String.IsNullOrEmpty(txtXslFileName.Text))
            {
                MessageBox.Show("You must choose XML and XSL(T) files before continue!", "Stop", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    var transformer = new XslTransformer();
                    transformer.Initialize(txtXslFileName.Text);
                    txtOutput.Text = transformer.GenerateString(openXml.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
