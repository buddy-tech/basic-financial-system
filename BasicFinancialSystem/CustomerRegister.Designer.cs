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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegister));
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
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.customerBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(345, 108);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(445, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(345, 134);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(445, 131);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(345, 160);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(445, 157);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(345, 186);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "city:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(445, 183);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // neighborhoodLabel
            // 
            neighborhoodLabel.AutoSize = true;
            neighborhoodLabel.Location = new System.Drawing.Point(345, 212);
            neighborhoodLabel.Name = "neighborhoodLabel";
            neighborhoodLabel.Size = new System.Drawing.Size(75, 13);
            neighborhoodLabel.TabIndex = 9;
            neighborhoodLabel.Text = "neighborhood:";
            // 
            // neighborhoodTextBox
            // 
            this.neighborhoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "neighborhood", true));
            this.neighborhoodTextBox.Location = new System.Drawing.Point(445, 209);
            this.neighborhoodTextBox.Name = "neighborhoodTextBox";
            this.neighborhoodTextBox.Size = new System.Drawing.Size(100, 20);
            this.neighborhoodTextBox.TabIndex = 10;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(345, 238);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "state:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(445, 235);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 12;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(345, 264);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(66, 13);
            postalCodeLabel.TabIndex = 13;
            postalCodeLabel.Text = "postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "postalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(445, 261);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(345, 290);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(445, 287);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(345, 316);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(445, 313);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 18;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(345, 342);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 19;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(445, 339);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 20;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(345, 368);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 21;
            cpfLabel.Text = "cpf:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(445, 365);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfTextBox.TabIndex = 22;
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(345, 394);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 23;
            cnpjLabel.Text = "cnpj:";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(445, 391);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 24;
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(345, 420);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(19, 13);
            rgLabel.TabIndex = 25;
            rgLabel.Text = "rg:";
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "rg", true));
            this.rgTextBox.Location = new System.Drawing.Point(445, 417);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgTextBox.TabIndex = 26;
            // 
            // stateSubscriptionLabel
            // 
            stateSubscriptionLabel.AutoSize = true;
            stateSubscriptionLabel.Location = new System.Drawing.Point(345, 446);
            stateSubscriptionLabel.Name = "stateSubscriptionLabel";
            stateSubscriptionLabel.Size = new System.Drawing.Size(94, 13);
            stateSubscriptionLabel.TabIndex = 27;
            stateSubscriptionLabel.Text = "state Subscription:";
            // 
            // stateSubscriptionTextBox
            // 
            this.stateSubscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "stateSubscription", true));
            this.stateSubscriptionTextBox.Location = new System.Drawing.Point(445, 443);
            this.stateSubscriptionTextBox.Name = "stateSubscriptionTextBox";
            this.stateSubscriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateSubscriptionTextBox.TabIndex = 28;
            // 
            // CustomerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
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
    }
}