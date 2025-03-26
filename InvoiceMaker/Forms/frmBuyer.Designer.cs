namespace InvoiceMaker.Forms
{
    partial class frmBuyer
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
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnBuyerCancel = new System.Windows.Forms.Button();
            this.btnSaveBuyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(88, 335);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 7;
            this.btnSaveEdit.Text = "Modyfikuj";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnBuyerCancel
            // 
            this.btnBuyerCancel.Location = new System.Drawing.Point(169, 335);
            this.btnBuyerCancel.Name = "btnBuyerCancel";
            this.btnBuyerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBuyerCancel.TabIndex = 6;
            this.btnBuyerCancel.Text = "Anuluj";
            this.btnBuyerCancel.UseVisualStyleBackColor = true;
            this.btnBuyerCancel.Click += new System.EventHandler(this.btnBuyerCancel_Click);
            // 
            // btnSaveBuyer
            // 
            this.btnSaveBuyer.Location = new System.Drawing.Point(88, 335);
            this.btnSaveBuyer.Name = "btnSaveBuyer";
            this.btnSaveBuyer.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBuyer.TabIndex = 8;
            this.btnSaveBuyer.Text = "Zapisz";
            this.btnSaveBuyer.UseVisualStyleBackColor = true;
            this.btnSaveBuyer.Visible = false;
            this.btnSaveBuyer.Click += new System.EventHandler(this.btnSaveBuyer_Click);
            // 
            // frmBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 370);
            this.Controls.Add(this.btnSaveBuyer);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.btnBuyerCancel);
            this.Name = "frmBuyer";
            this.Text = "frmEditBuyer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnBuyerCancel;
        private System.Windows.Forms.Button btnSaveBuyer;
    }
}