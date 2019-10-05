namespace BasicFinancialSystem
{
    partial class ProviderRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderRegister));
            System.Windows.Forms.Label providerRegisterCodeLabel;
            System.Windows.Forms.Label providerRegisterNameLabel;
            System.Windows.Forms.Label providerRegisterAddressLabel;
            System.Windows.Forms.Label providerRegisterCityLabel;
            System.Windows.Forms.Label providerRegisterNeighborhoodLabel;
            System.Windows.Forms.Label providerRegisterStateLabel;
            System.Windows.Forms.Label providerRegisterPostalCodeLabel;
            System.Windows.Forms.Label providerRegisterPhoneLabel;
            System.Windows.Forms.Label providerRegisterEmailLabel;
            System.Windows.Forms.Label providerRegisterTypeLabel;
            System.Windows.Forms.Label providerRegisterCPFLabel;
            System.Windows.Forms.Label providerRegisterCNPJLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label providerRegisterStateSubscriptionLabel;
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.ProviderTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.providerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.providerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.providerRegisterCodeText = new System.Windows.Forms.TextBox();
            this.providerRegisterNameText = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.providerRegisterNeighborhoodText = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.providerRegisterPostalCodeText = new System.Windows.Forms.TextBox();
            this.providerRegisterPhoneText = new System.Windows.Forms.TextBox();
            this.providerRegisterEmailText = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.providerRegisterCPFText = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.providerRegisterStateSubscriptionText = new System.Windows.Forms.TextBox();
            providerRegisterCodeLabel = new System.Windows.Forms.Label();
            providerRegisterNameLabel = new System.Windows.Forms.Label();
            providerRegisterAddressLabel = new System.Windows.Forms.Label();
            providerRegisterCityLabel = new System.Windows.Forms.Label();
            providerRegisterNeighborhoodLabel = new System.Windows.Forms.Label();
            providerRegisterStateLabel = new System.Windows.Forms.Label();
            providerRegisterPostalCodeLabel = new System.Windows.Forms.Label();
            providerRegisterPhoneLabel = new System.Windows.Forms.Label();
            providerRegisterEmailLabel = new System.Windows.Forms.Label();
            providerRegisterTypeLabel = new System.Windows.Forms.Label();
            providerRegisterCPFLabel = new System.Windows.Forms.Label();
            providerRegisterCNPJLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            providerRegisterStateSubscriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingNavigator)).BeginInit();
            this.providerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // financialDataSet
            // 
            this.financialDataSet.DataSetName = "FinancialDataSet";
            this.financialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.financialDataSet;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillToPayTableAdapter = null;
            this.tableAdapterManager.BillToReceiveTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.UpdateOrder = BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // providerBindingNavigator
            // 
            this.providerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.providerBindingNavigator.BindingSource = this.providerBindingSource;
            this.providerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.providerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.providerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.providerBindingNavigatorSaveItem});
            this.providerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.providerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.providerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.providerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.providerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.providerBindingNavigator.Name = "providerBindingNavigator";
            this.providerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.providerBindingNavigator.Size = new System.Drawing.Size(761, 25);
            this.providerBindingNavigator.TabIndex = 0;
            this.providerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // providerBindingNavigatorSaveItem
            // 
            this.providerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.providerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("providerBindingNavigatorSaveItem.Image")));
            this.providerBindingNavigatorSaveItem.Name = "providerBindingNavigatorSaveItem";
            this.providerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.providerBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.providerBindingNavigatorSaveItem.Click += new System.EventHandler(this.providerBindingNavigatorSaveItem_Click);
            // 
            // providerRegisterCodeLabel
            // 
            providerRegisterCodeLabel.AutoSize = true;
            providerRegisterCodeLabel.Location = new System.Drawing.Point(48, 34);
            providerRegisterCodeLabel.Name = "providerRegisterCodeLabel";
            providerRegisterCodeLabel.Size = new System.Drawing.Size(35, 13);
            providerRegisterCodeLabel.TabIndex = 1;
            providerRegisterCodeLabel.Text = "Code:";
            // 
            // providerRegisterCodeText
            // 
            this.providerRegisterCodeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "id", true));
            this.providerRegisterCodeText.Location = new System.Drawing.Point(51, 50);
            this.providerRegisterCodeText.Name = "providerRegisterCodeText";
            this.providerRegisterCodeText.Size = new System.Drawing.Size(46, 20);
            this.providerRegisterCodeText.TabIndex = 2;
            // 
            // providerRegisterNameLabel
            // 
            providerRegisterNameLabel.AutoSize = true;
            providerRegisterNameLabel.Location = new System.Drawing.Point(48, 86);
            providerRegisterNameLabel.Name = "providerRegisterNameLabel";
            providerRegisterNameLabel.Size = new System.Drawing.Size(38, 13);
            providerRegisterNameLabel.TabIndex = 3;
            providerRegisterNameLabel.Text = "Name:";
            // 
            // providerRegisterNameText
            // 
            this.providerRegisterNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "name", true));
            this.providerRegisterNameText.Location = new System.Drawing.Point(51, 102);
            this.providerRegisterNameText.Name = "providerRegisterNameText";
            this.providerRegisterNameText.Size = new System.Drawing.Size(429, 20);
            this.providerRegisterNameText.TabIndex = 4;
            // 
            // providerRegisterAddressLabel
            // 
            providerRegisterAddressLabel.AutoSize = true;
            providerRegisterAddressLabel.Location = new System.Drawing.Point(49, 133);
            providerRegisterAddressLabel.Name = "providerRegisterAddressLabel";
            providerRegisterAddressLabel.Size = new System.Drawing.Size(48, 13);
            providerRegisterAddressLabel.TabIndex = 5;
            providerRegisterAddressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(51, 149);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(260, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // providerRegisterCityLabel
            // 
            providerRegisterCityLabel.AutoSize = true;
            providerRegisterCityLabel.Location = new System.Drawing.Point(502, 133);
            providerRegisterCityLabel.Name = "providerRegisterCityLabel";
            providerRegisterCityLabel.Size = new System.Drawing.Size(27, 13);
            providerRegisterCityLabel.TabIndex = 7;
            providerRegisterCityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(505, 149);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(130, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // providerRegisterNeighborhoodLabel
            // 
            providerRegisterNeighborhoodLabel.AutoSize = true;
            providerRegisterNeighborhoodLabel.Location = new System.Drawing.Point(334, 133);
            providerRegisterNeighborhoodLabel.Name = "providerRegisterNeighborhoodLabel";
            providerRegisterNeighborhoodLabel.Size = new System.Drawing.Size(77, 13);
            providerRegisterNeighborhoodLabel.TabIndex = 9;
            providerRegisterNeighborhoodLabel.Text = "Neighborhood:";
            // 
            // providerRegisterNeighborhoodText
            // 
            this.providerRegisterNeighborhoodText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "neighborhood", true));
            this.providerRegisterNeighborhoodText.Location = new System.Drawing.Point(337, 149);
            this.providerRegisterNeighborhoodText.Name = "providerRegisterNeighborhoodText";
            this.providerRegisterNeighborhoodText.Size = new System.Drawing.Size(143, 20);
            this.providerRegisterNeighborhoodText.TabIndex = 10;
            // 
            // providerRegisterStateLabel
            // 
            providerRegisterStateLabel.AutoSize = true;
            providerRegisterStateLabel.Location = new System.Drawing.Point(369, 178);
            providerRegisterStateLabel.Name = "providerRegisterStateLabel";
            providerRegisterStateLabel.Size = new System.Drawing.Size(35, 13);
            providerRegisterStateLabel.TabIndex = 11;
            providerRegisterStateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(372, 196);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 12;
            // 
            // providerRegisterPostalCodeLabel
            // 
            providerRegisterPostalCodeLabel.AutoSize = true;
            providerRegisterPostalCodeLabel.Location = new System.Drawing.Point(48, 178);
            providerRegisterPostalCodeLabel.Name = "providerRegisterPostalCodeLabel";
            providerRegisterPostalCodeLabel.Size = new System.Drawing.Size(67, 13);
            providerRegisterPostalCodeLabel.TabIndex = 13;
            providerRegisterPostalCodeLabel.Text = "Postal Code:";
            // 
            // providerRegisterPostalCodeText
            // 
            this.providerRegisterPostalCodeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "postalCode", true));
            this.providerRegisterPostalCodeText.Location = new System.Drawing.Point(52, 196);
            this.providerRegisterPostalCodeText.Name = "providerRegisterPostalCodeText";
            this.providerRegisterPostalCodeText.Size = new System.Drawing.Size(147, 20);
            this.providerRegisterPostalCodeText.TabIndex = 14;
            // 
            // providerRegisterPhoneLabel
            // 
            providerRegisterPhoneLabel.AutoSize = true;
            providerRegisterPhoneLabel.Location = new System.Drawing.Point(371, 229);
            providerRegisterPhoneLabel.Name = "providerRegisterPhoneLabel";
            providerRegisterPhoneLabel.Size = new System.Drawing.Size(41, 13);
            providerRegisterPhoneLabel.TabIndex = 15;
            providerRegisterPhoneLabel.Text = "Phone:";
            // 
            // providerRegisterPhoneText
            // 
            this.providerRegisterPhoneText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "phone", true));
            this.providerRegisterPhoneText.Location = new System.Drawing.Point(372, 245);
            this.providerRegisterPhoneText.Name = "providerRegisterPhoneText";
            this.providerRegisterPhoneText.Size = new System.Drawing.Size(136, 20);
            this.providerRegisterPhoneText.TabIndex = 16;
            // 
            // providerRegisterEmailLabel
            // 
            providerRegisterEmailLabel.AutoSize = true;
            providerRegisterEmailLabel.Location = new System.Drawing.Point(49, 229);
            providerRegisterEmailLabel.Name = "providerRegisterEmailLabel";
            providerRegisterEmailLabel.Size = new System.Drawing.Size(38, 13);
            providerRegisterEmailLabel.TabIndex = 17;
            providerRegisterEmailLabel.Text = "E-mail:";
            // 
            // providerRegisterEmailText
            // 
            this.providerRegisterEmailText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "email", true));
            this.providerRegisterEmailText.Location = new System.Drawing.Point(52, 245);
            this.providerRegisterEmailText.Name = "providerRegisterEmailText";
            this.providerRegisterEmailText.Size = new System.Drawing.Size(294, 20);
            this.providerRegisterEmailText.TabIndex = 18;
            // 
            // providerRegisterTypeLabel
            // 
            providerRegisterTypeLabel.AutoSize = true;
            providerRegisterTypeLabel.Location = new System.Drawing.Point(48, 279);
            providerRegisterTypeLabel.Name = "providerRegisterTypeLabel";
            providerRegisterTypeLabel.Size = new System.Drawing.Size(34, 13);
            providerRegisterTypeLabel.TabIndex = 19;
            providerRegisterTypeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(51, 295);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(31, 20);
            this.typeTextBox.TabIndex = 20;
            // 
            // providerRegisterCPFLabel
            // 
            providerRegisterCPFLabel.AutoSize = true;
            providerRegisterCPFLabel.Location = new System.Drawing.Point(238, 328);
            providerRegisterCPFLabel.Name = "providerRegisterCPFLabel";
            providerRegisterCPFLabel.Size = new System.Drawing.Size(30, 13);
            providerRegisterCPFLabel.TabIndex = 21;
            providerRegisterCPFLabel.Text = "CPF:";
            // 
            // providerRegisterCPFText
            // 
            this.providerRegisterCPFText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "cpf", true));
            this.providerRegisterCPFText.Location = new System.Drawing.Point(241, 350);
            this.providerRegisterCPFText.Name = "providerRegisterCPFText";
            this.providerRegisterCPFText.Size = new System.Drawing.Size(147, 20);
            this.providerRegisterCPFText.TabIndex = 22;
            // 
            // providerRegisterCNPJLabel
            // 
            providerRegisterCNPJLabel.AutoSize = true;
            providerRegisterCNPJLabel.Location = new System.Drawing.Point(52, 328);
            providerRegisterCNPJLabel.Name = "providerRegisterCNPJLabel";
            providerRegisterCNPJLabel.Size = new System.Drawing.Size(145, 13);
            providerRegisterCNPJLabel.TabIndex = 23;
            providerRegisterCNPJLabel.Text = "CNPJ (If it\'s a Juridic Person):";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(55, 350);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(142, 20);
            this.cnpjTextBox.TabIndex = 24;
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(501, 350);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(19, 13);
            rgLabel.TabIndex = 25;
            rgLabel.Text = "rg:";
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "rg", true));
            this.rgTextBox.Location = new System.Drawing.Point(601, 347);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgTextBox.TabIndex = 26;
            // 
            // providerRegisterStateSubscriptionLabel
            // 
            providerRegisterStateSubscriptionLabel.AutoSize = true;
            providerRegisterStateSubscriptionLabel.Location = new System.Drawing.Point(217, 178);
            providerRegisterStateSubscriptionLabel.Name = "providerRegisterStateSubscriptionLabel";
            providerRegisterStateSubscriptionLabel.Size = new System.Drawing.Size(96, 13);
            providerRegisterStateSubscriptionLabel.TabIndex = 27;
            providerRegisterStateSubscriptionLabel.Text = "State Subscription:";
            // 
            // providerRegisterStateSubscriptionText
            // 
            this.providerRegisterStateSubscriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "stateSubscription", true));
            this.providerRegisterStateSubscriptionText.Location = new System.Drawing.Point(220, 196);
            this.providerRegisterStateSubscriptionText.Name = "providerRegisterStateSubscriptionText";
            this.providerRegisterStateSubscriptionText.Size = new System.Drawing.Size(126, 20);
            this.providerRegisterStateSubscriptionText.TabIndex = 28;
            // 
            // ProviderRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 386);
            this.Controls.Add(providerRegisterCodeLabel);
            this.Controls.Add(this.providerRegisterCodeText);
            this.Controls.Add(providerRegisterNameLabel);
            this.Controls.Add(this.providerRegisterNameText);
            this.Controls.Add(providerRegisterAddressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(providerRegisterCityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(providerRegisterNeighborhoodLabel);
            this.Controls.Add(this.providerRegisterNeighborhoodText);
            this.Controls.Add(providerRegisterStateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(providerRegisterPostalCodeLabel);
            this.Controls.Add(this.providerRegisterPostalCodeText);
            this.Controls.Add(providerRegisterPhoneLabel);
            this.Controls.Add(this.providerRegisterPhoneText);
            this.Controls.Add(providerRegisterEmailLabel);
            this.Controls.Add(this.providerRegisterEmailText);
            this.Controls.Add(providerRegisterTypeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(providerRegisterCPFLabel);
            this.Controls.Add(this.providerRegisterCPFText);
            this.Controls.Add(providerRegisterCNPJLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(providerRegisterStateSubscriptionLabel);
            this.Controls.Add(this.providerRegisterStateSubscriptionText);
            this.Controls.Add(this.providerBindingNavigator);
            this.Name = "ProviderRegister";
            this.Text = "ProviderRegister";
            this.Load += new System.EventHandler(this.ProviderRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingNavigator)).EndInit();
            this.providerBindingNavigator.ResumeLayout(false);
            this.providerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinancialDataSet financialDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private FinancialDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private FinancialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator providerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton providerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox providerRegisterCodeText;
        private System.Windows.Forms.TextBox providerRegisterNameText;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox providerRegisterNeighborhoodText;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox providerRegisterPostalCodeText;
        private System.Windows.Forms.TextBox providerRegisterPhoneText;
        private System.Windows.Forms.TextBox providerRegisterEmailText;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox providerRegisterCPFText;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox providerRegisterStateSubscriptionText;
    }
}