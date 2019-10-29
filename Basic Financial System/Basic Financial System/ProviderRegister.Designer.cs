namespace Basic_Financial_System
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label neighborhoodLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label stateSubscriptionLabel;
            System.Windows.Forms.Label countySubscriptionLabel;
            this.financialDataSet = new Basic_Financial_System.FinancialDataSet();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new Basic_Financial_System.FinancialDataSetTableAdapters.ProviderTableAdapter();
            this.tableAdapterManager = new Basic_Financial_System.FinancialDataSetTableAdapters.TableAdapterManager();
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.neighborhoodTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.stateSubscriptionTextBox = new System.Windows.Forms.TextBox();
            this.countySubscriptionTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            neighborhoodLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            stateSubscriptionLabel = new System.Windows.Forms.Label();
            countySubscriptionLabel = new System.Windows.Forms.Label();
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
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Basic_Financial_System.FinancialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.providerBindingNavigator.Size = new System.Drawing.Size(1184, 25);
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(110, 155);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(28, 19);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(342, 148);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(233, 177);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(342, 174);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(233, 203);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 19);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(342, 200);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 26);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(233, 229);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(40, 19);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "city:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "city", true));
            this.cityTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(342, 226);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 26);
            this.cityTextBox.TabIndex = 8;
            // 
            // neighborhoodLabel
            // 
            neighborhoodLabel.AutoSize = true;
            neighborhoodLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            neighborhoodLabel.Location = new System.Drawing.Point(233, 255);
            neighborhoodLabel.Name = "neighborhoodLabel";
            neighborhoodLabel.Size = new System.Drawing.Size(117, 19);
            neighborhoodLabel.TabIndex = 9;
            neighborhoodLabel.Text = "neighborhood:";
            // 
            // neighborhoodTextBox
            // 
            this.neighborhoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "neighborhood", true));
            this.neighborhoodTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neighborhoodTextBox.Location = new System.Drawing.Point(342, 252);
            this.neighborhoodTextBox.Name = "neighborhoodTextBox";
            this.neighborhoodTextBox.Size = new System.Drawing.Size(100, 26);
            this.neighborhoodTextBox.TabIndex = 10;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(233, 281);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(50, 19);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "state:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "state", true));
            this.stateTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Location = new System.Drawing.Point(342, 278);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 26);
            this.stateTextBox.TabIndex = 12;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postalCodeLabel.Location = new System.Drawing.Point(233, 307);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(100, 19);
            postalCodeLabel.TabIndex = 13;
            postalCodeLabel.Text = "postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "postalCode", true));
            this.postalCodeTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.Location = new System.Drawing.Point(342, 304);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.postalCodeTextBox.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(233, 333);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(60, 19);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(342, 330);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 26);
            this.phoneTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(233, 359);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(54, 19);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(342, 356);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 26);
            this.emailTextBox.TabIndex = 18;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(233, 385);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(45, 19);
            typeLabel.TabIndex = 19;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "type", true));
            this.typeTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(342, 382);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 26);
            this.typeTextBox.TabIndex = 20;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.Location = new System.Drawing.Point(233, 411);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(36, 19);
            cpfLabel.TabIndex = 21;
            cpfLabel.Text = "cpf:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "cpf", true));
            this.cpfTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextBox.Location = new System.Drawing.Point(342, 408);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(100, 26);
            this.cpfTextBox.TabIndex = 22;
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cnpjLabel.Location = new System.Drawing.Point(233, 437);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(46, 19);
            cnpjLabel.TabIndex = 23;
            cnpjLabel.Text = "cnpj:";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "cnpj", true));
            this.cnpjTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpjTextBox.Location = new System.Drawing.Point(342, 434);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 26);
            this.cnpjTextBox.TabIndex = 24;
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rgLabel.Location = new System.Drawing.Point(233, 463);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(28, 19);
            rgLabel.TabIndex = 25;
            rgLabel.Text = "rg:";
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "rg", true));
            this.rgTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTextBox.Location = new System.Drawing.Point(342, 460);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 26);
            this.rgTextBox.TabIndex = 26;
            // 
            // stateSubscriptionLabel
            // 
            stateSubscriptionLabel.AutoSize = true;
            stateSubscriptionLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateSubscriptionLabel.Location = new System.Drawing.Point(233, 489);
            stateSubscriptionLabel.Name = "stateSubscriptionLabel";
            stateSubscriptionLabel.Size = new System.Drawing.Size(150, 19);
            stateSubscriptionLabel.TabIndex = 27;
            stateSubscriptionLabel.Text = "state Subscription:";
            // 
            // stateSubscriptionTextBox
            // 
            this.stateSubscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "stateSubscription", true));
            this.stateSubscriptionTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateSubscriptionTextBox.Location = new System.Drawing.Point(342, 486);
            this.stateSubscriptionTextBox.Name = "stateSubscriptionTextBox";
            this.stateSubscriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.stateSubscriptionTextBox.TabIndex = 28;
            // 
            // countySubscriptionLabel
            // 
            countySubscriptionLabel.AutoSize = true;
            countySubscriptionLabel.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countySubscriptionLabel.Location = new System.Drawing.Point(233, 515);
            countySubscriptionLabel.Name = "countySubscriptionLabel";
            countySubscriptionLabel.Size = new System.Drawing.Size(164, 19);
            countySubscriptionLabel.TabIndex = 29;
            countySubscriptionLabel.Text = "county Subscription:";
            // 
            // countySubscriptionTextBox
            // 
            this.countySubscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "countySubscription", true));
            this.countySubscriptionTextBox.Font = new System.Drawing.Font("Karla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countySubscriptionTextBox.Location = new System.Drawing.Point(342, 512);
            this.countySubscriptionTextBox.Name = "countySubscriptionTextBox";
            this.countySubscriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.countySubscriptionTextBox.TabIndex = 30;
            // 
            // ProviderRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.ControlBox = false;
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(neighborhoodLabel);
            this.Controls.Add(this.neighborhoodTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
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
            this.Controls.Add(countySubscriptionLabel);
            this.Controls.Add(this.countySubscriptionTextBox);
            this.Controls.Add(this.providerBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProviderRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox neighborhoodTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox stateSubscriptionTextBox;
        private System.Windows.Forms.TextBox countySubscriptionTextBox;
    }
}