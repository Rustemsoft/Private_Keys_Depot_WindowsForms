
namespace Private_Keys_Depot_WindowsForms
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerificate = new System.Windows.Forms.Button();
            this.cbxAlg = new System.Windows.Forms.ComboBox();
            this.btnGetKeys = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbxPsw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxDescr = new System.Windows.Forms.TextBox();
            this.btnUpdKey = new System.Windows.Forms.Button();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnCheckKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxKey = new System.Windows.Forms.TextBox();
            this.btnDropKey = new System.Windows.Forms.Button();
            this.btnGetKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxKeyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxCertificateIV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(591, 177);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCerificate);
            this.panel1.Controls.Add(this.cbxAlg);
            this.panel1.Controls.Add(this.btnGetKeys);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbxPsw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbxDescr);
            this.panel1.Controls.Add(this.btnUpdKey);
            this.panel1.Controls.Add(this.btnAddKey);
            this.panel1.Controls.Add(this.btnCheckKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbxKey);
            this.panel1.Controls.Add(this.btnDropKey);
            this.panel1.Controls.Add(this.btnGetKey);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbxKeyName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbxCertificateIV);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 118);
            this.panel1.TabIndex = 6;
            // 
            // btnCerificate
            // 
            this.btnCerificate.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerificate.Location = new System.Drawing.Point(502, 87);
            this.btnCerificate.Name = "btnCerificate";
            this.btnCerificate.Size = new System.Drawing.Size(60, 23);
            this.btnCerificate.TabIndex = 24;
            this.btnCerificate.Text = "Cerificate";
            this.btnCerificate.UseVisualStyleBackColor = true;
            this.btnCerificate.Click += new System.EventHandler(this.btnCerificate_Click);
            // 
            // cbxAlg
            // 
            this.cbxAlg.FormattingEnabled = true;
            this.cbxAlg.Location = new System.Drawing.Point(376, 57);
            this.cbxAlg.Name = "cbxAlg";
            this.cbxAlg.Size = new System.Drawing.Size(169, 21);
            this.cbxAlg.TabIndex = 23;
            // 
            // btnGetKeys
            // 
            this.btnGetKeys.Location = new System.Drawing.Point(6, 87);
            this.btnGetKeys.Name = "btnGetKeys";
            this.btnGetKeys.Size = new System.Drawing.Size(75, 23);
            this.btnGetKeys.TabIndex = 22;
            this.btnGetKeys.Text = "Get All Keys";
            this.btnGetKeys.UseVisualStyleBackColor = true;
            this.btnGetKeys.Click += new System.EventHandler(this.btnGetKeys_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Crypto Algorithm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Crypto Password:";
            // 
            // txbxPsw
            // 
            this.txbxPsw.Location = new System.Drawing.Point(375, 32);
            this.txbxPsw.Name = "txbxPsw";
            this.txbxPsw.Size = new System.Drawing.Size(170, 20);
            this.txbxPsw.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Description:";
            // 
            // txbxDescr
            // 
            this.txbxDescr.Location = new System.Drawing.Point(375, 8);
            this.txbxDescr.Name = "txbxDescr";
            this.txbxDescr.Size = new System.Drawing.Size(170, 20);
            this.txbxDescr.TabIndex = 16;
            // 
            // btnUpdKey
            // 
            this.btnUpdKey.Location = new System.Drawing.Point(338, 87);
            this.btnUpdKey.Name = "btnUpdKey";
            this.btnUpdKey.Size = new System.Drawing.Size(75, 23);
            this.btnUpdKey.TabIndex = 15;
            this.btnUpdKey.Text = "Update Key";
            this.btnUpdKey.UseVisualStyleBackColor = true;
            this.btnUpdKey.Click += new System.EventHandler(this.btnUpdKey_Click);
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(421, 87);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(75, 23);
            this.btnAddKey.TabIndex = 14;
            this.btnAddKey.Text = "Create Key";
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // btnCheckKey
            // 
            this.btnCheckKey.Location = new System.Drawing.Point(172, 87);
            this.btnCheckKey.Name = "btnCheckKey";
            this.btnCheckKey.Size = new System.Drawing.Size(75, 23);
            this.btnCheckKey.TabIndex = 13;
            this.btnCheckKey.Text = "Check Key";
            this.btnCheckKey.UseVisualStyleBackColor = true;
            this.btnCheckKey.Click += new System.EventHandler(this.btnCheckKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Key:";
            // 
            // txbxKey
            // 
            this.txbxKey.Location = new System.Drawing.Point(88, 57);
            this.txbxKey.Name = "txbxKey";
            this.txbxKey.Size = new System.Drawing.Size(187, 20);
            this.txbxKey.TabIndex = 11;
            // 
            // btnDropKey
            // 
            this.btnDropKey.Location = new System.Drawing.Point(255, 87);
            this.btnDropKey.Name = "btnDropKey";
            this.btnDropKey.Size = new System.Drawing.Size(75, 23);
            this.btnDropKey.TabIndex = 10;
            this.btnDropKey.Text = "Drop Key";
            this.btnDropKey.UseVisualStyleBackColor = true;
            this.btnDropKey.Click += new System.EventHandler(this.btnDropKey_Click);
            // 
            // btnGetKey
            // 
            this.btnGetKey.Location = new System.Drawing.Point(89, 87);
            this.btnGetKey.Name = "btnGetKey";
            this.btnGetKey.Size = new System.Drawing.Size(75, 23);
            this.btnGetKey.TabIndex = 9;
            this.btnGetKey.Text = "Get Key";
            this.btnGetKey.UseVisualStyleBackColor = true;
            this.btnGetKey.Click += new System.EventHandler(this.btnGetKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key Name:";
            // 
            // txbxKeyName
            // 
            this.txbxKeyName.Location = new System.Drawing.Point(88, 32);
            this.txbxKeyName.Name = "txbxKeyName";
            this.txbxKeyName.Size = new System.Drawing.Size(187, 20);
            this.txbxKeyName.TabIndex = 7;
            this.txbxKeyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbxKeyName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Certificate IV:";
            // 
            // txbxCertificateIV
            // 
            this.txbxCertificateIV.Location = new System.Drawing.Point(88, 8);
            this.txbxCertificateIV.Name = "txbxCertificateIV";
            this.txbxCertificateIV.Size = new System.Drawing.Size(187, 20);
            this.txbxCertificateIV.TabIndex = 5;
            this.txbxCertificateIV.Text = "DEMO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skater Private Keys Depot View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxKeyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxCertificateIV;
        private System.Windows.Forms.Button btnDropKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxKey;
        private System.Windows.Forms.Button btnCheckKey;
        private System.Windows.Forms.Button btnUpdKey;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxPsw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxDescr;
        private System.Windows.Forms.Button btnGetKeys;
        private System.Windows.Forms.ComboBox cbxAlg;
        private System.Windows.Forms.Button btnCerificate;
    }
}

