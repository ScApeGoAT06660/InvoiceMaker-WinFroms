namespace InvoiceMaker.Controls
{
    partial class cntrlBuyer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.txtVATID = new System.Windows.Forms.TextBox();
            this.lblVATID = new System.Windows.Forms.Label();
            this.txtStreetAndNo = new System.Windows.Forms.TextBox();
            this.lblStreetAndNo = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.rbBusinessType = new System.Windows.Forms.RadioButton();
            this.rbPrivatePersonType = new System.Windows.Forms.RadioButton();
            this.btnGUS = new System.Windows.Forms.Button();
            this.pbTraderListButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraderListButton)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(12, 77);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(304, 20);
            this.txtBuyerName.TabIndex = 3;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuyer.Location = new System.Drawing.Point(9, 57);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(72, 17);
            this.lblBuyer.TabIndex = 2;
            this.lblBuyer.Text = "Nabywca";
            // 
            // txtVATID
            // 
            this.txtVATID.Location = new System.Drawing.Point(12, 127);
            this.txtVATID.Name = "txtVATID";
            this.txtVATID.Size = new System.Drawing.Size(304, 20);
            this.txtVATID.TabIndex = 5;
            this.txtVATID.Text = "5261040828";
            this.txtVATID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVATID_KeyDown);
            // 
            // lblVATID
            // 
            this.lblVATID.AutoSize = true;
            this.lblVATID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVATID.Location = new System.Drawing.Point(9, 107);
            this.lblVATID.Name = "lblVATID";
            this.lblVATID.Size = new System.Drawing.Size(33, 17);
            this.lblVATID.TabIndex = 4;
            this.lblVATID.Text = "NIP";
            // 
            // txtStreetAndNo
            // 
            this.txtStreetAndNo.Location = new System.Drawing.Point(12, 182);
            this.txtStreetAndNo.Name = "txtStreetAndNo";
            this.txtStreetAndNo.Size = new System.Drawing.Size(304, 20);
            this.txtStreetAndNo.TabIndex = 7;
            // 
            // lblStreetAndNo
            // 
            this.lblStreetAndNo.AutoSize = true;
            this.lblStreetAndNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreetAndNo.Location = new System.Drawing.Point(9, 162);
            this.lblStreetAndNo.Name = "lblStreetAndNo";
            this.lblStreetAndNo.Size = new System.Drawing.Size(73, 17);
            this.lblStreetAndNo.TabIndex = 6;
            this.lblStreetAndNo.Text = "Ulica i nr";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(13, 235);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(107, 20);
            this.txtPostcode.TabIndex = 9;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostcode.Location = new System.Drawing.Point(10, 214);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(107, 17);
            this.lblPostcode.TabIndex = 8;
            this.lblPostcode.Text = "Kod pocztowy";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 235);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 20);
            this.txtCity.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(123, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(97, 17);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "Miejscowość";
            // 
            // rbBusinessType
            // 
            this.rbBusinessType.AutoSize = true;
            this.rbBusinessType.Checked = true;
            this.rbBusinessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbBusinessType.Location = new System.Drawing.Point(13, 17);
            this.rbBusinessType.Name = "rbBusinessType";
            this.rbBusinessType.Size = new System.Drawing.Size(57, 19);
            this.rbBusinessType.TabIndex = 12;
            this.rbBusinessType.TabStop = true;
            this.rbBusinessType.Text = "Firma";
            this.rbBusinessType.UseVisualStyleBackColor = true;
            // 
            // rbPrivatePersonType
            // 
            this.rbPrivatePersonType.AutoSize = true;
            this.rbPrivatePersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPrivatePersonType.Location = new System.Drawing.Point(92, 17);
            this.rbPrivatePersonType.Name = "rbPrivatePersonType";
            this.rbPrivatePersonType.Size = new System.Drawing.Size(113, 19);
            this.rbPrivatePersonType.TabIndex = 13;
            this.rbPrivatePersonType.TabStop = true;
            this.rbPrivatePersonType.Text = "Osoba prywatna";
            this.rbPrivatePersonType.UseVisualStyleBackColor = true;
            this.rbPrivatePersonType.CheckedChanged += new System.EventHandler(this.rbPrivatePersonType_CheckedChanged);
            // 
            // btnGUS
            // 
            this.btnGUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGUS.Location = new System.Drawing.Point(51, 275);
            this.btnGUS.Name = "btnGUS";
            this.btnGUS.Size = new System.Drawing.Size(69, 32);
            this.btnGUS.TabIndex = 15;
            this.btnGUS.Text = "GUS";
            this.btnGUS.UseVisualStyleBackColor = true;
            this.btnGUS.Click += new System.EventHandler(this.btnGUS_Click);
            // 
            // pbTraderListButton
            // 
            this.pbTraderListButton.Image = global::InvoiceMaker.Properties.Resources.user;
            this.pbTraderListButton.Location = new System.Drawing.Point(13, 275);
            this.pbTraderListButton.Name = "pbTraderListButton";
            this.pbTraderListButton.Size = new System.Drawing.Size(32, 32);
            this.pbTraderListButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTraderListButton.TabIndex = 14;
            this.pbTraderListButton.TabStop = false;
            this.pbTraderListButton.Click += new System.EventHandler(this.pbTraderListButton_Click);
            // 
            // cntrlBuyer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.btnGUS);
            this.Controls.Add(this.pbTraderListButton);
            this.Controls.Add(this.rbPrivatePersonType);
            this.Controls.Add(this.rbBusinessType);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtStreetAndNo);
            this.Controls.Add(this.lblStreetAndNo);
            this.Controls.Add(this.txtVATID);
            this.Controls.Add(this.lblVATID);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.lblBuyer);
            this.Name = "cntrlBuyer";
            this.Size = new System.Drawing.Size(327, 330);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraderListButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.TextBox txtVATID;
        private System.Windows.Forms.Label lblVATID;
        private System.Windows.Forms.TextBox txtStreetAndNo;
        private System.Windows.Forms.Label lblStreetAndNo;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.RadioButton rbBusinessType;
        private System.Windows.Forms.RadioButton rbPrivatePersonType;
        private System.Windows.Forms.PictureBox pbTraderListButton;
        private System.Windows.Forms.Button btnGUS;
    }
}
