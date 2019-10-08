namespace BasicFinancialSystem
{
    partial class CustomerRegister
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
            System.Windows.Forms.Label customerRegisterCodeLabel;
            System.Windows.Forms.Label customerRegisterNameLabel;
            System.Windows.Forms.Label customerRegisterAddressLabel;
            System.Windows.Forms.Label customerRegisterCityLabel;
            System.Windows.Forms.Label customerRegisterNeighborhoodLabel;
            System.Windows.Forms.Label customerRegisterStateLabel;
            System.Windows.Forms.Label customerRegisterPostalCodeLabel;
            System.Windows.Forms.Label customerRegisterPhoneLabel;
            System.Windows.Forms.Label customerRegisterEmailLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label stateSubscriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegister));
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerRegisterCodeText = new System.Windows.Forms.TextBox();
            this.customerRegisterNameText = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerRegisterCityText = new System.Windows.Forms.TextBox();
            this.customerRegisterNeighborhoodText = new System.Windows.Forms.TextBox();
            this.customerRegisterStateText = new System.Windows.Forms.TextBox();
            this.customerRegisterPostalCodeText = new System.Windows.Forms.TextBox();
            this.customerRegisterPhoneText = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.stateSubscriptionTextBox = new System.Windows.Forms.TextBox();
            customerRegisterCodeLabel = new System.Windows.Forms.Label();
            customerRegisterNameLabel = new System.Windows.Forms.Label();
            customerRegisterAddressLabel = new System.Windows.Forms.Label();
            customerRegisterCityLabel = new System.Windows.Forms.Label();
            customerRegisterNeighborhoodLabel = new System.Windows.Forms.Label();
            customerRegisterStateLabel = new System.Windows.Forms.Label();
            customerRegisterPostalCodeLabel = new System.Windows.Forms.Label();
            customerRegisterPhoneLabel = new System.Windows.Forms.Label();
            customerRegisterEmailLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            stateSubscriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerRegisterCodeLabel
            // 
            customerRegisterCodeLabel.AutoSize = true;
            customerRegisterCodeLabel.Location = new System.Drawing.Point(36, 70);
            customerRegisterCodeLabel.Name = "customerRegisterCodeLabel";
            customerRegisterCodeLabel.Size = new System.Drawing.Size(35, 13);
            customerRegisterCodeLabel.TabIndex = 1;
            customerRegisterCodeLabel.Text = "Code:";
            // 
            // customerRegisterNameLabel
            // 
            customerRegisterNameLabel.AutoSize = true;
            customerRegisterNameLabel.Location = new System.Drawing.Point(36, 121);
            customerRegisterNameLabel.Name = "customerRegisterNameLabel";
            customerRegisterNameLabel.Size = new System.Drawing.Size(38, 13);
            customerRegisterNameLabel.TabIndex = 3;
            customerRegisterNameLabel.Text = "Name:";
            // 
            // customerRegisterAddressLabel
            // 
            customerRegisterAddressLabel.AutoSize = true;
            customerRegisterAddressLabel.Location = new System.Drawing.Point(36, 170);
            customerRegisterAddressLabel.Name = "customerRegisterAddressLabel";
            customerRegisterAddressLabel.Size = new System.Drawing.Size(48, 13);
            customerRegisterAddressLabel.TabIndex = 5;
            customerRegisterAddressLabel.Text = "Address:";
            // 
            // customerRegisterCityLabel
            // 
            customerRegisterCityLabel.AutoSize = true;
            customerRegisterCityLabel.Location = new System.Drawing.Point(294, 170);
            customerRegisterCityLabel.Name = "customerRegisterCityLabel";
            customerRegisterCityLabel.Size = new System.Drawing.Size(27, 13);
            customerRegisterCityLabel.TabIndex = 7;
            customerRegisterCityLabel.Text = "City:";
            // 
            // customerRegisterNeighborhoodLabel
            // 
            customerRegisterNeighborhoodLabel.AutoSize = true;
            customerRegisterNeighborhoodLabel.Location = new System.Drawing.Point(36, 220);
            customerRegisterNeighborhoodLabel.Name = "customerRegisterNeighborhoodLabel";
            customerRegisterNeighborhoodLabel.Size = new System.Drawing.Size(77, 13);
            customerRegisterNeighborhoodLabel.TabIndex = 9;
            customerRegisterNeighborhoodLabel.Text = "Neighborhood:";
            // 
            // customerRegisterStateLabel
            // 
            customerRegisterStateLabel.AutoSize = true;
            customerRegisterStateLabel.Location = new System.Drawing.Point(294, 220);
            customerRegisterStateLabel.Name = "customerRegisterStateLabel";
            customerRegisterStateLabel.Size = new System.Drawing.Size(35, 13);
            customerRegisterStateLabel.TabIndex = 11;
            customerRegisterStateLabel.Text = "State:";
            // 
            // customerRegisterPostalCodeLabel
            // 
            customerRegisterPostalCodeLabel.AutoSize = true;
            customerRegisterPostalCodeLabel.Location = new System.Drawing.Point(36, 268);
            customerRegisterPostalCodeLabel.Name = "customerRegisterPostalCodeLabel";
            customerRegisterPostalCodeLabel.Size = new System.Drawing.Size(67, 13);
            customerRegisterPostalCodeLabel.TabIndex = 13;
            customerRegisterPostalCodeLabel.Text = "Postal Code:";
            // 
            // customerRegisterPhoneLabel
            // 
            customerRegisterPhoneLabel.AutoSize = true;
            customerRegisterPhoneLabel.Location = new System.Drawing.Point(36, 320);
            customerRegisterPhoneLabel.Name = "customerRegisterPhoneLabel";
            customerRegisterPhoneLabel.Size = new System.Drawing.Size(41, 13);
            customerRegisterPhoneLabel.TabIndex = 15;
            customerRegisterPhoneLabel.Text = "Phone:";
            // 
            // customerRegisterEmailLabel
            // 
            customerRegisterEmailLabel.AutoSize = true;
            customerRegisterEmailLabel.Location = new System.Drawing.Point(224, 320);
            customerRegisterEmailLabel.Name = "customerRegisterEmailLabel";
            customerRegisterEmailLabel.Size = new System.Drawing.Size(38, 13);
            customerRegisterEmailLabel.TabIndex = 17;
            customerRegisterEmailLabel.Text = "E-mail:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(348, 380);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 19;
            typeLabel.Text = "type:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(348, 406);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 21;
            cpfLabel.Text = "cpf:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(348, 432);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 23;
            cnpjLabel.Text = "cnpj:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(348, 458);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(19, 13);
            rgLabel.TabIndex = 25;
            rgLabel.Text = "rg:";
            // 
            // stateSubscriptionLabel
            // 
            stateSubscriptionLabel.AutoSize = true;
            stateSubscriptionLabel.Location = new System.Drawing.Point(348, 484);
            stateSubscriptionLabel.Name = "stateSubscriptionLabel";
            stateSubscriptionLabel.Size = new System.Drawing.Size(94, 13);
            stateSubscriptionLabel.TabIndex = 27;
            stateSubscriptionLabel.Text = "state Subscription:";
            // 
            // financialDataSet
            // 
            this.financialDataSet.DataSetName = "FinancialDataSet";
            this.financialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.financialDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillToPayTableAdapter = null;
            this.tableAdapterManager.BillToReceiveTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // customerRegisterCodeText
            // 
            this.customerRegisterCodeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "id", true));
            this.customerRegisterCodeText.Location = new System.Drawing.Point(39, 86);
            this.customerRegisterCodeText.Name = "customerRegisterCodeText";
            this.customerRegisterCodeText.Size = new System.Drawing.Size(32, 20);
            this.customerRegisterCodeText.TabIndex = 2;
            // 
            // customerRegisterNameText
            // 
            this.customerRegisterNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name", true));
            this.customerRegisterNameText.Location = new System.Drawing.Point(39, 137);
            this.customerRegisterNameText.Name = "customerRegisterNameText";
            this.customerRegisterNameText.Size = new System.Drawing.Size(449, 20);
            this.customerRegisterNameText.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(39, 187);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(234, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // customerRegisterCityText
            // 
            this.customerRegisterCityText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "city", true));
            this.customerRegisterCityText.Location = new System.Drawing.Point(297, 186);
            this.customerRegisterCityText.Name = "customerRegisterCityText";
            this.customerRegisterCityText.Size = new System.Drawing.Size(191, 20);
            this.customerRegisterCityText.TabIndex = 8;
            // 
            // customerRegisterNeighborhoodText
            // 
            this.customerRegisterNeighborhoodText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "neighborhood", true));
            this.customerRegisterNeighborhoodText.Location = new System.Drawing.Point(39, 238);
            this.customerRegisterNeighborhoodText.Name = "customerRegisterNeighborhoodText";
            this.customerRegisterNeighborhoodText.Size = new System.Drawing.Size(234, 20);
            this.customerRegisterNeighborhoodText.TabIndex = 10;
            // 
            // customerRegisterStateText
            // 
            this.customerRegisterStateText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "state", true));
            this.customerRegisterStateText.Location = new System.Drawing.Point(297, 238);
            this.customerRegisterStateText.Name = "customerRegisterStateText";
            this.customerRegisterStateText.Size = new System.Drawing.Size(191, 20);
            this.customerRegisterStateText.TabIndex = 12;
            // 
            // customerRegisterPostalCodeText
            // 
            this.customerRegisterPostalCodeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "postalCode", true));
            this.customerRegisterPostalCodeText.Location = new System.Drawing.Point(39, 287);
            this.customerRegisterPostalCodeText.Name = "customerRegisterPostalCodeText";
            this.customerRegisterPostalCodeText.Size = new System.Drawing.Size(234, 20);
            this.customerRegisterPostalCodeText.TabIndex = 14;
            // 
            // customerRegisterPhoneText
            // 
            this.customerRegisterPhoneText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone", true));
            this.customerRegisterPhoneText.Location = new System.Drawing.Point(39, 342);
            this.customerRegisterPhoneText.Name = "customerRegisterPhoneText";
            this.customerRegisterPhoneText.Size = new System.Drawing.Size(166, 20);
            this.customerRegisterPhoneText.TabIndex = 16;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(227, 339);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(261, 20);
            this.emailTextBox.TabIndex = 18;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(448, 377);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 20;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(448, 403);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfTextBox.TabIndex = 22;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(448, 429);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 24;
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "rg", true));
            this.rgTextBox.Location = new System.Drawing.Point(448, 455);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgTextBox.TabIndex = 26;
            // 
            // stateSubscriptionTextBox
            // 
            this.stateSubscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "stateSubscription", true));
            this.stateSubscriptionTextBox.Location = new System.Drawing.Point(448, 481);
            this.stateSubscriptionTextBox.Name = "stateSubscriptionTextBox";
            this.stateSubscriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateSubscriptionTextBox.TabIndex = 28;
            // 
            // CustomerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(customerRegisterCodeLabel);
            this.Controls.Add(this.customerRegisterCodeText);
            this.Controls.Add(customerRegisterNameLabel);
            this.Controls.Add(this.customerRegisterNameText);
            this.Controls.Add(customerRegisterAddressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(customerRegisterCityLabel);
            this.Controls.Add(this.customerRegisterCityText);
            this.Controls.Add(customerRegisterNeighborhoodLabel);
            this.Controls.Add(this.customerRegisterNeighborhoodText);
            this.Controls.Add(customerRegisterStateLabel);
            this.Controls.Add(this.customerRegisterStateText);
            this.Controls.Add(customerRegisterPostalCodeLabel);
            this.Controls.Add(this.customerRegisterPostalCodeText);
            this.Controls.Add(customerRegisterPhoneLabel);
            this.Controls.Add(this.customerRegisterPhoneText);
            this.Controls.Add(customerRegisterEmailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(stateSubscriptionLabel);
            this.Controls.Add(this.stateSubscriptionTextBox);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "CustomerRegister";
            this.Text = "CustomerRegister";
            this.Load += new System.EventHandler(this.CustomerRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinancialDataSet financialDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FinancialDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private FinancialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerRegisterCodeText;
        private System.Windows.Forms.TextBox customerRegisterNameText;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox customerRegisterCityText;
        private System.Windows.Forms.TextBox customerRegisterNeighborhoodText;
        private System.Windows.Forms.TextBox customerRegisterStateText;
        private System.Windows.Forms.TextBox customerRegisterPostalCodeText;
        private System.Windows.Forms.TextBox customerRegisterPhoneText;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox stateSubscriptionTextBox;
    }
}