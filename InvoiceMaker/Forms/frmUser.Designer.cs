namespace InvoiceMaker.Forms
{
    partial class frmUser
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
            this.cntrlSeller1 = new InvoiceMaker.Controls.cntrlSeller();
            this.btnSellerSave = new System.Windows.Forms.Button();
            this.btnSellerCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrlSeller1
            // 
            this.cntrlSeller1.Location = new System.Drawing.Point(3, 3);
            this.cntrlSeller1.Name = "cntrlSeller1";
            this.cntrlSeller1.Size = new System.Drawing.Size(333, 324);
            this.cntrlSeller1.TabIndex = 0;
            // 
            // btnSellerSave
            // 
            this.btnSellerSave.Location = new System.Drawing.Point(85, 333);
            this.btnSellerSave.Name = "btnSellerSave";
            this.btnSellerSave.Size = new System.Drawing.Size(75, 23);
            this.btnSellerSave.TabIndex = 3;
            this.btnSellerSave.Text = "Zapisz";
            this.btnSellerSave.UseVisualStyleBackColor = true;
            this.btnSellerSave.Click += new System.EventHandler(this.btnSellerSave_Click);
            // 
            // btnSellerCancel
            // 
            this.btnSellerCancel.Location = new System.Drawing.Point(166, 333);
            this.btnSellerCancel.Name = "btnSellerCancel";
            this.btnSellerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSellerCancel.TabIndex = 4;
            this.btnSellerCancel.Text = "Anuluj";
            this.btnSellerCancel.UseVisualStyleBackColor = true;
            this.btnSellerCancel.Click += new System.EventHandler(this.btnSellerCancel_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 370);
            this.Controls.Add(this.btnSellerCancel);
            this.Controls.Add(this.btnSellerSave);
            this.Controls.Add(this.cntrlSeller1);
            this.Name = "frmUser";
            this.Text = "Użytkownik";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.cntrlSeller cntrlSeller1;
        private System.Windows.Forms.Button btnSellerSave;
        private System.Windows.Forms.Button btnSellerCancel;
    }
}