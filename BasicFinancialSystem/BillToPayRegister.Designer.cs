namespace BasicFinancialSystem
{
    partial class BillToPayRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillToPayRegister));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label issuanceLabel;
            System.Windows.Forms.Label expiryLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label providerLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label paidLabel;
            System.Windows.Forms.Label observationLabel;
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.billToPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billToPayTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.BillToPayTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.billToPayBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.billToPayBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.issuanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paidTextBox = new System.Windows.Forms.TextBox();
            this.observationTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            issuanceLabel = new System.Windows.Forms.Label();
            expiryLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            providerLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToPayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToPayBindingNavigator)).BeginInit();
            this.billToPayBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // financialDataSet
            // 
            this.financialDataSet.DataSetName = "FinancialDataSet";
            this.financialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billToPayBindingSource
            // 
            this.billToPayBindingSource.DataMember = "BillToPay";
            this.billToPayBindingSource.DataSource = this.financialDataSet;
            // 
            // billToPayTableAdapter
            // 
            this.billToPayTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillToPayTableAdapter = this.billToPayTableAdapter;
            this.tableAdapterManager.BillToReceiveTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // billToPayBindingNavigator
            // 
            this.billToPayBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.billToPayBindingNavigator.BindingSource = this.billToPayBindingSource;
            this.billToPayBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billToPayBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.billToPayBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.billToPayBindingNavigatorSaveItem});
            this.billToPayBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.billToPayBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billToPayBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billToPayBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billToPayBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billToPayBindingNavigator.Name = "billToPayBindingNavigator";
            this.billToPayBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billToPayBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.billToPayBindingNavigator.TabIndex = 0;
            this.billToPayBindingNavigator.Text = "bindingNavigator1";
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
            // billToPayBindingNavigatorSaveItem
            // 
            this.billToPayBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.billToPayBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("billToPayBindingNavigatorSaveItem.Image")));
            this.billToPayBindingNavigatorSaveItem.Name = "billToPayBindingNavigatorSaveItem";
            this.billToPayBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.billToPayBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.billToPayBindingNavigatorSaveItem.Click += new System.EventHandler(this.billToPayBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(55, 71);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToPayBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(126, 68);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // issuanceLabel
            // 
            issuanceLabel.AutoSize = true;
            issuanceLabel.Location = new System.Drawing.Point(55, 98);
            issuanceLabel.Name = "issuanceLabel";
            issuanceLabel.Size = new System.Drawing.Size(52, 13);
            issuanceLabel.TabIndex = 3;
            issuanceLabel.Text = "issuance:";
            // 
            // issuanceDateTimePicker
            // 
            this.issuanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billToPayBindingSource, "issuance", true));
            this.issuanceDateTimePicker.Location = new System.Drawing.Point(126, 94);
            this.issuanceDateTimePicker.Name = "issuanceDateTimePicker";
            this.issuanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issuanceDateTimePicker.TabIndex = 4;
            // 
            // expiryLabel
            // 
            expiryLabel.AutoSize = true;
            expiryLabel.Location = new System.Drawing.Point(55, 124);
            expiryLabel.Name = "expiryLabel";
            expiryLabel.Size = new System.Drawing.Size(37, 13);
            expiryLabel.TabIndex = 5;
            expiryLabel.Text = "expiry:";
            // 
            // expiryDateTimePicker
            // 
            this.expiryDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billToPayBindingSource, "expiry", true));
            this.expiryDateTimePicker.Location = new System.Drawing.Point(126, 120);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expiryDateTimePicker.TabIndex = 6;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(55, 149);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(36, 13);
            valueLabel.TabIndex = 7;
            valueLabel.Text = "value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToPayBindingSource, "value", true));
            this.valueTextBox.Location = new System.Drawing.Point(126, 146);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 20);
            this.valueTextBox.TabIndex = 8;
            // 
            // providerLabel
            // 
            providerLabel.AutoSize = true;
            providerLabel.Location = new System.Drawing.Point(55, 175);
            providerLabel.Name = "providerLabel";
            providerLabel.Size = new System.Drawing.Size(48, 13);
            providerLabel.TabIndex = 9;
            providerLabel.Text = "provider:";
            // 
            // providerTextBox
            // 
            this.providerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToPayBindingSource, "provider", true));
            this.providerTextBox.Location = new System.Drawing.Point(126, 172);
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(200, 20);
            this.providerTextBox.TabIndex = 10;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(55, 202);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(50, 13);
            paymentLabel.TabIndex = 11;
            paymentLabel.Text = "payment:";
            // 
            // paymentDateTimePicker
            // 
            this.paymentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billToPayBindingSource, "payment", true));
            this.paymentDateTimePicker.Location = new System.Drawing.Point(126, 198);
            this.paymentDateTimePicker.Name = "paymentDateTimePicker";
            this.paymentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paymentDateTimePicker.TabIndex = 12;
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new System.Drawing.Point(55, 227);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(30, 13);
            paidLabel.TabIndex = 13;
            paidLabel.Text = "paid:";
            // 
            // paidTextBox
            // 
            this.paidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToPayBindingSource, "paid", true));
            this.paidTextBox.Location = new System.Drawing.Point(126, 224);
            this.paidTextBox.Name = "paidTextBox";
            this.paidTextBox.Size = new System.Drawing.Size(200, 20);
            this.paidTextBox.TabIndex = 14;
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(55, 253);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(65, 13);
            observationLabel.TabIndex = 15;
            observationLabel.Text = "observation:";
            // 
            // observationTextBox
            // 
            this.observationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billToPayBindingSource, "observation", true));
            this.observationTextBox.Location = new System.Drawing.Point(126, 250);
            this.observationTextBox.Name = "observationTextBox";
            this.observationTextBox.Size = new System.Drawing.Size(200, 20);
            this.observationTextBox.TabIndex = 16;
            // 
            // BillToPayRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(issuanceLabel);
            this.Controls.Add(this.issuanceDateTimePicker);
            this.Controls.Add(expiryLabel);
            this.Controls.Add(this.expiryDateTimePicker);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(providerLabel);
            this.Controls.Add(this.providerTextBox);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentDateTimePicker);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidTextBox);
            this.Controls.Add(observationLabel);
            this.Controls.Add(this.observationTextBox);
            this.Controls.Add(this.billToPayBindingNavigator);
            this.Name = "BillToPayRegister";
            this.Text = "BillToPayRegister";
            this.Load += new System.EventHandler(this.BillToPayRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToPayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billToPayBindingNavigator)).EndInit();
            this.billToPayBindingNavigator.ResumeLayout(false);
            this.billToPayBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinancialDataSet financialDataSet;
        private System.Windows.Forms.BindingSource billToPayBindingSource;
        private FinancialDataSetTableAdapters.BillToPayTableAdapter billToPayTableAdapter;
        private FinancialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator billToPayBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton billToPayBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker issuanceDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox providerTextBox;
        private System.Windows.Forms.DateTimePicker paymentDateTimePicker;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.TextBox observationTextBox;
    }
}