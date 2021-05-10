
namespace Project_Maintenance_Lab3
{
    partial class frmNewProduct
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.ProductCodeTxt = new System.Windows.Forms.TextBox();
            this.VersionTxt = new System.Windows.Forms.TextBox();
            this.ReleaseDateTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 24);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(83, 15);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Product Code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(22, 93);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Version:";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(22, 128);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(76, 15);
            this.lblRelease.TabIndex = 0;
            this.lblRelease.Text = "Release Date:";
            // 
            // ProductCodeTxt
            // 
            this.ProductCodeTxt.Location = new System.Drawing.Point(111, 21);
            this.ProductCodeTxt.Name = "ProductCodeTxt";
            this.ProductCodeTxt.Size = new System.Drawing.Size(100, 23);
            this.ProductCodeTxt.TabIndex = 1;
            this.ProductCodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ProductCodeTxt_Validating);
            // 
            // VersionTxt
            // 
            this.VersionTxt.Location = new System.Drawing.Point(111, 90);
            this.VersionTxt.Name = "VersionTxt";
            this.VersionTxt.Size = new System.Drawing.Size(100, 23);
            this.VersionTxt.TabIndex = 1;
            this.VersionTxt.Validating += new System.ComponentModel.CancelEventHandler(this.VersionTxt_Validating);
            // 
            // ReleaseDateTxt
            // 
            this.ReleaseDateTxt.Location = new System.Drawing.Point(111, 125);
            this.ReleaseDateTxt.Name = "ReleaseDateTxt";
            this.ReleaseDateTxt.Size = new System.Drawing.Size(100, 23);
            this.ReleaseDateTxt.TabIndex = 1;
            this.ReleaseDateTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ReleaseDateTxt_Validating);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(111, 56);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 23);
            this.NameTxt.TabIndex = 1;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(94, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 352);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ReleaseDateTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.VersionTxt);
            this.Controls.Add(this.ProductCodeTxt);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Name = "frmNewProduct";
            this.Text = "Add or Modify Product";
            this.Load += new System.EventHandler(this.frmNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.TextBox ProductCodeTxt;
        private System.Windows.Forms.TextBox VersionTxt;
        private System.Windows.Forms.TextBox ReleaseDateTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}