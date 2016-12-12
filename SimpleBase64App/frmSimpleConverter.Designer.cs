namespace SimpleBase64App
{
    partial class frmSimpleConverter
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnImageToBase64 = new System.Windows.Forms.Button();
            this.rtbConverterString = new System.Windows.Forms.RichTextBox();
            this.cbHtml = new System.Windows.Forms.CheckBox();
            this.btnExportToHtml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(770, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(202, 33);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 20);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 17);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path";
            this.lblPath.TextChanged += new System.EventHandler(this.lblPath_TextChanged);
            // 
            // btnImageToBase64
            // 
            this.btnImageToBase64.Location = new System.Drawing.Point(5, 93);
            this.btnImageToBase64.Name = "btnImageToBase64";
            this.btnImageToBase64.Size = new System.Drawing.Size(201, 24);
            this.btnImageToBase64.TabIndex = 2;
            this.btnImageToBase64.Text = "Convert to Base 64 ";
            this.btnImageToBase64.UseVisualStyleBackColor = true;
            this.btnImageToBase64.Visible = false;
            this.btnImageToBase64.Click += new System.EventHandler(this.btnImageToBase64_Click);
            // 
            // rtbConverterString
            // 
            this.rtbConverterString.Location = new System.Drawing.Point(5, 123);
            this.rtbConverterString.Name = "rtbConverterString";
            this.rtbConverterString.ReadOnly = true;
            this.rtbConverterString.Size = new System.Drawing.Size(967, 337);
            this.rtbConverterString.TabIndex = 3;
            this.rtbConverterString.Text = "";
            this.rtbConverterString.Visible = false;
            // 
            // cbHtml
            // 
            this.cbHtml.AutoSize = true;
            this.cbHtml.Location = new System.Drawing.Point(212, 96);
            this.cbHtml.Name = "cbHtml";
            this.cbHtml.Size = new System.Drawing.Size(127, 21);
            this.cbHtml.TabIndex = 4;
            this.cbHtml.Text = "Convert to Html";
            this.cbHtml.UseVisualStyleBackColor = true;
            this.cbHtml.Visible = false;
            // 
            // btnExportToHtml
            // 
            this.btnExportToHtml.Location = new System.Drawing.Point(770, 84);
            this.btnExportToHtml.Name = "btnExportToHtml";
            this.btnExportToHtml.Size = new System.Drawing.Size(202, 33);
            this.btnExportToHtml.TabIndex = 5;
            this.btnExportToHtml.Text = "Export to Html";
            this.btnExportToHtml.UseVisualStyleBackColor = true;
            this.btnExportToHtml.Click += new System.EventHandler(this.btnExportToHtml_Click);
            // 
            // frmSimpleConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 463);
            this.Controls.Add(this.btnExportToHtml);
            this.Controls.Add(this.cbHtml);
            this.Controls.Add(this.rtbConverterString);
            this.Controls.Add(this.btnImageToBase64);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "frmSimpleConverter";
            this.Text = "Simple String Converter";
            this.Load += new System.EventHandler(this.frmSimpleConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnImageToBase64;
        private System.Windows.Forms.RichTextBox rtbConverterString;
        private System.Windows.Forms.CheckBox cbHtml;
        private System.Windows.Forms.Button btnExportToHtml;
    }
}

