using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBase64App
{
    public partial class frmSimpleConverter : Form
    {
        public frmSimpleConverter()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            op.Multiselect = false;
            if (op.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = op.FileName;
            }
        }

        private void frmSimpleConverter_Load(object sender, EventArgs e)
        {

        }

        private void lblPath_TextChanged(object sender, EventArgs e)
        {
            btnImageToBase64.Visible = !string.IsNullOrEmpty(lblPath.Text);
            rtbConverterString.Visible = !string.IsNullOrEmpty(lblPath.Text);
            cbHtml.Visible = !string.IsNullOrEmpty(lblPath.Text);
        }

        private void btnImageToBase64_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(lblPath.Text))
            {
                rtbConverterString.Text = library.Converter.base64string(lblPath.Text,cbHtml.Checked);
            }
        }

        private void btnExportToHtml_Click(object sender, EventArgs e)
        {
            var mImageName = "Exported Image";

            var htmlString = "<img alt="+mImageName +" src="+ library.Converter.base64string(lblPath.Text,cbHtml.Checked);

            System.IO.File.Create("test.html");

            var os = new SaveFileDialog();

            if (os.ShowDialog() == DialogResult.OK)
            {
                
            }

        }
    }
}
