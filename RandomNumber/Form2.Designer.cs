namespace RandomNumber
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Company = new System.Windows.Forms.Label();
            this.CompanyThing = new System.Windows.Forms.Label();
            this.Web = new System.Windows.Forms.Label();
            this.WebThing = new System.Windows.Forms.Label();
            this.Versionlabel = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(103, 54);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(59, 12);
            this.Company.TabIndex = 0;
            this.Company.Text = "(Company)";
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // CompanyThing
            // 
            this.CompanyThing.AutoSize = true;
            this.CompanyThing.Location = new System.Drawing.Point(44, 54);
            this.CompanyThing.Name = "CompanyThing";
            this.CompanyThing.Size = new System.Drawing.Size(53, 12);
            this.CompanyThing.TabIndex = 1;
            this.CompanyThing.Text = "Company:";
            // 
            // Web
            // 
            this.Web.AutoSize = true;
            this.Web.Location = new System.Drawing.Point(44, 104);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(29, 12);
            this.Web.TabIndex = 2;
            this.Web.Text = "Web:";
            // 
            // WebThing
            // 
            this.WebThing.AutoSize = true;
            this.WebThing.Location = new System.Drawing.Point(103, 104);
            this.WebThing.Name = "WebThing";
            this.WebThing.Size = new System.Drawing.Size(179, 12);
            this.WebThing.TabIndex = 3;
            this.WebThing.Text = "https://github.com/TeackReais";
            // 
            // Versionlabel
            // 
            this.Versionlabel.AutoSize = true;
            this.Versionlabel.Location = new System.Drawing.Point(44, 154);
            this.Versionlabel.Name = "Versionlabel";
            this.Versionlabel.Size = new System.Drawing.Size(53, 12);
            this.Versionlabel.TabIndex = 4;
            this.Versionlabel.Text = "Version:";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(103, 154);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(59, 12);
            this.Version.TabIndex = 5;
            this.Version.Text = "(Version)";
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Versionlabel);
            this.Controls.Add(this.WebThing);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.CompanyThing);
            this.Controls.Add(this.Company);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label CompanyThing;
        private System.Windows.Forms.Label Web;
        private System.Windows.Forms.Label WebThing;
        private System.Windows.Forms.Label Versionlabel;
        private System.Windows.Forms.Label Version;
    }
}