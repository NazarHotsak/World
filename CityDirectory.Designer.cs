namespace World
{
    partial class CityDirectory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityDirectory));
            this.workspace = new System.Windows.Forms.Panel();
            this.panelSettlement = new System.Windows.Forms.Panel();
            this.labelSettlement = new System.Windows.Forms.Label();
            this.panelActionSettlement = new System.Windows.Forms.Panel();
            this.searchSettlement = new System.Windows.Forms.TextBox();
            this.selectTypeSettlement = new System.Windows.Forms.ComboBox();
            this.addSettlement = new System.Windows.Forms.Button();
            this.removeSettlement = new System.Windows.Forms.Button();
            this.dataSettlementsDirectory = new System.Windows.Forms.DataGridView();
            this.panelDistrict = new System.Windows.Forms.Panel();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.panelActionDistrict = new System.Windows.Forms.Panel();
            this.SearchDistrict = new System.Windows.Forms.TextBox();
            this.addDistrict = new System.Windows.Forms.Button();
            this.removeDistrict = new System.Windows.Forms.Button();
            this.dataDistrictsDirectory = new System.Windows.Forms.DataGridView();
            this.panelRegion = new System.Windows.Forms.Panel();
            this.labelRegion = new System.Windows.Forms.Label();
            this.panelActionRegion = new System.Windows.Forms.Panel();
            this.searchRegion = new System.Windows.Forms.TextBox();
            this.addRegion = new System.Windows.Forms.Button();
            this.removeRegion = new System.Windows.Forms.Button();
            this.dataRegionsDirectory = new System.Windows.Forms.DataGridView();
            this.panelCountry = new System.Windows.Forms.Panel();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.panelActionCountry = new System.Windows.Forms.Panel();
            this.searchCountry = new System.Windows.Forms.TextBox();
            this.addCountry = new System.Windows.Forms.Button();
            this.removeCountry = new System.Windows.Forms.Button();
            this.dataCountriesDirectory = new System.Windows.Forms.DataGridView();
            this.cross = new System.Windows.Forms.PictureBox();
            this.applicationName = new System.Windows.Forms.Label();
            this.workspace.SuspendLayout();
            this.panelSettlement.SuspendLayout();
            this.panelActionSettlement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSettlementsDirectory)).BeginInit();
            this.panelDistrict.SuspendLayout();
            this.panelActionDistrict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDistrictsDirectory)).BeginInit();
            this.panelRegion.SuspendLayout();
            this.panelActionRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegionsDirectory)).BeginInit();
            this.panelCountry.SuspendLayout();
            this.panelActionCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCountriesDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            this.SuspendLayout();
            // 
            // workspace
            // 
            this.workspace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.workspace.Controls.Add(this.panelSettlement);
            this.workspace.Controls.Add(this.panelDistrict);
            this.workspace.Controls.Add(this.panelRegion);
            this.workspace.Controls.Add(this.panelCountry);
            this.workspace.Location = new System.Drawing.Point(1, 25);
            this.workspace.Margin = new System.Windows.Forms.Padding(1, 25, 1, 1);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(898, 624);
            this.workspace.TabIndex = 0;
            // 
            // panelSettlement
            // 
            this.panelSettlement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettlement.Controls.Add(this.labelSettlement);
            this.panelSettlement.Controls.Add(this.panelActionSettlement);
            this.panelSettlement.Controls.Add(this.dataSettlementsDirectory);
            this.panelSettlement.Location = new System.Drawing.Point(647, 10);
            this.panelSettlement.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.panelSettlement.Name = "panelSettlement";
            this.panelSettlement.Size = new System.Drawing.Size(240, 604);
            this.panelSettlement.TabIndex = 9;
            // 
            // labelSettlement
            // 
            this.labelSettlement.AutoSize = true;
            this.labelSettlement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelSettlement.Location = new System.Drawing.Point(56, 7);
            this.labelSettlement.Name = "labelSettlement";
            this.labelSettlement.Size = new System.Drawing.Size(128, 20);
            this.labelSettlement.TabIndex = 2;
            this.labelSettlement.Text = "Населений пункт";
            // 
            // panelActionSettlement
            // 
            this.panelActionSettlement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionSettlement.Controls.Add(this.searchSettlement);
            this.panelActionSettlement.Controls.Add(this.selectTypeSettlement);
            this.panelActionSettlement.Controls.Add(this.addSettlement);
            this.panelActionSettlement.Controls.Add(this.removeSettlement);
            this.panelActionSettlement.Location = new System.Drawing.Point(2, 532);
            this.panelActionSettlement.Name = "panelActionSettlement";
            this.panelActionSettlement.Size = new System.Drawing.Size(234, 68);
            this.panelActionSettlement.TabIndex = 6;
            // 
            // searchSettlement
            // 
            this.searchSettlement.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchSettlement.Location = new System.Drawing.Point(60, 6);
            this.searchSettlement.MaxLength = 100;
            this.searchSettlement.Name = "searchSettlement";
            this.searchSettlement.Size = new System.Drawing.Size(167, 23);
            this.searchSettlement.TabIndex = 4;
            this.searchSettlement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSettlement_KeyDown);
            // 
            // selectTypeSettlement
            // 
            this.selectTypeSettlement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectTypeSettlement.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTypeSettlement.FormattingEnabled = true;
            this.selectTypeSettlement.Location = new System.Drawing.Point(5, 6);
            this.selectTypeSettlement.Margin = new System.Windows.Forms.Padding(0);
            this.selectTypeSettlement.Name = "selectTypeSettlement";
            this.selectTypeSettlement.Size = new System.Drawing.Size(50, 23);
            this.selectTypeSettlement.TabIndex = 7;
            this.selectTypeSettlement.SelectedIndexChanged += new System.EventHandler(this.SelectedTypeSettlement_SelectedIndexChanged);
            // 
            // addSettlement
            // 
            this.addSettlement.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSettlement.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSettlement.Location = new System.Drawing.Point(155, 39);
            this.addSettlement.Name = "addSettlement";
            this.addSettlement.Size = new System.Drawing.Size(72, 22);
            this.addSettlement.TabIndex = 3;
            this.addSettlement.Text = "Додати";
            this.addSettlement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addSettlement.UseVisualStyleBackColor = true;
            this.addSettlement.Click += new System.EventHandler(this.AddSettlementIntoDirectory_Click);
            // 
            // removeSettlement
            // 
            this.removeSettlement.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeSettlement.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSettlement.Location = new System.Drawing.Point(4, 39);
            this.removeSettlement.Name = "removeSettlement";
            this.removeSettlement.Size = new System.Drawing.Size(72, 22);
            this.removeSettlement.TabIndex = 5;
            this.removeSettlement.Text = "Удалити";
            this.removeSettlement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeSettlement.UseVisualStyleBackColor = true;
            this.removeSettlement.Click += new System.EventHandler(this.RemoveSettlement_Click);
            // 
            // dataSettlementsDirectory
            // 
            this.dataSettlementsDirectory.AllowUserToAddRows = false;
            this.dataSettlementsDirectory.AllowUserToDeleteRows = false;
            this.dataSettlementsDirectory.AllowUserToResizeColumns = false;
            this.dataSettlementsDirectory.AllowUserToResizeRows = false;
            this.dataSettlementsDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSettlementsDirectory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataSettlementsDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSettlementsDirectory.ColumnHeadersVisible = false;
            this.dataSettlementsDirectory.Location = new System.Drawing.Point(2, 30);
            this.dataSettlementsDirectory.MultiSelect = false;
            this.dataSettlementsDirectory.Name = "dataSettlementsDirectory";
            this.dataSettlementsDirectory.ReadOnly = true;
            this.dataSettlementsDirectory.RowHeadersVisible = false;
            this.dataSettlementsDirectory.RowHeadersWidth = 51;
            this.dataSettlementsDirectory.RowTemplate.Height = 29;
            this.dataSettlementsDirectory.Size = new System.Drawing.Size(234, 400);
            this.dataSettlementsDirectory.TabIndex = 0;
            // 
            // panelDistrict
            // 
            this.panelDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDistrict.Controls.Add(this.labelDistrict);
            this.panelDistrict.Controls.Add(this.panelActionDistrict);
            this.panelDistrict.Controls.Add(this.dataDistrictsDirectory);
            this.panelDistrict.Location = new System.Drawing.Point(425, 10);
            this.panelDistrict.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.panelDistrict.Name = "panelDistrict";
            this.panelDistrict.Size = new System.Drawing.Size(216, 604);
            this.panelDistrict.TabIndex = 8;
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelDistrict.Location = new System.Drawing.Point(81, 7);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(52, 20);
            this.labelDistrict.TabIndex = 2;
            this.labelDistrict.Text = "Район";
            // 
            // panelActionDistrict
            // 
            this.panelActionDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionDistrict.Controls.Add(this.SearchDistrict);
            this.panelActionDistrict.Controls.Add(this.addDistrict);
            this.panelActionDistrict.Controls.Add(this.removeDistrict);
            this.panelActionDistrict.Location = new System.Drawing.Point(2, 532);
            this.panelActionDistrict.Name = "panelActionDistrict";
            this.panelActionDistrict.Size = new System.Drawing.Size(210, 68);
            this.panelActionDistrict.TabIndex = 6;
            // 
            // SearchDistrict
            // 
            this.SearchDistrict.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchDistrict.Location = new System.Drawing.Point(5, 6);
            this.SearchDistrict.MaxLength = 100;
            this.SearchDistrict.Name = "SearchDistrict";
            this.SearchDistrict.Size = new System.Drawing.Size(198, 23);
            this.SearchDistrict.TabIndex = 4;
            this.SearchDistrict.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchDistrict_KeyDown);
            // 
            // addDistrict
            // 
            this.addDistrict.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDistrict.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addDistrict.Location = new System.Drawing.Point(131, 39);
            this.addDistrict.Name = "addDistrict";
            this.addDistrict.Size = new System.Drawing.Size(72, 22);
            this.addDistrict.TabIndex = 3;
            this.addDistrict.Text = "Додати";
            this.addDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDistrict.UseVisualStyleBackColor = true;
            this.addDistrict.Click += new System.EventHandler(this.AddDistrictIntoDirectory_Click);
            // 
            // removeDistrict
            // 
            this.removeDistrict.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeDistrict.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeDistrict.Location = new System.Drawing.Point(4, 39);
            this.removeDistrict.Name = "removeDistrict";
            this.removeDistrict.Size = new System.Drawing.Size(72, 22);
            this.removeDistrict.TabIndex = 5;
            this.removeDistrict.Text = "Удалити";
            this.removeDistrict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeDistrict.UseVisualStyleBackColor = true;
            this.removeDistrict.Click += new System.EventHandler(this.RemoveDistrict_Click);
            // 
            // dataDistrictsDirectory
            // 
            this.dataDistrictsDirectory.AllowUserToAddRows = false;
            this.dataDistrictsDirectory.AllowUserToDeleteRows = false;
            this.dataDistrictsDirectory.AllowUserToResizeColumns = false;
            this.dataDistrictsDirectory.AllowUserToResizeRows = false;
            this.dataDistrictsDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDistrictsDirectory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataDistrictsDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDistrictsDirectory.ColumnHeadersVisible = false;
            this.dataDistrictsDirectory.Location = new System.Drawing.Point(2, 30);
            this.dataDistrictsDirectory.MultiSelect = false;
            this.dataDistrictsDirectory.Name = "dataDistrictsDirectory";
            this.dataDistrictsDirectory.ReadOnly = true;
            this.dataDistrictsDirectory.RowHeadersVisible = false;
            this.dataDistrictsDirectory.RowHeadersWidth = 51;
            this.dataDistrictsDirectory.RowTemplate.Height = 29;
            this.dataDistrictsDirectory.Size = new System.Drawing.Size(210, 500);
            this.dataDistrictsDirectory.TabIndex = 0;
            this.dataDistrictsDirectory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewDistrictsHasBeenChosen_CellClick);
            // 
            // panelRegion
            // 
            this.panelRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegion.Controls.Add(this.labelRegion);
            this.panelRegion.Controls.Add(this.panelActionRegion);
            this.panelRegion.Controls.Add(this.dataRegionsDirectory);
            this.panelRegion.Location = new System.Drawing.Point(203, 10);
            this.panelRegion.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.panelRegion.Name = "panelRegion";
            this.panelRegion.Size = new System.Drawing.Size(216, 604);
            this.panelRegion.TabIndex = 7;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelRegion.Location = new System.Drawing.Point(74, 7);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(66, 20);
            this.labelRegion.TabIndex = 2;
            this.labelRegion.Text = "Область";
            // 
            // panelActionRegion
            // 
            this.panelActionRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionRegion.Controls.Add(this.searchRegion);
            this.panelActionRegion.Controls.Add(this.addRegion);
            this.panelActionRegion.Controls.Add(this.removeRegion);
            this.panelActionRegion.Location = new System.Drawing.Point(2, 532);
            this.panelActionRegion.Name = "panelActionRegion";
            this.panelActionRegion.Size = new System.Drawing.Size(210, 68);
            this.panelActionRegion.TabIndex = 6;
            // 
            // searchRegion
            // 
            this.searchRegion.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchRegion.Location = new System.Drawing.Point(5, 6);
            this.searchRegion.MaxLength = 100;
            this.searchRegion.Name = "searchRegion";
            this.searchRegion.Size = new System.Drawing.Size(198, 23);
            this.searchRegion.TabIndex = 4;
            this.searchRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchRegion_KeyDown);
            // 
            // addRegion
            // 
            this.addRegion.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRegion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addRegion.Location = new System.Drawing.Point(131, 39);
            this.addRegion.Name = "addRegion";
            this.addRegion.Size = new System.Drawing.Size(72, 22);
            this.addRegion.TabIndex = 3;
            this.addRegion.Text = "Додати";
            this.addRegion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addRegion.UseVisualStyleBackColor = true;
            this.addRegion.Click += new System.EventHandler(this.AddRegionIntoDirectory_Click);
            // 
            // removeRegion
            // 
            this.removeRegion.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeRegion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeRegion.Location = new System.Drawing.Point(4, 39);
            this.removeRegion.Name = "removeRegion";
            this.removeRegion.Size = new System.Drawing.Size(72, 22);
            this.removeRegion.TabIndex = 5;
            this.removeRegion.Text = "Удалити";
            this.removeRegion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeRegion.UseVisualStyleBackColor = true;
            this.removeRegion.Click += new System.EventHandler(this.RemoveRegion_Click);
            // 
            // dataRegionsDirectory
            // 
            this.dataRegionsDirectory.AllowUserToAddRows = false;
            this.dataRegionsDirectory.AllowUserToDeleteRows = false;
            this.dataRegionsDirectory.AllowUserToResizeColumns = false;
            this.dataRegionsDirectory.AllowUserToResizeRows = false;
            this.dataRegionsDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRegionsDirectory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataRegionsDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegionsDirectory.ColumnHeadersVisible = false;
            this.dataRegionsDirectory.Location = new System.Drawing.Point(2, 30);
            this.dataRegionsDirectory.MultiSelect = false;
            this.dataRegionsDirectory.Name = "dataRegionsDirectory";
            this.dataRegionsDirectory.ReadOnly = true;
            this.dataRegionsDirectory.RowHeadersVisible = false;
            this.dataRegionsDirectory.RowHeadersWidth = 51;
            this.dataRegionsDirectory.RowTemplate.Height = 29;
            this.dataRegionsDirectory.Size = new System.Drawing.Size(210, 500);
            this.dataRegionsDirectory.TabIndex = 0;
            this.dataRegionsDirectory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewRegionHasBeenChosen_CellClick);
            // 
            // panelCountry
            // 
            this.panelCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCountry.Controls.Add(this.LabelCountry);
            this.panelCountry.Controls.Add(this.panelActionCountry);
            this.panelCountry.Controls.Add(this.dataCountriesDirectory);
            this.panelCountry.Location = new System.Drawing.Point(11, 10);
            this.panelCountry.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(186, 604);
            this.panelCountry.TabIndex = 1;
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LabelCountry.Location = new System.Drawing.Point(64, 7);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(56, 20);
            this.LabelCountry.TabIndex = 2;
            this.LabelCountry.Text = "Країна";
            // 
            // panelActionCountry
            // 
            this.panelActionCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionCountry.Controls.Add(this.searchCountry);
            this.panelActionCountry.Controls.Add(this.addCountry);
            this.panelActionCountry.Controls.Add(this.removeCountry);
            this.panelActionCountry.Location = new System.Drawing.Point(2, 532);
            this.panelActionCountry.Name = "panelActionCountry";
            this.panelActionCountry.Size = new System.Drawing.Size(180, 68);
            this.panelActionCountry.TabIndex = 6;
            // 
            // searchCountry
            // 
            this.searchCountry.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCountry.Location = new System.Drawing.Point(5, 6);
            this.searchCountry.MaxLength = 100;
            this.searchCountry.Name = "searchCountry";
            this.searchCountry.ShortcutsEnabled = false;
            this.searchCountry.Size = new System.Drawing.Size(168, 23);
            this.searchCountry.TabIndex = 4;
            this.searchCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCountry_KeyDown);
            // 
            // addCountry
            // 
            this.addCountry.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCountry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addCountry.Location = new System.Drawing.Point(101, 39);
            this.addCountry.Name = "addCountry";
            this.addCountry.Size = new System.Drawing.Size(72, 22);
            this.addCountry.TabIndex = 3;
            this.addCountry.Text = "Додати";
            this.addCountry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCountry.UseVisualStyleBackColor = true;
            this.addCountry.Click += new System.EventHandler(this.AddCountryIntoDirectory_Click);
            // 
            // removeCountry
            // 
            this.removeCountry.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeCountry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeCountry.Location = new System.Drawing.Point(4, 39);
            this.removeCountry.Name = "removeCountry";
            this.removeCountry.Size = new System.Drawing.Size(72, 22);
            this.removeCountry.TabIndex = 5;
            this.removeCountry.Text = "Удалити";
            this.removeCountry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeCountry.UseVisualStyleBackColor = true;
            this.removeCountry.Click += new System.EventHandler(this.RemoveCountry_Click);
            // 
            // dataCountriesDirectory
            // 
            this.dataCountriesDirectory.AllowUserToAddRows = false;
            this.dataCountriesDirectory.AllowUserToDeleteRows = false;
            this.dataCountriesDirectory.AllowUserToResizeColumns = false;
            this.dataCountriesDirectory.AllowUserToResizeRows = false;
            this.dataCountriesDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCountriesDirectory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCountriesDirectory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCountriesDirectory.ColumnHeadersHeight = 21;
            this.dataCountriesDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCountriesDirectory.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCountriesDirectory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataCountriesDirectory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataCountriesDirectory.Location = new System.Drawing.Point(2, 30);
            this.dataCountriesDirectory.MultiSelect = false;
            this.dataCountriesDirectory.Name = "dataCountriesDirectory";
            this.dataCountriesDirectory.ReadOnly = true;
            this.dataCountriesDirectory.RowHeadersVisible = false;
            this.dataCountriesDirectory.RowHeadersWidth = 4;
            this.dataCountriesDirectory.RowTemplate.Height = 29;
            this.dataCountriesDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataCountriesDirectory.Size = new System.Drawing.Size(180, 500);
            this.dataCountriesDirectory.TabIndex = 0;
            this.dataCountriesDirectory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewCountryHasBeenChosen_CellClick);
            // 
            // cross
            // 
            this.cross.Image = ((System.Drawing.Image)(resources.GetObject("cross.Image")));
            this.cross.Location = new System.Drawing.Point(875, 0);
            this.cross.Margin = new System.Windows.Forms.Padding(3, 6, 6, 3);
            this.cross.Name = "cross";
            this.cross.Padding = new System.Windows.Forms.Padding(6, 6, 2, 2);
            this.cross.Size = new System.Drawing.Size(25, 25);
            this.cross.TabIndex = 0;
            this.cross.TabStop = false;
            this.cross.Click += new System.EventHandler(this.CloseApplication_Click);
            this.cross.MouseLeave += new System.EventHandler(this.Cross_MouseLeave);
            this.cross.MouseHover += new System.EventHandler(this.Cross_MouseHover);
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applicationName.ForeColor = System.Drawing.Color.White;
            this.applicationName.Location = new System.Drawing.Point(52, 3);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(105, 20);
            this.applicationName.TabIndex = 1;
            this.applicationName.Text = "Довідник міст";
            // 
            // CityDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.applicationName);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.workspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "CityDirectory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.World_Load);
            this.EnabledChanged += new System.EventHandler(this.UpdateDirectory_EnabledChanged);
            this.workspace.ResumeLayout(false);
            this.panelSettlement.ResumeLayout(false);
            this.panelSettlement.PerformLayout();
            this.panelActionSettlement.ResumeLayout(false);
            this.panelActionSettlement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSettlementsDirectory)).EndInit();
            this.panelDistrict.ResumeLayout(false);
            this.panelDistrict.PerformLayout();
            this.panelActionDistrict.ResumeLayout(false);
            this.panelActionDistrict.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDistrictsDirectory)).EndInit();
            this.panelRegion.ResumeLayout(false);
            this.panelRegion.PerformLayout();
            this.panelActionRegion.ResumeLayout(false);
            this.panelActionRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegionsDirectory)).EndInit();
            this.panelCountry.ResumeLayout(false);
            this.panelCountry.PerformLayout();
            this.panelActionCountry.ResumeLayout(false);
            this.panelActionCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCountriesDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel workspace;
        private PictureBox cross;
        private Panel panelCountry;
        private DataGridView dataCountriesDirectory;
        private TextBox searchCountry;
        private Button addCountry;
        private Button removeCountry;
        private Panel panelActionCountry;
        private Panel panelRegion;
        private Label labelRegion;
        private Panel panelActionRegion;
        private TextBox searchRegion;
        private Button addRegion;
        private Button removeRegion;
        private DataGridView dataRegionsDirectory;
        private Label LabelCountry;
        private Panel panelDistrict;
        private Label labelDistrict;
        private Panel panelActionDistrict;
        private TextBox SearchDistrict;
        private Button addDistrict;
        private Button removeDistrict;
        private DataGridView dataDistrictsDirectory;
        private Panel panelSettlement;
        private Label labelSettlement;
        private Panel panelActionSettlement;
        private TextBox searchSettlement;
        private Button addSettlement;
        private Button removeSettlement;
        private DataGridView dataSettlementsDirectory;
        private ComboBox selectTypeSettlement;
        private Label applicationName;
    }
}