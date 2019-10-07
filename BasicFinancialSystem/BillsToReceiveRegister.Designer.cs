namespace BasicFinancialSystem
{
    partial class BillsToReceiveRegister
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label issuanceLabel;
            System.Windows.Forms.Label expiryLabel;
            System.Windows.Forms.Label billLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label paidLabel;
            System.Windows.Forms.Label observationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsToReceiveRegister));
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.billToReceiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billToReceiveTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.BillToReceiveTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.billToReceiveBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.billToReceiveBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.issuanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paidTextBox = new System.Windows.Forms.TextBox();
            this.observationTextBox = new System.Windows.Forms.TextBox();
            this.billsToReceiveRegisterPreviousButton = new System.Windows.Forms.Button();
            this.billsToReceiveRegisterNextButton = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            issuanceLabel = new System.Windows.Forms.Label();
            expiryLabel = new System.Windows.Forms.Label();
            billLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToReceiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToReceiveBindingNavigator)).BeginInit();
            this.billToReceiveBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(58, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // issuanceLabel
            // 
            issuanceLabel.AutoSize = true;
            issuanceLabel.Location = new System.Drawing.Point(58, 103);
            issuanceLabel.Name = "issuanceLabel";
            issuanceLabel.Size = new System.Drawing.Size(52, 13);
            issuanceLabel.TabIndex = 3;
            issuanceLabel.Text = "issuance:";
            // 
            // expiryLabel
            // 
            expiryLabel.AutoSize = true;
            expiryLabel.Location = new System.Drawing.Point(58, 129);
            expiryLabel.Name = "expiryLabel";
            expiryLabel.Size = new System.Drawing.Size(37, 13);
            expiryLabel.TabIndex = 5;
            expiryLabel.Text = "expiry:";
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Location = new System.Drawing.Point(58, 154);
            billLabel.Name = "billLabel";
            billLabel.Size = new System.Drawing.Size(22, 13);
            billLabel.TabIndex = 7;
            billLabel.Text = "bill:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(58, 180);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(53, 13);
            customerLabel.TabIndex = 9;
            customerLabel.Text = "customer:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(58, 207);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(50, 13);
            paymentLabel.TabIndex = 11;
            paymentLabel.Text = "payment:";
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new System.Drawing.Point(58, 232);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(30, 13);
            paidLabel.TabIndex = 13;
            paidLabel.Text = "paid:";
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(58, 258);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(65, 13);
            observationLabel.TabIndex = 15;
            observationLabel.Text = "observation:";
            // 
            // financialDataSet
            // 
            this.financialDataSet.DataSetName = "FinancialDataSet";
            this.financialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billToReceiveBindingSource
            // 
            this.billToReceiveBindingSource.DataMember = "BillToReceive";
            this.billToReceiveBindingSource.DataSource = this.financialDataSet;
            // 
            // billToReceiveTableAdapter
            // 
            this.billToReceiveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillToPayTableAdapter = null;
            this.tableAdapterManager.BillToReceiveTableAdapter = this.billToReceiveTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // billToReceiveBindingNavigator
            // 
            this.billToReceiveBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.billToReceiveBindingNavigator.BindingSource = this.billToReceiveBindingSource;
            this.billToReceiveBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billToReceiveBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.billToReceiveBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.billToReceiveBindingNavigatorSaveItem});
            this.billToReceiveBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.billToReceiveBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billToReceiveBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billToReceiveBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billToReceiveBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billToReceiveBindingNavigator.Name = "billToReceiveBindingNavigator";
            this.billToReceiveBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billToReceiveBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.billToReceiveBindingNavigator.TabIndex = 0;
            this.billToReceiveBindingNavigator.Text = "bindingNavigator1";
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
            // billToReceiveBindingNavigatorSaveItem
            // 
            this.billToReceiveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.billToReceiveBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("billToReceiveBindingNavigatorSaveItem.Image")));
            this.billToReceiveBindingNavigatorSaveItem.Name = "billToReceiveBindingNavigatorSaveItem";
            this.billToReceiveBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.billToReceiveBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.billToReceiveBindingNavigatorSaveItem.Click += new System.EventHandler(this.billToReceiveBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToReceiveBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(129, 73);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // issuanceDateTimePicker
            // 
            this.issuanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billToReceiveBindingSource, "issuance", true));
            this.issuanceDateTimePicker.Location = new System.Drawing.Point(129, 99);
            this.issuanceDateTimePicker.Name = "issuanceDateTimePicker";
            this.issuanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issuanceDateTimePicker.TabIndex = 4;
            // 
            // expiryDateTimePicker
            // 
            this.expiryDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billToReceiveBindingSource, "expiry", true));
            this.expiryDateTimePicker.Location = new System.Drawing.Point(129, 125);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expiryDateTimePicker.TabIndex = 6;
            // 
            // billTextBox
            // 
            this.billTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToReceiveBindingSource, "bill", true));
            this.billTextBox.Location = new System.Drawing.Point(129, 151);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(200, 20);
            this.billTextBox.TabIndex = 8;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToReceiveBindingSource, "customer", true));
            this.customerTextBox.Location = new System.Drawing.Point(129, 177);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerTextBox.TabIndex = 10;
            // 
            // paymentDateTimePicker
            // 
            this.paymentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billToReceiveBindingSource, "payment", true));
            this.paymentDateTimePicker.Location = new System.Drawing.Point(129, 203);
            this.paymentDateTimePicker.Name = "paymentDateTimePicker";
            this.paymentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paymentDateTimePicker.TabIndex = 12;
            // 
            // paidTextBox
            // 
            this.paidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToReceiveBindingSource, "paid", true));
            this.paidTextBox.Location = new System.Drawing.Point(129, 229);
            this.paidTextBox.Name = "paidTextBox";
            this.paidTextBox.Size = new System.Drawing.Size(200, 20);
            this.paidTextBox.TabIndex = 14;
            // 
            // observationTextBox
            // 
            this.observationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToReceiveBindingSource, "observation", true));
            this.observationTextBox.Location = new System.Drawing.Point(129, 255);
            this.observationTextBox.Name = "observationTextBox";
            this.observationTextBox.Size = new System.Drawing.Size(200, 20);
            this.observationTextBox.TabIndex = 16;
            // 
            // billsToReceiveRegisterPreviousButton
            // 
            this.billsToReceiveRegisterPreviousButton.Location = new System.Drawing.Point(61, 293);
            this.billsToReceiveRegisterPreviousButton.Name = "billsToReceiveRegisterPreviousButton";
            this.billsToReceiveRegisterPreviousButton.Size = new System.Drawing.Size(75, 23);
            this.billsToReceiveRegisterPreviousButton.TabIndex = 17;
            this.billsToReceiveRegisterPreviousButton.Text = "Previous";
            this.billsToReceiveRegisterPreviousButton.UseVisualStyleBackColor = true;
            // 
            // billsToReceiveRegisterNextButton
            // 
            this.billsToReceiveRegisterNextButton.Location = new System.Drawing.Point(143, 293);
            this.billsToReceiveRegisterNextButton.Name = "billsToReceiveRegisterNextButton";
            this.billsToReceiveRegisterNextButton.Size = new System.Drawing.Size(75, 23);
            this.billsToReceiveRegisterNextButton.TabIndex = 18;
            this.billsToReceiveRegisterNextButton.Text = "Next";
            this.billsToReceiveRegisterNextButton.UseVisualStyleBackColor = true;
            // 
            // BillsToReceiveRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billsToReceiveRegisterNextButton);
            this.Controls.Add(this.billsToReceiveRegisterPreviousButton);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(issuanceLabel);
            this.Controls.Add(this.issuanceDateTimePicker);
            this.Controls.Add(expiryLabel);
            this.Controls.Add(this.expiryDateTimePicker);
            this.Controls.Add(billLabel);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(customerLabel);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentDateTimePicker);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidTextBox);
            this.Controls.Add(observationLabel);
            this.Controls.Add(this.observationTextBox);
            this.Controls.Add(this.billToReceiveBindingNavigator);
            this.Name = "BillsToReceiveRegister";
            this.Text = "BillsToReceiveRegister";
            this.Load += new System.EventHandler(this.BillsToReceiveRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToReceiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToReceiveBindingNavigator)).EndInit();
            this.billToReceiveBindingNavigator.ResumeLayout(false);
            this.billToReceiveBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinancialDataSet financialDataSet;
        private System.Windows.Forms.BindingSource billToReceiveBindingSource;
        private FinancialDataSetTableAdapters.BillToReceiveTableAdapter billToReceiveTableAdapter;
        private FinancialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator billToReceiveBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton billToReceiveBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker issuanceDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.DateTimePicker paymentDateTimePicker;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.TextBox observationTextBox;
        private System.Windows.Forms.Button billsToReceiveRegisterPreviousButton;
        private System.Windows.Forms.Button billsToReceiveRegisterNextButton;
    }
}