namespace help_about
{
    partial class Help_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Form));
            this.wbrHelp = new System.Windows.Forms.WebBrowser();
            this.btn_close = new System.Windows.Forms.Button();
            this.comVisibleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fileVersionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assemblyVersionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnk_lbl_jetbrains = new System.Windows.Forms.LinkLabel();
            this.lnklbl_licence = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbrHelp
            // 
            this.wbrHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrHelp.Location = new System.Drawing.Point(3, 4);
            this.wbrHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wbrHelp.MinimumSize = new System.Drawing.Size(22, 25);
            this.wbrHelp.Name = "wbrHelp";
            this.wbrHelp.Size = new System.Drawing.Size(762, 442);
            this.wbrHelp.TabIndex = 135;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(655, 242);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 62);
            this.btn_close.TabIndex = 134;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // comVisibleTextBox
            // 
            this.comVisibleTextBox.Location = new System.Drawing.Point(129, 269);
            this.comVisibleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comVisibleTextBox.Name = "comVisibleTextBox";
            this.comVisibleTextBox.ReadOnly = true;
            this.comVisibleTextBox.Size = new System.Drawing.Size(178, 26);
            this.comVisibleTextBox.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 275);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 132;
            this.label11.Text = "COM Visible:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 130;
            this.label9.Text = "Licence:";
            // 
            // guidTextBox
            // 
            this.guidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guidTextBox.Location = new System.Drawing.Point(129, 195);
            this.guidTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.ReadOnly = true;
            this.guidTextBox.Size = new System.Drawing.Size(614, 26);
            this.guidTextBox.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 128;
            this.label10.Text = "GUID:";
            // 
            // fileVersionTextBox
            // 
            this.fileVersionTextBox.Location = new System.Drawing.Point(129, 232);
            this.fileVersionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileVersionTextBox.Name = "fileVersionTextBox";
            this.fileVersionTextBox.ReadOnly = true;
            this.fileVersionTextBox.Size = new System.Drawing.Size(178, 26);
            this.fileVersionTextBox.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 126;
            this.label5.Text = "File Version:";
            // 
            // assemblyVersionTextBox
            // 
            this.assemblyVersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assemblyVersionTextBox.Location = new System.Drawing.Point(466, 232);
            this.assemblyVersionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.assemblyVersionTextBox.Name = "assemblyVersionTextBox";
            this.assemblyVersionTextBox.ReadOnly = true;
            this.assemblyVersionTextBox.Size = new System.Drawing.Size(178, 26);
            this.assemblyVersionTextBox.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 124;
            this.label6.Text = "Assembly Version:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 122;
            this.label7.Text = "Kudos:";
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightTextBox.Location = new System.Drawing.Point(129, 120);
            this.copyrightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.ReadOnly = true;
            this.copyrightTextBox.Size = new System.Drawing.Size(614, 26);
            this.copyrightTextBox.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 120;
            this.label8.Text = "Copyright:";
            // 
            // productTextBox
            // 
            this.productTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productTextBox.Location = new System.Drawing.Point(129, 82);
            this.productTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(614, 26);
            this.productTextBox.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 118;
            this.label3.Text = "Product:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyTextBox.Location = new System.Drawing.Point(129, 45);
            this.companyTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.ReadOnly = true;
            this.companyTextBox.Size = new System.Drawing.Size(614, 26);
            this.companyTextBox.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Company:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(129, 8);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(614, 26);
            this.descriptionTextBox.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Description:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.wbrHelp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 770);
            this.tableLayoutPanel1.TabIndex = 136;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnklbl_licence);
            this.panel1.Controls.Add(this.lnk_lbl_jetbrains);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comVisibleTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fileVersionTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.companyTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.productTextBox);
            this.panel1.Controls.Add(this.copyrightTextBox);
            this.panel1.Controls.Add(this.assemblyVersionTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.guidTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 454);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 312);
            this.panel1.TabIndex = 136;
            // 
            // lnk_lbl_jetbrains
            // 
            this.lnk_lbl_jetbrains.AutoSize = true;
            this.lnk_lbl_jetbrains.Location = new System.Drawing.Point(125, 161);
            this.lnk_lbl_jetbrains.Name = "lnk_lbl_jetbrains";
            this.lnk_lbl_jetbrains.Size = new System.Drawing.Size(601, 20);
            this.lnk_lbl_jetbrains.TabIndex = 135;
            this.lnk_lbl_jetbrains.TabStop = true;
            this.lnk_lbl_jetbrains.Text = "Built using Jetbrains - Thanks for granting me a free licence for my opensource w" +
    "ork.";
            this.lnk_lbl_jetbrains.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lbl_jetbrains_LinkClicked);
            // 
            // lnklbl_licence
            // 
            this.lnklbl_licence.AutoSize = true;
            this.lnklbl_licence.Location = new System.Drawing.Point(392, 275);
            this.lnklbl_licence.Name = "lnklbl_licence";
            this.lnklbl_licence.Size = new System.Drawing.Size(244, 20);
            this.lnklbl_licence.TabIndex = 136;
            this.lnklbl_licence.TabStop = true;
            this.lnklbl_licence.Text = "GNU General Public License v2.0";
            this.lnklbl_licence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_licence_LinkClicked);
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 770);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Help_Form";
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Help_Form_FormClosing);
            this.Load += new System.EventHandler(this.Help_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser wbrHelp;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox comVisibleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fileVersionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox assemblyVersionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox copyrightTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnk_lbl_jetbrains;
        private System.Windows.Forms.LinkLabel lnklbl_licence;
    }
}