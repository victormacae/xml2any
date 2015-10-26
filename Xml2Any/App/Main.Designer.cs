namespace App
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.openXml = new System.Windows.Forms.OpenFileDialog();
            this.txtXmlFileName = new System.Windows.Forms.TextBox();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXslFileName = new System.Windows.Forms.TextBox();
            this.btnLoadXsl = new System.Windows.Forms.Button();
            this.openXsl = new System.Windows.Forms.OpenFileDialog();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openXml
            // 
            this.openXml.DefaultExt = "xml";
            this.openXml.FileName = "openXml";
            this.openXml.Filter = "XML Files|*.xml";
            // 
            // txtXmlFileName
            // 
            this.txtXmlFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXmlFileName.Location = new System.Drawing.Point(48, 12);
            this.txtXmlFileName.Name = "txtXmlFileName";
            this.txtXmlFileName.Size = new System.Drawing.Size(515, 20);
            this.txtXmlFileName.TabIndex = 1;
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadXml.Location = new System.Drawing.Point(569, 11);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(75, 22);
            this.btnLoadXml.TabIndex = 2;
            this.btnLoadXml.Text = "Load";
            this.btnLoadXml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "XSL:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtXslFileName
            // 
            this.txtXslFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXslFileName.Location = new System.Drawing.Point(48, 38);
            this.txtXslFileName.Name = "txtXslFileName";
            this.txtXslFileName.Size = new System.Drawing.Size(515, 20);
            this.txtXslFileName.TabIndex = 4;
            // 
            // btnLoadXsl
            // 
            this.btnLoadXsl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadXsl.Location = new System.Drawing.Point(569, 38);
            this.btnLoadXsl.Name = "btnLoadXsl";
            this.btnLoadXsl.Size = new System.Drawing.Size(75, 22);
            this.btnLoadXsl.TabIndex = 5;
            this.btnLoadXsl.Text = "Load";
            this.btnLoadXsl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadXsl.UseVisualStyleBackColor = true;
            this.btnLoadXsl.Click += new System.EventHandler(this.btnLoadXsl_Click);
            // 
            // openXsl
            // 
            this.openXsl.DefaultExt = "xsl;xslt";
            this.openXsl.FileName = "openXsl";
            this.openXsl.Filter = "XSL(T) Files|*.xsl;*.xslt";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutput.Location = new System.Drawing.Point(21, 123);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(623, 353);
            this.txtOutput.TabIndex = 6;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(18, 73);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(626, 32);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "EXECUTE TRANSFORMATION";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 488);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnLoadXsl);
            this.Controls.Add(this.txtXslFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.txtXmlFileName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(674, 527);
            this.Name = "Main";
            this.Text = "Xml 2 Any";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openXml;
        private System.Windows.Forms.TextBox txtXmlFileName;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXslFileName;
        private System.Windows.Forms.Button btnLoadXsl;
        private System.Windows.Forms.OpenFileDialog openXsl;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnExecute;
    }
}

