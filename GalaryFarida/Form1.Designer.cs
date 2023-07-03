namespace GalaryFarida
{
    partial class AdminForm
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
            this.AdminTabs = new System.Windows.Forms.TabControl();
            this.AddProductTab = new System.Windows.Forms.TabPage();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.SellPriceTextBox = new System.Windows.Forms.TextBox();
            this.PiecePriceLable = new System.Windows.Forms.Label();
            this.BuyPriceTextBox = new System.Windows.Forms.TextBox();
            this.WholesalePriceLable = new System.Windows.Forms.Label();
            this.SupplierIdTextBox = new System.Windows.Forms.TextBox();
            this.SupplierLable = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLable = new System.Windows.Forms.Label();
            this.ProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ProductNumberLable = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProducNameLable = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ProducIdLable = new System.Windows.Forms.Label();
            this.SuppliersTab = new System.Windows.Forms.TabPage();
            this.DeleteSupplierButton = new System.Windows.Forms.Button();
            this.UpdateSupplierButton = new System.Windows.Forms.Button();
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.SupplierDataGrid = new System.Windows.Forms.DataGridView();
            this.DebitTextBox = new System.Windows.Forms.TextBox();
            this.DeptLable = new System.Windows.Forms.Label();
            this.CreditorTextBox = new System.Windows.Forms.TextBox();
            this.CreditorLable = new System.Windows.Forms.Label();
            this.SupplierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.SupplierPhoneLable = new System.Windows.Forms.Label();
            this.SupplierAddTextBox = new System.Windows.Forms.TextBox();
            this.SupplierAddLable = new System.Windows.Forms.Label();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.SupplierNameLable = new System.Windows.Forms.Label();
            this.SupplierIdLable1 = new System.Windows.Forms.Label();
            this.UnavailableTab = new System.Windows.Forms.TabPage();
            this.UnavilableButton = new System.Windows.Forms.Button();
            this.UnavailableDataGrid = new System.Windows.Forms.DataGridView();
            this.BillTab = new System.Windows.Forms.TabPage();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.BillDateLable = new System.Windows.Forms.Label();
            this.BillIdTextBox = new System.Windows.Forms.TextBox();
            this.BillIdLable = new System.Windows.Forms.Label();
            this.PrintBillButton = new System.Windows.Forms.Button();
            this.ShowBillButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.PrintReportButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.YearLable = new System.Windows.Forms.Label();
            this.MonthLable = new System.Windows.Forms.Label();
            this.DayLable = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CategoryTab = new System.Windows.Forms.TabPage();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.UpdateCategoryButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.CategoryDataGrid = new System.Windows.Forms.DataGridView();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameLable = new System.Windows.Forms.Label();
            this.CategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNumberLable = new System.Windows.Forms.Label();
            this.SupplierIdTextBox1 = new System.Windows.Forms.TextBox();
            this.UnavailableIdTextBox = new System.Windows.Forms.TextBox();
            this.UnavailableIdLabel = new System.Windows.Forms.Label();
            this.UnavailableDeleteButton = new System.Windows.Forms.Button();
            this.AdminTabs.SuspendLayout();
            this.AddProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.SuppliersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGrid)).BeginInit();
            this.UnavailableTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnavailableDataGrid)).BeginInit();
            this.BillTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.CategoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminTabs
            // 
            this.AdminTabs.AllowDrop = true;
            this.AdminTabs.Controls.Add(this.AddProductTab);
            this.AdminTabs.Controls.Add(this.SuppliersTab);
            this.AdminTabs.Controls.Add(this.UnavailableTab);
            this.AdminTabs.Controls.Add(this.BillTab);
            this.AdminTabs.Controls.Add(this.ReportTab);
            this.AdminTabs.Controls.Add(this.CategoryTab);
            this.AdminTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AdminTabs.ItemSize = new System.Drawing.Size(70, 18);
            this.AdminTabs.Location = new System.Drawing.Point(24, 24);
            this.AdminTabs.Margin = new System.Windows.Forms.Padding(15);
            this.AdminTabs.Name = "AdminTabs";
            this.AdminTabs.SelectedIndex = 0;
            this.AdminTabs.Size = new System.Drawing.Size(1234, 588);
            this.AdminTabs.TabIndex = 0;
            this.AdminTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.AdminTabs_Selected);
            // 
            // AddProductTab
            // 
            this.AddProductTab.BackColor = System.Drawing.Color.SteelBlue;
            this.AddProductTab.Controls.Add(this.DeleteProductButton);
            this.AddProductTab.Controls.Add(this.UpdateProductButton);
            this.AddProductTab.Controls.Add(this.AddProductButton);
            this.AddProductTab.Controls.Add(this.ProductDataGrid);
            this.AddProductTab.Controls.Add(this.SellPriceTextBox);
            this.AddProductTab.Controls.Add(this.PiecePriceLable);
            this.AddProductTab.Controls.Add(this.BuyPriceTextBox);
            this.AddProductTab.Controls.Add(this.WholesalePriceLable);
            this.AddProductTab.Controls.Add(this.SupplierIdTextBox);
            this.AddProductTab.Controls.Add(this.SupplierLable);
            this.AddProductTab.Controls.Add(this.CategoryTextBox);
            this.AddProductTab.Controls.Add(this.CategoryLable);
            this.AddProductTab.Controls.Add(this.ProductQuantityTextBox);
            this.AddProductTab.Controls.Add(this.ProductNumberLable);
            this.AddProductTab.Controls.Add(this.ProductNameTextBox);
            this.AddProductTab.Controls.Add(this.ProducNameLable);
            this.AddProductTab.Controls.Add(this.ProductIdTextBox);
            this.AddProductTab.Controls.Add(this.ProducIdLable);
            this.AddProductTab.Location = new System.Drawing.Point(4, 22);
            this.AddProductTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductTab.Name = "AddProductTab";
            this.AddProductTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductTab.Size = new System.Drawing.Size(1226, 562);
            this.AddProductTab.TabIndex = 0;
            this.AddProductTab.Text = "اضافة منتج";
            this.AddProductTab.Click += new System.EventHandler(this.AddProductTab_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(15, 494);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(15);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(112, 35);
            this.DeleteProductButton.TabIndex = 6;
            this.DeleteProductButton.Text = "حذف";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(278, 494);
            this.UpdateProductButton.Margin = new System.Windows.Forms.Padding(15);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(112, 35);
            this.UpdateProductButton.TabIndex = 7;
            this.UpdateProductButton.Text = "تعديل";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(530, 494);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(15);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(112, 35);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "اضافة";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Location = new System.Drawing.Point(9, 9);
            this.ProductDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.Size = new System.Drawing.Size(938, 462);
            this.ProductDataGrid.StandardTab = true;
            this.ProductDataGrid.TabIndex = 2;
            this.ProductDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGrid_CellContentClick);
            // 
            // SellPriceTextBox
            // 
            this.SellPriceTextBox.Location = new System.Drawing.Point(966, 420);
            this.SellPriceTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.SellPriceTextBox.Name = "SellPriceTextBox";
            this.SellPriceTextBox.Size = new System.Drawing.Size(148, 26);
            this.SellPriceTextBox.TabIndex = 1;
            // 
            // PiecePriceLable
            // 
            this.PiecePriceLable.AutoSize = true;
            this.PiecePriceLable.Location = new System.Drawing.Point(1118, 425);
            this.PiecePriceLable.Margin = new System.Windows.Forms.Padding(15);
            this.PiecePriceLable.Name = "PiecePriceLable";
            this.PiecePriceLable.Size = new System.Drawing.Size(78, 20);
            this.PiecePriceLable.TabIndex = 0;
            this.PiecePriceLable.Text = "سعر القطاعي";
            // 
            // BuyPriceTextBox
            // 
            this.BuyPriceTextBox.Location = new System.Drawing.Point(966, 359);
            this.BuyPriceTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.BuyPriceTextBox.Name = "BuyPriceTextBox";
            this.BuyPriceTextBox.Size = new System.Drawing.Size(148, 26);
            this.BuyPriceTextBox.TabIndex = 1;
            // 
            // WholesalePriceLable
            // 
            this.WholesalePriceLable.AutoSize = true;
            this.WholesalePriceLable.Location = new System.Drawing.Point(1134, 364);
            this.WholesalePriceLable.Margin = new System.Windows.Forms.Padding(15);
            this.WholesalePriceLable.Name = "WholesalePriceLable";
            this.WholesalePriceLable.Size = new System.Drawing.Size(66, 20);
            this.WholesalePriceLable.TabIndex = 0;
            this.WholesalePriceLable.Text = "سعر الجملة";
            // 
            // SupplierIdTextBox
            // 
            this.SupplierIdTextBox.Location = new System.Drawing.Point(966, 297);
            this.SupplierIdTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierIdTextBox.Name = "SupplierIdTextBox";
            this.SupplierIdTextBox.Size = new System.Drawing.Size(148, 26);
            this.SupplierIdTextBox.TabIndex = 1;
            // 
            // SupplierLable
            // 
            this.SupplierLable.AutoSize = true;
            this.SupplierLable.Location = new System.Drawing.Point(1146, 302);
            this.SupplierLable.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierLable.Name = "SupplierLable";
            this.SupplierLable.Size = new System.Drawing.Size(62, 20);
            this.SupplierLable.TabIndex = 0;
            this.SupplierLable.Text = "رقم المورد";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(966, 236);
            this.CategoryTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(148, 26);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // CategoryLable
            // 
            this.CategoryLable.AutoSize = true;
            this.CategoryLable.Location = new System.Drawing.Point(1136, 240);
            this.CategoryLable.Margin = new System.Windows.Forms.Padding(15);
            this.CategoryLable.Name = "CategoryLable";
            this.CategoryLable.Size = new System.Drawing.Size(69, 20);
            this.CategoryLable.TabIndex = 0;
            this.CategoryLable.Text = "اسم الصنف";
            // 
            // ProductQuantityTextBox
            // 
            this.ProductQuantityTextBox.Location = new System.Drawing.Point(966, 174);
            this.ProductQuantityTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            this.ProductQuantityTextBox.Size = new System.Drawing.Size(148, 26);
            this.ProductQuantityTextBox.TabIndex = 1;
            // 
            // ProductNumberLable
            // 
            this.ProductNumberLable.AutoSize = true;
            this.ProductNumberLable.Location = new System.Drawing.Point(1146, 179);
            this.ProductNumberLable.Margin = new System.Windows.Forms.Padding(15);
            this.ProductNumberLable.Name = "ProductNumberLable";
            this.ProductNumberLable.Size = new System.Drawing.Size(59, 20);
            this.ProductNumberLable.TabIndex = 0;
            this.ProductNumberLable.Text = "عدد القطع";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(966, 113);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.ProductNameTextBox.TabIndex = 1;
            // 
            // ProducNameLable
            // 
            this.ProducNameLable.AutoSize = true;
            this.ProducNameLable.Location = new System.Drawing.Point(1134, 117);
            this.ProducNameLable.Margin = new System.Windows.Forms.Padding(15);
            this.ProducNameLable.Name = "ProducNameLable";
            this.ProducNameLable.Size = new System.Drawing.Size(60, 20);
            this.ProducNameLable.TabIndex = 0;
            this.ProducNameLable.Text = "اسم المنتج";
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Enabled = false;
            this.ProductIdTextBox.Location = new System.Drawing.Point(966, 51);
            this.ProductIdTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.ReadOnly = true;
            this.ProductIdTextBox.Size = new System.Drawing.Size(148, 26);
            this.ProductIdTextBox.TabIndex = 1;
            // 
            // ProducIdLable
            // 
            this.ProducIdLable.AutoSize = true;
            this.ProducIdLable.Location = new System.Drawing.Point(1144, 56);
            this.ProducIdLable.Margin = new System.Windows.Forms.Padding(15);
            this.ProducIdLable.Name = "ProducIdLable";
            this.ProducIdLable.Size = new System.Drawing.Size(59, 20);
            this.ProducIdLable.TabIndex = 0;
            this.ProducIdLable.Text = "رقم المنتج";
            // 
            // SuppliersTab
            // 
            this.SuppliersTab.BackColor = System.Drawing.Color.SteelBlue;
            this.SuppliersTab.Controls.Add(this.SupplierIdTextBox1);
            this.SuppliersTab.Controls.Add(this.DeleteSupplierButton);
            this.SuppliersTab.Controls.Add(this.UpdateSupplierButton);
            this.SuppliersTab.Controls.Add(this.AddSupplierButton);
            this.SuppliersTab.Controls.Add(this.SupplierDataGrid);
            this.SuppliersTab.Controls.Add(this.DebitTextBox);
            this.SuppliersTab.Controls.Add(this.DeptLable);
            this.SuppliersTab.Controls.Add(this.CreditorTextBox);
            this.SuppliersTab.Controls.Add(this.CreditorLable);
            this.SuppliersTab.Controls.Add(this.SupplierPhoneTextBox);
            this.SuppliersTab.Controls.Add(this.SupplierPhoneLable);
            this.SuppliersTab.Controls.Add(this.SupplierAddTextBox);
            this.SuppliersTab.Controls.Add(this.SupplierAddLable);
            this.SuppliersTab.Controls.Add(this.SupplierNameTextBox);
            this.SuppliersTab.Controls.Add(this.SupplierNameLable);
            this.SuppliersTab.Controls.Add(this.SupplierIdLable1);
            this.SuppliersTab.Location = new System.Drawing.Point(4, 22);
            this.SuppliersTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTab.Name = "SuppliersTab";
            this.SuppliersTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTab.Size = new System.Drawing.Size(1226, 562);
            this.SuppliersTab.TabIndex = 1;
            this.SuppliersTab.Text = "الموردين";
            this.SuppliersTab.Click += new System.EventHandler(this.SuppliersTab_Click);
            // 
            // DeleteSupplierButton
            // 
            this.DeleteSupplierButton.Location = new System.Drawing.Point(20, 494);
            this.DeleteSupplierButton.Margin = new System.Windows.Forms.Padding(15);
            this.DeleteSupplierButton.Name = "DeleteSupplierButton";
            this.DeleteSupplierButton.Size = new System.Drawing.Size(112, 35);
            this.DeleteSupplierButton.TabIndex = 5;
            this.DeleteSupplierButton.Text = "حذف";
            this.DeleteSupplierButton.UseVisualStyleBackColor = true;
            this.DeleteSupplierButton.Click += new System.EventHandler(this.DeleteSupplierButton_Click);
            // 
            // UpdateSupplierButton
            // 
            this.UpdateSupplierButton.Location = new System.Drawing.Point(282, 494);
            this.UpdateSupplierButton.Margin = new System.Windows.Forms.Padding(15);
            this.UpdateSupplierButton.Name = "UpdateSupplierButton";
            this.UpdateSupplierButton.Size = new System.Drawing.Size(112, 35);
            this.UpdateSupplierButton.TabIndex = 5;
            this.UpdateSupplierButton.Text = "تعديل";
            this.UpdateSupplierButton.UseVisualStyleBackColor = true;
            this.UpdateSupplierButton.Click += new System.EventHandler(this.UpdateSupplierButton_Click);
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.Location = new System.Drawing.Point(534, 494);
            this.AddSupplierButton.Margin = new System.Windows.Forms.Padding(15);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(112, 35);
            this.AddSupplierButton.TabIndex = 5;
            this.AddSupplierButton.Text = "اضافة";
            this.AddSupplierButton.UseVisualStyleBackColor = true;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // SupplierDataGrid
            // 
            this.SupplierDataGrid.AllowUserToOrderColumns = true;
            this.SupplierDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SupplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDataGrid.Location = new System.Drawing.Point(9, 15);
            this.SupplierDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupplierDataGrid.Name = "SupplierDataGrid";
            this.SupplierDataGrid.ReadOnly = true;
            this.SupplierDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierDataGrid.Size = new System.Drawing.Size(929, 462);
            this.SupplierDataGrid.TabIndex = 4;
            this.SupplierDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierDataGrid_CellContentClick);
            // 
            // DebitTextBox
            // 
            this.DebitTextBox.Location = new System.Drawing.Point(957, 381);
            this.DebitTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.DebitTextBox.Name = "DebitTextBox";
            this.DebitTextBox.Size = new System.Drawing.Size(148, 26);
            this.DebitTextBox.TabIndex = 3;
            // 
            // DeptLable
            // 
            this.DeptLable.AutoSize = true;
            this.DeptLable.Location = new System.Drawing.Point(1176, 387);
            this.DeptLable.Margin = new System.Windows.Forms.Padding(15);
            this.DeptLable.Name = "DeptLable";
            this.DeptLable.Size = new System.Drawing.Size(31, 20);
            this.DeptLable.TabIndex = 2;
            this.DeptLable.Text = "مدين";
            // 
            // CreditorTextBox
            // 
            this.CreditorTextBox.Location = new System.Drawing.Point(957, 320);
            this.CreditorTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.CreditorTextBox.Name = "CreditorTextBox";
            this.CreditorTextBox.Size = new System.Drawing.Size(148, 26);
            this.CreditorTextBox.TabIndex = 3;
            // 
            // CreditorLable
            // 
            this.CreditorLable.AutoSize = true;
            this.CreditorLable.Location = new System.Drawing.Point(1177, 323);
            this.CreditorLable.Margin = new System.Windows.Forms.Padding(15);
            this.CreditorLable.Name = "CreditorLable";
            this.CreditorLable.Size = new System.Drawing.Size(30, 20);
            this.CreditorLable.TabIndex = 2;
            this.CreditorLable.Text = "دائن";
            // 
            // SupplierPhoneTextBox
            // 
            this.SupplierPhoneTextBox.Location = new System.Drawing.Point(957, 258);
            this.SupplierPhoneTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierPhoneTextBox.Name = "SupplierPhoneTextBox";
            this.SupplierPhoneTextBox.Size = new System.Drawing.Size(148, 26);
            this.SupplierPhoneTextBox.TabIndex = 3;
            // 
            // SupplierPhoneLable
            // 
            this.SupplierPhoneLable.AutoSize = true;
            this.SupplierPhoneLable.Location = new System.Drawing.Point(1143, 263);
            this.SupplierPhoneLable.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierPhoneLable.Name = "SupplierPhoneLable";
            this.SupplierPhoneLable.Size = new System.Drawing.Size(64, 20);
            this.SupplierPhoneLable.TabIndex = 2;
            this.SupplierPhoneLable.Text = "رقم الهاتف";
            // 
            // SupplierAddTextBox
            // 
            this.SupplierAddTextBox.Location = new System.Drawing.Point(957, 196);
            this.SupplierAddTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierAddTextBox.Name = "SupplierAddTextBox";
            this.SupplierAddTextBox.Size = new System.Drawing.Size(148, 26);
            this.SupplierAddTextBox.TabIndex = 3;
            // 
            // SupplierAddLable
            // 
            this.SupplierAddLable.AutoSize = true;
            this.SupplierAddLable.Location = new System.Drawing.Point(1131, 201);
            this.SupplierAddLable.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierAddLable.Name = "SupplierAddLable";
            this.SupplierAddLable.Size = new System.Drawing.Size(76, 20);
            this.SupplierAddLable.TabIndex = 2;
            this.SupplierAddLable.Text = "عنوان المورد";
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Location = new System.Drawing.Point(957, 135);
            this.SupplierNameTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.SupplierNameTextBox.TabIndex = 3;
            // 
            // SupplierNameLable
            // 
            this.SupplierNameLable.AutoSize = true;
            this.SupplierNameLable.Location = new System.Drawing.Point(1137, 140);
            this.SupplierNameLable.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierNameLable.Name = "SupplierNameLable";
            this.SupplierNameLable.Size = new System.Drawing.Size(63, 20);
            this.SupplierNameLable.TabIndex = 2;
            this.SupplierNameLable.Text = "اسم المورد";
            // 
            // SupplierIdLable1
            // 
            this.SupplierIdLable1.AutoSize = true;
            this.SupplierIdLable1.Location = new System.Drawing.Point(1145, 73);
            this.SupplierIdLable1.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierIdLable1.Name = "SupplierIdLable1";
            this.SupplierIdLable1.Size = new System.Drawing.Size(62, 20);
            this.SupplierIdLable1.TabIndex = 2;
            this.SupplierIdLable1.Text = "رقم المورد";
            // 
            // UnavailableTab
            // 
            this.UnavailableTab.BackColor = System.Drawing.Color.SteelBlue;
            this.UnavailableTab.Controls.Add(this.UnavailableDeleteButton);
            this.UnavailableTab.Controls.Add(this.UnavailableIdLabel);
            this.UnavailableTab.Controls.Add(this.UnavailableIdTextBox);
            this.UnavailableTab.Controls.Add(this.UnavilableButton);
            this.UnavailableTab.Controls.Add(this.UnavailableDataGrid);
            this.UnavailableTab.Location = new System.Drawing.Point(4, 22);
            this.UnavailableTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnavailableTab.Name = "UnavailableTab";
            this.UnavailableTab.Size = new System.Drawing.Size(1226, 562);
            this.UnavailableTab.TabIndex = 2;
            this.UnavailableTab.Text = "الغير متاح";
            this.UnavailableTab.Click += new System.EventHandler(this.UnavailableTab_Click);
            // 
            // UnavilableButton
            // 
            this.UnavilableButton.Location = new System.Drawing.Point(268, 28);
            this.UnavilableButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnavilableButton.Name = "UnavilableButton";
            this.UnavilableButton.Size = new System.Drawing.Size(112, 35);
            this.UnavilableButton.TabIndex = 4;
            this.UnavilableButton.Text = "الغير متاح";
            this.UnavilableButton.UseVisualStyleBackColor = true;
            this.UnavilableButton.Click += new System.EventHandler(this.UnavilableButton_Click);
            // 
            // UnavailableDataGrid
            // 
            this.UnavailableDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.UnavailableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnavailableDataGrid.Location = new System.Drawing.Point(15, 83);
            this.UnavailableDataGrid.Margin = new System.Windows.Forms.Padding(15);
            this.UnavailableDataGrid.Name = "UnavailableDataGrid";
            this.UnavailableDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnavailableDataGrid.Size = new System.Drawing.Size(636, 451);
            this.UnavailableDataGrid.TabIndex = 3;
            this.UnavailableDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnavilableDateGrid_CellContentClick);
            // 
            // BillTab
            // 
            this.BillTab.BackColor = System.Drawing.Color.SteelBlue;
            this.BillTab.Controls.Add(this.BillDate);
            this.BillTab.Controls.Add(this.BillDateLable);
            this.BillTab.Controls.Add(this.BillIdTextBox);
            this.BillTab.Controls.Add(this.BillIdLable);
            this.BillTab.Controls.Add(this.PrintBillButton);
            this.BillTab.Controls.Add(this.ShowBillButton);
            this.BillTab.Controls.Add(this.dataGridView1);
            this.BillTab.Location = new System.Drawing.Point(4, 22);
            this.BillTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillTab.Name = "BillTab";
            this.BillTab.Size = new System.Drawing.Size(1226, 562);
            this.BillTab.TabIndex = 3;
            this.BillTab.Text = "فواتير";
            // 
            // BillDate
            // 
            this.BillDate.Location = new System.Drawing.Point(171, 88);
            this.BillDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(298, 26);
            this.BillDate.TabIndex = 11;
            // 
            // BillDateLable
            // 
            this.BillDateLable.AutoSize = true;
            this.BillDateLable.Location = new System.Drawing.Point(490, 92);
            this.BillDateLable.Margin = new System.Windows.Forms.Padding(15);
            this.BillDateLable.Name = "BillDateLable";
            this.BillDateLable.Size = new System.Drawing.Size(82, 20);
            this.BillDateLable.TabIndex = 7;
            this.BillDateLable.Text = "تاريخ الفاتورة";
            // 
            // BillIdTextBox
            // 
            this.BillIdTextBox.Location = new System.Drawing.Point(171, 26);
            this.BillIdTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.BillIdTextBox.Name = "BillIdTextBox";
            this.BillIdTextBox.Size = new System.Drawing.Size(298, 26);
            this.BillIdTextBox.TabIndex = 10;
            // 
            // BillIdLable
            // 
            this.BillIdLable.AutoSize = true;
            this.BillIdLable.Location = new System.Drawing.Point(483, 31);
            this.BillIdLable.Margin = new System.Windows.Forms.Padding(15);
            this.BillIdLable.Name = "BillIdLable";
            this.BillIdLable.Size = new System.Drawing.Size(70, 20);
            this.BillIdLable.TabIndex = 8;
            this.BillIdLable.Text = "رقم الفاتورة";
            this.BillIdLable.Click += new System.EventHandler(this.BillIdLable_Click);
            // 
            // PrintBillButton
            // 
            this.PrintBillButton.Location = new System.Drawing.Point(242, 483);
            this.PrintBillButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintBillButton.Name = "PrintBillButton";
            this.PrintBillButton.Size = new System.Drawing.Size(142, 35);
            this.PrintBillButton.TabIndex = 6;
            this.PrintBillButton.Text = "طباعة الفاتورة";
            this.PrintBillButton.UseVisualStyleBackColor = true;
            // 
            // ShowBillButton
            // 
            this.ShowBillButton.Location = new System.Drawing.Point(28, 54);
            this.ShowBillButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowBillButton.Name = "ShowBillButton";
            this.ShowBillButton.Size = new System.Drawing.Size(112, 35);
            this.ShowBillButton.TabIndex = 6;
            this.ShowBillButton.Text = "عرض الفاتورة";
            this.ShowBillButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 325);
            this.dataGridView1.TabIndex = 5;
            // 
            // ReportTab
            // 
            this.ReportTab.BackColor = System.Drawing.Color.SteelBlue;
            this.ReportTab.Controls.Add(this.PrintReportButton);
            this.ReportTab.Controls.Add(this.dataGridView2);
            this.ReportTab.Controls.Add(this.YearLable);
            this.ReportTab.Controls.Add(this.MonthLable);
            this.ReportTab.Controls.Add(this.DayLable);
            this.ReportTab.Controls.Add(this.comboBox2);
            this.ReportTab.Controls.Add(this.comboBox3);
            this.ReportTab.Controls.Add(this.comboBox1);
            this.ReportTab.Location = new System.Drawing.Point(4, 22);
            this.ReportTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Size = new System.Drawing.Size(1226, 562);
            this.ReportTab.TabIndex = 4;
            this.ReportTab.Text = "تقارير";
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.Location = new System.Drawing.Point(246, 497);
            this.PrintReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.Size = new System.Drawing.Size(142, 35);
            this.PrintReportButton.TabIndex = 7;
            this.PrintReportButton.Text = "طباعة التقرير";
            this.PrintReportButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 72);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(636, 405);
            this.dataGridView2.TabIndex = 4;
            // 
            // YearLable
            // 
            this.YearLable.AutoSize = true;
            this.YearLable.Location = new System.Drawing.Point(176, 37);
            this.YearLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLable.Name = "YearLable";
            this.YearLable.Size = new System.Drawing.Size(29, 20);
            this.YearLable.TabIndex = 1;
            this.YearLable.Text = "سنة";
            // 
            // MonthLable
            // 
            this.MonthLable.AutoSize = true;
            this.MonthLable.Location = new System.Drawing.Point(372, 37);
            this.MonthLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthLable.Name = "MonthLable";
            this.MonthLable.Size = new System.Drawing.Size(32, 20);
            this.MonthLable.TabIndex = 1;
            this.MonthLable.Text = "شهر";
            // 
            // DayLable
            // 
            this.DayLable.AutoSize = true;
            this.DayLable.Location = new System.Drawing.Point(590, 37);
            this.DayLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DayLable.Name = "DayLable";
            this.DayLable.Size = new System.Drawing.Size(25, 20);
            this.DayLable.TabIndex = 1;
            this.DayLable.Text = "يوم";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(309, 32);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070"});
            this.comboBox3.Location = new System.Drawing.Point(54, 32);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(110, 28);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1.Location = new System.Drawing.Point(526, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // CategoryTab
            // 
            this.CategoryTab.BackColor = System.Drawing.Color.SteelBlue;
            this.CategoryTab.Controls.Add(this.DeleteCategoryButton);
            this.CategoryTab.Controls.Add(this.UpdateCategoryButton);
            this.CategoryTab.Controls.Add(this.AddCategoryButton);
            this.CategoryTab.Controls.Add(this.CategoryDataGrid);
            this.CategoryTab.Controls.Add(this.CategoryNameTextBox);
            this.CategoryTab.Controls.Add(this.CategoryNameLable);
            this.CategoryTab.Controls.Add(this.CategoryIdTextBox);
            this.CategoryTab.Controls.Add(this.CategoryNumberLable);
            this.CategoryTab.Location = new System.Drawing.Point(4, 22);
            this.CategoryTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryTab.Name = "CategoryTab";
            this.CategoryTab.Size = new System.Drawing.Size(1226, 562);
            this.CategoryTab.TabIndex = 5;
            this.CategoryTab.Text = "اضافة اصناف";
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Location = new System.Drawing.Point(468, 248);
            this.DeleteCategoryButton.Margin = new System.Windows.Forms.Padding(15);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(112, 35);
            this.DeleteCategoryButton.TabIndex = 8;
            this.DeleteCategoryButton.Text = "حذف";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // UpdateCategoryButton
            // 
            this.UpdateCategoryButton.Location = new System.Drawing.Point(392, 182);
            this.UpdateCategoryButton.Margin = new System.Windows.Forms.Padding(15);
            this.UpdateCategoryButton.Name = "UpdateCategoryButton";
            this.UpdateCategoryButton.Size = new System.Drawing.Size(112, 35);
            this.UpdateCategoryButton.TabIndex = 9;
            this.UpdateCategoryButton.Text = "تعديل";
            this.UpdateCategoryButton.UseVisualStyleBackColor = true;
            this.UpdateCategoryButton.Click += new System.EventHandler(this.UpdateCategoryButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(538, 182);
            this.AddCategoryButton.Margin = new System.Windows.Forms.Padding(15);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(112, 35);
            this.AddCategoryButton.TabIndex = 10;
            this.AddCategoryButton.Text = "اضافة";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CategoryDataGrid
            // 
            this.CategoryDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CategoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGrid.Location = new System.Drawing.Point(10, 43);
            this.CategoryDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryDataGrid.Name = "CategoryDataGrid";
            this.CategoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryDataGrid.Size = new System.Drawing.Size(366, 400);
            this.CategoryDataGrid.TabIndex = 7;
            this.CategoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryDataGrid_CellContentClick);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(396, 105);
            this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.CategoryNameTextBox.TabIndex = 5;
            // 
            // CategoryNameLable
            // 
            this.CategoryNameLable.AutoSize = true;
            this.CategoryNameLable.Location = new System.Drawing.Point(564, 109);
            this.CategoryNameLable.Margin = new System.Windows.Forms.Padding(15);
            this.CategoryNameLable.Name = "CategoryNameLable";
            this.CategoryNameLable.Size = new System.Drawing.Size(69, 20);
            this.CategoryNameLable.TabIndex = 3;
            this.CategoryNameLable.Text = "اسم الصنف";
            // 
            // CategoryIdTextBox
            // 
            this.CategoryIdTextBox.Enabled = false;
            this.CategoryIdTextBox.Location = new System.Drawing.Point(396, 43);
            this.CategoryIdTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.CategoryIdTextBox.Name = "CategoryIdTextBox";
            this.CategoryIdTextBox.ReadOnly = true;
            this.CategoryIdTextBox.Size = new System.Drawing.Size(148, 26);
            this.CategoryIdTextBox.TabIndex = 6;
            // 
            // CategoryNumberLable
            // 
            this.CategoryNumberLable.AutoSize = true;
            this.CategoryNumberLable.Location = new System.Drawing.Point(573, 48);
            this.CategoryNumberLable.Margin = new System.Windows.Forms.Padding(15);
            this.CategoryNumberLable.Name = "CategoryNumberLable";
            this.CategoryNumberLable.Size = new System.Drawing.Size(68, 20);
            this.CategoryNumberLable.TabIndex = 4;
            this.CategoryNumberLable.Text = "رقم الصنف";
            // 
            // SupplierIdTextBox1
            // 
            this.SupplierIdTextBox1.Enabled = false;
            this.SupplierIdTextBox1.Location = new System.Drawing.Point(957, 67);
            this.SupplierIdTextBox1.Margin = new System.Windows.Forms.Padding(15);
            this.SupplierIdTextBox1.Name = "SupplierIdTextBox1";
            this.SupplierIdTextBox1.ReadOnly = true;
            this.SupplierIdTextBox1.Size = new System.Drawing.Size(148, 26);
            this.SupplierIdTextBox1.TabIndex = 6;
            // 
            // UnavailableIdTextBox
            // 
            this.UnavailableIdTextBox.Enabled = false;
            this.UnavailableIdTextBox.Location = new System.Drawing.Point(696, 89);
            this.UnavailableIdTextBox.Name = "UnavailableIdTextBox";
            this.UnavailableIdTextBox.ReadOnly = true;
            this.UnavailableIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.UnavailableIdTextBox.TabIndex = 5;
            // 
            // UnavailableIdLabel
            // 
            this.UnavailableIdLabel.AutoSize = true;
            this.UnavailableIdLabel.Location = new System.Drawing.Point(865, 92);
            this.UnavailableIdLabel.Name = "UnavailableIdLabel";
            this.UnavailableIdLabel.Size = new System.Drawing.Size(59, 20);
            this.UnavailableIdLabel.TabIndex = 6;
            this.UnavailableIdLabel.Text = "رقم المنتج";
            // 
            // UnavailableDeleteButton
            // 
            this.UnavailableDeleteButton.Location = new System.Drawing.Point(779, 212);
            this.UnavailableDeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnavailableDeleteButton.Name = "UnavailableDeleteButton";
            this.UnavailableDeleteButton.Size = new System.Drawing.Size(112, 35);
            this.UnavailableDeleteButton.TabIndex = 7;
            this.UnavailableDeleteButton.Text = "حذف";
            this.UnavailableDeleteButton.UseVisualStyleBackColor = true;
            this.UnavailableDeleteButton.Click += new System.EventHandler(this.UnavailableDeleteButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1282, 636);
            this.Controls.Add(this.AdminTabs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AddProductTab_Click);
            this.AdminTabs.ResumeLayout(false);
            this.AddProductTab.ResumeLayout(false);
            this.AddProductTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.SuppliersTab.ResumeLayout(false);
            this.SuppliersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGrid)).EndInit();
            this.UnavailableTab.ResumeLayout(false);
            this.UnavailableTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnavailableDataGrid)).EndInit();
            this.BillTab.ResumeLayout(false);
            this.BillTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ReportTab.ResumeLayout(false);
            this.ReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.CategoryTab.ResumeLayout(false);
            this.CategoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTabs;
        private System.Windows.Forms.TabPage AddProductTab;
        private System.Windows.Forms.TabPage SuppliersTab;
        private System.Windows.Forms.TabPage UnavailableTab;
        private System.Windows.Forms.TabPage BillTab;
        private System.Windows.Forms.TabPage ReportTab;
        private System.Windows.Forms.TabPage CategoryTab;
        private System.Windows.Forms.TextBox SupplierIdTextBox;
        private System.Windows.Forms.Label SupplierLable;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLable;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.Label ProducIdLable;
        private System.Windows.Forms.TextBox SellPriceTextBox;
        private System.Windows.Forms.Label PiecePriceLable;
        private System.Windows.Forms.TextBox BuyPriceTextBox;
        private System.Windows.Forms.Label WholesalePriceLable;
        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.TextBox ProductQuantityTextBox;
        private System.Windows.Forms.Label ProductNumberLable;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProducNameLable;
        private System.Windows.Forms.TextBox CreditorTextBox;
        private System.Windows.Forms.Label CreditorLable;
        private System.Windows.Forms.TextBox SupplierPhoneTextBox;
        private System.Windows.Forms.Label SupplierPhoneLable;
        private System.Windows.Forms.TextBox SupplierAddTextBox;
        private System.Windows.Forms.Label SupplierAddLable;
        private System.Windows.Forms.TextBox SupplierNameTextBox;
        private System.Windows.Forms.Label SupplierNameLable;
        private System.Windows.Forms.Label SupplierIdLable1;
        private System.Windows.Forms.TextBox DebitTextBox;
        private System.Windows.Forms.Label DeptLable;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteSupplierButton;
        private System.Windows.Forms.Button UpdateSupplierButton;
        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.DataGridView SupplierDataGrid;
        private System.Windows.Forms.Button UnavilableButton;
        private System.Windows.Forms.DataGridView UnavailableDataGrid;
        private System.Windows.Forms.DateTimePicker BillDate;
        private System.Windows.Forms.Label BillDateLable;
        private System.Windows.Forms.TextBox BillIdTextBox;
        private System.Windows.Forms.Label BillIdLable;
        private System.Windows.Forms.Button ShowBillButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrintBillButton;
        private System.Windows.Forms.Button PrintReportButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label YearLable;
        private System.Windows.Forms.Label MonthLable;
        private System.Windows.Forms.Label DayLable;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.Button UpdateCategoryButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.DataGridView CategoryDataGrid;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label CategoryNameLable;
        private System.Windows.Forms.TextBox CategoryIdTextBox;
        private System.Windows.Forms.Label CategoryNumberLable;
        private System.Windows.Forms.TextBox SupplierIdTextBox1;
        private System.Windows.Forms.Label UnavailableIdLabel;
        private System.Windows.Forms.TextBox UnavailableIdTextBox;
        private System.Windows.Forms.Button UnavailableDeleteButton;
    }
}

