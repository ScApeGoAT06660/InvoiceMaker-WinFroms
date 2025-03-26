namespace InvoiceMaker
{
    partial class frmInvoice
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
            this.pnlMainAddInvoice = new System.Windows.Forms.Panel();
            this.flpMainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.gbHeadline = new System.Windows.Forms.GroupBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.gbEntityDetails = new System.Windows.Forms.GroupBox();
            this.gbBuyer = new System.Windows.Forms.GroupBox();
            this.cntrlBuyer = new InvoiceMaker.Controls.cntrlBuyer();
            this.gbSeller = new System.Windows.Forms.GroupBox();
            this.cntrlSeller = new InvoiceMaker.Controls.cntrlSeller();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.txtBruttoSummary = new System.Windows.Forms.TextBox();
            this.lblBruttoSummary = new System.Windows.Forms.Label();
            this.txtVATSummary = new System.Windows.Forms.TextBox();
            this.lblVATSummary = new System.Windows.Forms.Label();
            this.txtNettoSummary = new System.Windows.Forms.TextBox();
            this.lblNettoSummary = new System.Windows.Forms.Label();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.cbPaymentDeadline = new System.Windows.Forms.ComboBox();
            this.lblPaymentDeadline = new System.Windows.Forms.Label();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAddition = new System.Windows.Forms.GroupBox();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtBuyerSignature = new System.Windows.Forms.TextBox();
            this.lblBuyerSignature = new System.Windows.Forms.Label();
            this.txtSellerSignature = new System.Windows.Forms.TextBox();
            this.lblSellerSignature = new System.Windows.Forms.Label();
            this.pnlMainAddInvoice.SuspendLayout();
            this.flpMainContainer.SuspendLayout();
            this.gbHeadline.SuspendLayout();
            this.gbEntityDetails.SuspendLayout();
            this.gbBuyer.SuspendLayout();
            this.gbSeller.SuspendLayout();
            this.gbItems.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.gbAddition.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainAddInvoice
            // 
            this.pnlMainAddInvoice.AutoScroll = true;
            this.pnlMainAddInvoice.Controls.Add(this.flpMainContainer);
            this.pnlMainAddInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainAddInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlMainAddInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainAddInvoice.Name = "pnlMainAddInvoice";
            this.pnlMainAddInvoice.Size = new System.Drawing.Size(901, 973);
            this.pnlMainAddInvoice.TabIndex = 0;
            // 
            // flpMainContainer
            // 
            this.flpMainContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpMainContainer.AutoScroll = true;
            this.flpMainContainer.Controls.Add(this.gbHeadline);
            this.flpMainContainer.Controls.Add(this.gbEntityDetails);
            this.flpMainContainer.Controls.Add(this.gbItems);
            this.flpMainContainer.Controls.Add(this.gbAddition);
            this.flpMainContainer.Location = new System.Drawing.Point(3, 3);
            this.flpMainContainer.Name = "flpMainContainer";
            this.flpMainContainer.Size = new System.Drawing.Size(887, 965);
            this.flpMainContainer.TabIndex = 5;
            // 
            // gbHeadline
            // 
            this.gbHeadline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbHeadline.Controls.Add(this.txtPlace);
            this.gbHeadline.Controls.Add(this.lblPlace);
            this.gbHeadline.Controls.Add(this.dtpSaleDate);
            this.gbHeadline.Controls.Add(this.lblSaleDate);
            this.gbHeadline.Controls.Add(this.dtpIssueDate);
            this.gbHeadline.Controls.Add(this.lblIssueDate);
            this.gbHeadline.Controls.Add(this.txtInvoiceNo);
            this.gbHeadline.Controls.Add(this.lblInvoiceNo);
            this.gbHeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbHeadline.Location = new System.Drawing.Point(2, 2);
            this.gbHeadline.Margin = new System.Windows.Forms.Padding(2);
            this.gbHeadline.Name = "gbHeadline";
            this.gbHeadline.Padding = new System.Windows.Forms.Padding(2);
            this.gbHeadline.Size = new System.Drawing.Size(859, 92);
            this.gbHeadline.TabIndex = 0;
            this.gbHeadline.TabStop = false;
            this.gbHeadline.Text = "Nagłówek";
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlace.Location = new System.Drawing.Point(622, 51);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(214, 24);
            this.txtPlace.TabIndex = 7;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlace.Location = new System.Drawing.Point(622, 30);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(97, 17);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "Miejscowość";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDate.Location = new System.Drawing.Point(454, 53);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(162, 24);
            this.dtpSaleDate.TabIndex = 5;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSaleDate.Location = new System.Drawing.Point(451, 30);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(121, 17);
            this.lblSaleDate.TabIndex = 4;
            this.lblSaleDate.Text = "Data sprzedaży";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(280, 53);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(162, 24);
            this.dtpIssueDate.TabIndex = 3;
            this.dtpIssueDate.Value = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDate.Location = new System.Drawing.Point(277, 30);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(132, 17);
            this.lblIssueDate.TabIndex = 2;
            this.lblIssueDate.Text = "Data wystawienia";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(12, 51);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(262, 24);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(12, 30);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(55, 17);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Numer";
            // 
            // gbEntityDetails
            // 
            this.gbEntityDetails.Controls.Add(this.gbBuyer);
            this.gbEntityDetails.Controls.Add(this.gbSeller);
            this.gbEntityDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEntityDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbEntityDetails.Location = new System.Drawing.Point(2, 98);
            this.gbEntityDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbEntityDetails.Name = "gbEntityDetails";
            this.gbEntityDetails.Padding = new System.Windows.Forms.Padding(50, 2, 50, 10);
            this.gbEntityDetails.Size = new System.Drawing.Size(859, 407);
            this.gbEntityDetails.TabIndex = 1;
            this.gbEntityDetails.TabStop = false;
            this.gbEntityDetails.Text = "Dane podmiotów";
            // 
            // gbBuyer
            // 
            this.gbBuyer.Controls.Add(this.cntrlBuyer);
            this.gbBuyer.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbBuyer.ForeColor = System.Drawing.Color.Black;
            this.gbBuyer.Location = new System.Drawing.Point(463, 21);
            this.gbBuyer.Name = "gbBuyer";
            this.gbBuyer.Size = new System.Drawing.Size(346, 376);
            this.gbBuyer.TabIndex = 2;
            this.gbBuyer.TabStop = false;
            this.gbBuyer.Text = "Kupujący";
            // 
            // cntrlBuyer
            // 
            this.cntrlBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlBuyer.Location = new System.Drawing.Point(10, 24);
            this.cntrlBuyer.Name = "cntrlBuyer";
            this.cntrlBuyer.Size = new System.Drawing.Size(327, 330);
            this.cntrlBuyer.TabIndex = 0;
            // 
            // gbSeller
            // 
            this.gbSeller.Controls.Add(this.cntrlSeller);
            this.gbSeller.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSeller.ForeColor = System.Drawing.Color.Black;
            this.gbSeller.Location = new System.Drawing.Point(50, 21);
            this.gbSeller.Name = "gbSeller";
            this.gbSeller.Size = new System.Drawing.Size(346, 376);
            this.gbSeller.TabIndex = 1;
            this.gbSeller.TabStop = false;
            this.gbSeller.Text = "Sprzedawca";
            // 
            // cntrlSeller
            // 
            this.cntrlSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cntrlSeller.Location = new System.Drawing.Point(7, 25);
            this.cntrlSeller.Name = "cntrlSeller";
            this.cntrlSeller.Size = new System.Drawing.Size(333, 324);
            this.cntrlSeller.TabIndex = 0;
            // 
            // gbItems
            // 
            this.gbItems.Controls.Add(this.pnlSummary);
            this.gbItems.Controls.Add(this.gbPayment);
            this.gbItems.Controls.Add(this.btnAddItem);
            this.gbItems.Controls.Add(this.flpItems);
            this.gbItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbItems.Location = new System.Drawing.Point(2, 509);
            this.gbItems.Margin = new System.Windows.Forms.Padding(2);
            this.gbItems.Name = "gbItems";
            this.gbItems.Padding = new System.Windows.Forms.Padding(2);
            this.gbItems.Size = new System.Drawing.Size(859, 343);
            this.gbItems.TabIndex = 2;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Pozycje na fakturze";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.txtBruttoSummary);
            this.pnlSummary.Controls.Add(this.lblBruttoSummary);
            this.pnlSummary.Controls.Add(this.txtVATSummary);
            this.pnlSummary.Controls.Add(this.lblVATSummary);
            this.pnlSummary.Controls.Add(this.txtNettoSummary);
            this.pnlSummary.Controls.Add(this.lblNettoSummary);
            this.pnlSummary.Location = new System.Drawing.Point(602, 200);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(234, 128);
            this.pnlSummary.TabIndex = 3;
            // 
            // txtBruttoSummary
            // 
            this.txtBruttoSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBruttoSummary.Location = new System.Drawing.Point(93, 81);
            this.txtBruttoSummary.Name = "txtBruttoSummary";
            this.txtBruttoSummary.ReadOnly = true;
            this.txtBruttoSummary.Size = new System.Drawing.Size(119, 24);
            this.txtBruttoSummary.TabIndex = 8;
            // 
            // lblBruttoSummary
            // 
            this.lblBruttoSummary.AutoSize = true;
            this.lblBruttoSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBruttoSummary.Location = new System.Drawing.Point(23, 87);
            this.lblBruttoSummary.Name = "lblBruttoSummary";
            this.lblBruttoSummary.Size = new System.Drawing.Size(57, 17);
            this.lblBruttoSummary.TabIndex = 7;
            this.lblBruttoSummary.Text = "Brutto:";
            // 
            // txtVATSummary
            // 
            this.txtVATSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVATSummary.Location = new System.Drawing.Point(93, 49);
            this.txtVATSummary.Name = "txtVATSummary";
            this.txtVATSummary.ReadOnly = true;
            this.txtVATSummary.Size = new System.Drawing.Size(119, 24);
            this.txtVATSummary.TabIndex = 6;
            // 
            // lblVATSummary
            // 
            this.lblVATSummary.AutoSize = true;
            this.lblVATSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVATSummary.Location = new System.Drawing.Point(23, 55);
            this.lblVATSummary.Name = "lblVATSummary";
            this.lblVATSummary.Size = new System.Drawing.Size(43, 17);
            this.lblVATSummary.TabIndex = 5;
            this.lblVATSummary.Text = "VAT:";
            // 
            // txtNettoSummary
            // 
            this.txtNettoSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNettoSummary.Location = new System.Drawing.Point(93, 17);
            this.txtNettoSummary.Name = "txtNettoSummary";
            this.txtNettoSummary.ReadOnly = true;
            this.txtNettoSummary.Size = new System.Drawing.Size(119, 24);
            this.txtNettoSummary.TabIndex = 4;
            // 
            // lblNettoSummary
            // 
            this.lblNettoSummary.AutoSize = true;
            this.lblNettoSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNettoSummary.Location = new System.Drawing.Point(23, 23);
            this.lblNettoSummary.Name = "lblNettoSummary";
            this.lblNettoSummary.Size = new System.Drawing.Size(52, 17);
            this.lblNettoSummary.TabIndex = 3;
            this.lblNettoSummary.Text = "Netto:";
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.cbPaymentDeadline);
            this.gbPayment.Controls.Add(this.lblPaymentDeadline);
            this.gbPayment.Controls.Add(this.cbPaymentType);
            this.gbPayment.Controls.Add(this.lblPaymentType);
            this.gbPayment.Location = new System.Drawing.Point(12, 229);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(363, 99);
            this.gbPayment.TabIndex = 2;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Płatność";
            // 
            // cbPaymentDeadline
            // 
            this.cbPaymentDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPaymentDeadline.FormattingEnabled = true;
            this.cbPaymentDeadline.Items.AddRange(new object[] {
            "3 dni",
            "7 dni",
            "14 dni",
            "30 dni",
            "60 dni",
            "raty"});
            this.cbPaymentDeadline.Location = new System.Drawing.Point(183, 51);
            this.cbPaymentDeadline.Name = "cbPaymentDeadline";
            this.cbPaymentDeadline.Size = new System.Drawing.Size(164, 26);
            this.cbPaymentDeadline.TabIndex = 4;
            // 
            // lblPaymentDeadline
            // 
            this.lblPaymentDeadline.AutoSize = true;
            this.lblPaymentDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaymentDeadline.Location = new System.Drawing.Point(180, 31);
            this.lblPaymentDeadline.Name = "lblPaymentDeadline";
            this.lblPaymentDeadline.Size = new System.Drawing.Size(58, 17);
            this.lblPaymentDeadline.TabIndex = 3;
            this.lblPaymentDeadline.Text = "Termin";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "przelew bankowy",
            "gotówka",
            "gotówka przy odbiorze",
            "płatność za pobraniem",
            "zaliczka",
            "przedpłata",
            "karta",
            "paypal",
            "revolut",
            "BLIK"});
            this.cbPaymentType.Location = new System.Drawing.Point(13, 51);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(164, 26);
            this.cbPaymentType.TabIndex = 2;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaymentType.Location = new System.Drawing.Point(10, 31);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(61, 17);
            this.lblPaymentType.TabIndex = 1;
            this.lblPaymentType.Text = "Metoda";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddItem.Location = new System.Drawing.Point(25, 187);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(129, 36);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Dodaj pozycje";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // flpItems
            // 
            this.flpItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpItems.AutoScroll = true;
            this.flpItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flpItems.Location = new System.Drawing.Point(15, 24);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(824, 170);
            this.flpItems.TabIndex = 0;
            // 
            // gbAddition
            // 
            this.gbAddition.Controls.Add(this.btnEditInvoice);
            this.gbAddition.Controls.Add(this.btnDrop);
            this.gbAddition.Controls.Add(this.btnSave);
            this.gbAddition.Controls.Add(this.txtComment);
            this.gbAddition.Controls.Add(this.lblComment);
            this.gbAddition.Controls.Add(this.txtBuyerSignature);
            this.gbAddition.Controls.Add(this.lblBuyerSignature);
            this.gbAddition.Controls.Add(this.txtSellerSignature);
            this.gbAddition.Controls.Add(this.lblSellerSignature);
            this.gbAddition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAddition.Location = new System.Drawing.Point(2, 856);
            this.gbAddition.Margin = new System.Windows.Forms.Padding(2);
            this.gbAddition.Name = "gbAddition";
            this.gbAddition.Padding = new System.Windows.Forms.Padding(2);
            this.gbAddition.Size = new System.Drawing.Size(859, 218);
            this.gbAddition.TabIndex = 3;
            this.gbAddition.TabStop = false;
            this.gbAddition.Text = "Stopka";
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditInvoice.Location = new System.Drawing.Point(695, 116);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(129, 36);
            this.btnEditInvoice.TabIndex = 10;
            this.btnEditInvoice.Text = "Modyfikuj";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Visible = false;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDrop.Location = new System.Drawing.Point(695, 158);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(129, 36);
            this.btnDrop.TabIndex = 9;
            this.btnDrop.Text = "Anuluj";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(695, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtComment.Location = new System.Drawing.Point(12, 116);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(638, 90);
            this.txtComment.TabIndex = 7;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.Location = new System.Drawing.Point(12, 95);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 17);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Uwagi";
            // 
            // txtBuyerSignature
            // 
            this.txtBuyerSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBuyerSignature.Location = new System.Drawing.Point(286, 58);
            this.txtBuyerSignature.Name = "txtBuyerSignature";
            this.txtBuyerSignature.Size = new System.Drawing.Size(262, 24);
            this.txtBuyerSignature.TabIndex = 5;
            // 
            // lblBuyerSignature
            // 
            this.lblBuyerSignature.AutoSize = true;
            this.lblBuyerSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuyerSignature.Location = new System.Drawing.Point(286, 37);
            this.lblBuyerSignature.Name = "lblBuyerSignature";
            this.lblBuyerSignature.Size = new System.Drawing.Size(74, 17);
            this.lblBuyerSignature.TabIndex = 4;
            this.lblBuyerSignature.Text = "Odbiorca";
            // 
            // txtSellerSignature
            // 
            this.txtSellerSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSellerSignature.Location = new System.Drawing.Point(12, 58);
            this.txtSellerSignature.Name = "txtSellerSignature";
            this.txtSellerSignature.Size = new System.Drawing.Size(262, 24);
            this.txtSellerSignature.TabIndex = 3;
            // 
            // lblSellerSignature
            // 
            this.lblSellerSignature.AutoSize = true;
            this.lblSellerSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellerSignature.Location = new System.Drawing.Point(12, 37);
            this.lblSellerSignature.Name = "lblSellerSignature";
            this.lblSellerSignature.Size = new System.Drawing.Size(79, 17);
            this.lblSellerSignature.TabIndex = 2;
            this.lblSellerSignature.Text = "Wystawca";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 973);
            this.Controls.Add(this.pnlMainAddInvoice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoice";
            this.Text = "InvoiceForm";
            this.Resize += new System.EventHandler(this.frmInvoice_Resize);
            this.pnlMainAddInvoice.ResumeLayout(false);
            this.flpMainContainer.ResumeLayout(false);
            this.gbHeadline.ResumeLayout(false);
            this.gbHeadline.PerformLayout();
            this.gbEntityDetails.ResumeLayout(false);
            this.gbBuyer.ResumeLayout(false);
            this.gbSeller.ResumeLayout(false);
            this.gbItems.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.gbAddition.ResumeLayout(false);
            this.gbAddition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainAddInvoice;
        private System.Windows.Forms.GroupBox gbHeadline;
        private System.Windows.Forms.GroupBox gbEntityDetails;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.GroupBox gbAddition;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.GroupBox gbSeller;
        private Controls.cntrlSeller cntrlSeller;
       // private Controls.cntrlBuyer cntrlBuyer1;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.ComboBox cbPaymentDeadline;
        private System.Windows.Forms.Label lblPaymentDeadline;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.TextBox txtVATSummary;
        private System.Windows.Forms.Label lblVATSummary;
        private System.Windows.Forms.TextBox txtNettoSummary;
        private System.Windows.Forms.Label lblNettoSummary;
        private System.Windows.Forms.TextBox txtBruttoSummary;
        private System.Windows.Forms.Label lblBruttoSummary;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtBuyerSignature;
        private System.Windows.Forms.Label lblBuyerSignature;
        private System.Windows.Forms.TextBox txtSellerSignature;
        private System.Windows.Forms.Label lblSellerSignature;
        private System.Windows.Forms.FlowLayoutPanel flpMainContainer;
        //private Controls.cntrlBuyer cntrlBuyer;
        private System.Windows.Forms.GroupBox gbBuyer;
        private Controls.cntrlBuyer cntrlBuyer;
        private System.Windows.Forms.Button btnEditInvoice;
    }
}