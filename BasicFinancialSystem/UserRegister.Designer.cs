namespace BasicFinancialSystem
{
    partial class UserRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterForm));
            this.userRegisterCodeLabel = new System.Windows.Forms.Label();
            this.userRegisterNameLabel = new System.Windows.Forms.Label();
            this.userRegisterLevelLabel = new System.Windows.Forms.Label();
            this.userRegistrationLoginLabel = new System.Windows.Forms.Label();
            this.userRegisterPasswordLabel = new System.Windows.Forms.Label();
            this.userRegisterPreviousButton = new System.Windows.Forms.Button();
            this.userRegisterNextButton = new System.Windows.Forms.Button();
            this.userRegisterNewButton = new System.Windows.Forms.Button();
            this.userRegisterEditButton = new System.Windows.Forms.Button();
            this.userRegisterDeleteButton = new System.Windows.Forms.Button();
            this.userRegisterSaveButton = new System.Windows.Forms.Button();
            this.userRegisterCancelButton = new System.Windows.Forms.Button();
            this.userRegisterSearchButton = new System.Windows.Forms.Button();
            this.userRegisterPrintButton = new System.Windows.Forms.Button();
            this.userRegisterExitButton = new System.Windows.Forms.Button();
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userRegisterCodeText = new System.Windows.Forms.TextBox();
            this.userRegisterNameText = new System.Windows.Forms.TextBox();
            this.userRegisterLevelText = new System.Windows.Forms.TextBox();
            this.userRegisterLoginText = new System.Windows.Forms.TextBox();
            this.userRegisterPasswordText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRegisterCodeLabel
            // 
            this.userRegisterCodeLabel.AutoSize = true;
            this.userRegisterCodeLabel.Location = new System.Drawing.Point(60, 65);
            this.userRegisterCodeLabel.Name = "userRegisterCodeLabel";
            this.userRegisterCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.userRegisterCodeLabel.TabIndex = 0;
            this.userRegisterCodeLabel.Text = "Code:";
            // 
            // userRegisterNameLabel
            // 
            this.userRegisterNameLabel.AutoSize = true;
            this.userRegisterNameLabel.Location = new System.Drawing.Point(57, 104);
            this.userRegisterNameLabel.Name = "userRegisterNameLabel";
            this.userRegisterNameLabel.Size = new System.Drawing.Size(38, 13);
            this.userRegisterNameLabel.TabIndex = 2;
            this.userRegisterNameLabel.Text = "Name:";
            // 
            // userRegisterLevelLabel
            // 
            this.userRegisterLevelLabel.AutoSize = true;
            this.userRegisterLevelLabel.Location = new System.Drawing.Point(57, 146);
            this.userRegisterLevelLabel.Name = "userRegisterLevelLabel";
            this.userRegisterLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.userRegisterLevelLabel.TabIndex = 4;
            this.userRegisterLevelLabel.Text = "Level:";
            // 
            // userRegistrationLoginLabel
            // 
            this.userRegistrationLoginLabel.AutoSize = true;
            this.userRegistrationLoginLabel.Location = new System.Drawing.Point(60, 185);
            this.userRegistrationLoginLabel.Name = "userRegistrationLoginLabel";
            this.userRegistrationLoginLabel.Size = new System.Drawing.Size(36, 13);
            this.userRegistrationLoginLabel.TabIndex = 6;
            this.userRegistrationLoginLabel.Text = "Login:";
            // 
            // userRegisterPasswordLabel
            // 
            this.userRegisterPasswordLabel.AutoSize = true;
            this.userRegisterPasswordLabel.Location = new System.Drawing.Point(60, 223);
            this.userRegisterPasswordLabel.Name = "userRegisterPasswordLabel";
            this.userRegisterPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.userRegisterPasswordLabel.TabIndex = 8;
            this.userRegisterPasswordLabel.Text = "Password:";
            // 
            // userRegisterPreviousButton
            // 
            this.userRegisterPreviousButton.Location = new System.Drawing.Point(60, 325);
            this.userRegisterPreviousButton.Name = "userRegisterPreviousButton";
            this.userRegisterPreviousButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterPreviousButton.TabIndex = 10;
            this.userRegisterPreviousButton.Text = "Previous";
            this.userRegisterPreviousButton.UseVisualStyleBackColor = true;
            this.userRegisterPreviousButton.Click += new System.EventHandler(this.userRegisterPreviousButton_Click);
            // 
            // userRegisterNextButton
            // 
            this.userRegisterNextButton.Location = new System.Drawing.Point(141, 325);
            this.userRegisterNextButton.Name = "userRegisterNextButton";
            this.userRegisterNextButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterNextButton.TabIndex = 11;
            this.userRegisterNextButton.Text = "Next";
            this.userRegisterNextButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterNewButton
            // 
            this.userRegisterNewButton.Location = new System.Drawing.Point(222, 325);
            this.userRegisterNewButton.Name = "userRegisterNewButton";
            this.userRegisterNewButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterNewButton.TabIndex = 12;
            this.userRegisterNewButton.Text = "New";
            this.userRegisterNewButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterEditButton
            // 
            this.userRegisterEditButton.Location = new System.Drawing.Point(304, 325);
            this.userRegisterEditButton.Name = "userRegisterEditButton";
            this.userRegisterEditButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterEditButton.TabIndex = 13;
            this.userRegisterEditButton.Text = "Edit";
            this.userRegisterEditButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterDeleteButton
            // 
            this.userRegisterDeleteButton.Location = new System.Drawing.Point(385, 325);
            this.userRegisterDeleteButton.Name = "userRegisterDeleteButton";
            this.userRegisterDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterDeleteButton.TabIndex = 14;
            this.userRegisterDeleteButton.Text = "Delete";
            this.userRegisterDeleteButton.UseVisualStyleBackColor = true;
            this.userRegisterDeleteButton.Click += new System.EventHandler(this.userRegisterDeleteButton_Click);
            // 
            // userRegisterSaveButton
            // 
            this.userRegisterSaveButton.Location = new System.Drawing.Point(60, 355);
            this.userRegisterSaveButton.Name = "userRegisterSaveButton";
            this.userRegisterSaveButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterSaveButton.TabIndex = 15;
            this.userRegisterSaveButton.Text = "Save";
            this.userRegisterSaveButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterCancelButton
            // 
            this.userRegisterCancelButton.Location = new System.Drawing.Point(142, 355);
            this.userRegisterCancelButton.Name = "userRegisterCancelButton";
            this.userRegisterCancelButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterCancelButton.TabIndex = 16;
            this.userRegisterCancelButton.Text = "Cancel";
            this.userRegisterCancelButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterSearchButton
            // 
            this.userRegisterSearchButton.Location = new System.Drawing.Point(224, 355);
            this.userRegisterSearchButton.Name = "userRegisterSearchButton";
            this.userRegisterSearchButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterSearchButton.TabIndex = 17;
            this.userRegisterSearchButton.Text = "Search";
            this.userRegisterSearchButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterPrintButton
            // 
            this.userRegisterPrintButton.Location = new System.Drawing.Point(306, 355);
            this.userRegisterPrintButton.Name = "userRegisterPrintButton";
            this.userRegisterPrintButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterPrintButton.TabIndex = 18;
            this.userRegisterPrintButton.Text = "Print";
            this.userRegisterPrintButton.UseVisualStyleBackColor = true;
            // 
            // userRegisterExitButton
            // 
            this.userRegisterExitButton.Location = new System.Drawing.Point(388, 355);
            this.userRegisterExitButton.Name = "userRegisterExitButton";
            this.userRegisterExitButton.Size = new System.Drawing.Size(75, 23);
            this.userRegisterExitButton.TabIndex = 19;
            this.userRegisterExitButton.Text = "Exit";
            this.userRegisterExitButton.UseVisualStyleBackColor = true;
            this.userRegisterExitButton.Click += new System.EventHandler(this.userRegisterExitButton_Click);
            // 
            // financialDataSet
            // 
            this.financialDataSet.DataSetName = "FinancialDataSet";
            this.financialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.financialDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillToPayTableAdapter = null;
            this.tableAdapterManager.BillToReceiveTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.userBindingNavigator.TabIndex = 20;
            this.userBindingNavigator.Text = "bindingNavigator1";
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
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
            // 
            // userRegisterCodeText
            // 
            this.userRegisterCodeText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "id", true));
            this.userRegisterCodeText.Location = new System.Drawing.Point(103, 62);
            this.userRegisterCodeText.Name = "userRegisterCodeText";
            this.userRegisterCodeText.Size = new System.Drawing.Size(100, 20);
            this.userRegisterCodeText.TabIndex = 22;
            // 
            // userRegisterNameText
            // 
            this.userRegisterNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "name", true));
            this.userRegisterNameText.Location = new System.Drawing.Point(101, 101);
            this.userRegisterNameText.Name = "userRegisterNameText";
            this.userRegisterNameText.Size = new System.Drawing.Size(100, 20);
            this.userRegisterNameText.TabIndex = 24;
            // 
            // userRegisterLevelText
            // 
            this.userRegisterLevelText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "level", true));
            this.userRegisterLevelText.Location = new System.Drawing.Point(99, 143);
            this.userRegisterLevelText.Name = "userRegisterLevelText";
            this.userRegisterLevelText.Size = new System.Drawing.Size(100, 20);
            this.userRegisterLevelText.TabIndex = 26;
            // 
            // userRegisterLoginText
            // 
            this.userRegisterLoginText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "login", true));
            this.userRegisterLoginText.Location = new System.Drawing.Point(101, 182);
            this.userRegisterLoginText.Name = "userRegisterLoginText";
            this.userRegisterLoginText.Size = new System.Drawing.Size(100, 20);
            this.userRegisterLoginText.TabIndex = 28;
            // 
            // userRegisterPasswordText
            // 
            this.userRegisterPasswordText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.userRegisterPasswordText.Location = new System.Drawing.Point(122, 220);
            this.userRegisterPasswordText.Name = "userRegisterPasswordText";
            this.userRegisterPasswordText.Size = new System.Drawing.Size(100, 20);
            this.userRegisterPasswordText.TabIndex = 30;
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userRegisterCodeText);
            this.Controls.Add(this.userRegisterNameText);
            this.Controls.Add(this.userRegisterLevelText);
            this.Controls.Add(this.userRegisterLoginText);
            this.Controls.Add(this.userRegisterPasswordText);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.userRegisterExitButton);
            this.Controls.Add(this.userRegisterPrintButton);
            this.Controls.Add(this.userRegisterSearchButton);
            this.Controls.Add(this.userRegisterCancelButton);
            this.Controls.Add(this.userRegisterSaveButton);
            this.Controls.Add(this.userRegisterDeleteButton);
            this.Controls.Add(this.userRegisterEditButton);
            this.Controls.Add(this.userRegisterNewButton);
            this.Controls.Add(this.userRegisterNextButton);
            this.Controls.Add(this.userRegisterPreviousButton);
            this.Controls.Add(this.userRegisterPasswordLabel);
            this.Controls.Add(this.userRegistrationLoginLabel);
            this.Controls.Add(this.userRegisterLevelLabel);
            this.Controls.Add(this.userRegisterNameLabel);
            this.Controls.Add(this.userRegisterCodeLabel);
            this.Name = "UserRegisterForm";
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.UserRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userRegisterCodeLabel;
        private System.Windows.Forms.Label userRegisterNameLabel;
        private System.Windows.Forms.Label userRegisterLevelLabel;
        private System.Windows.Forms.Label userRegistrationLoginLabel;
        private System.Windows.Forms.Label userRegisterPasswordLabel;
        private System.Windows.Forms.Button userRegisterPreviousButton;
        private System.Windows.Forms.Button userRegisterNextButton;
        private System.Windows.Forms.Button userRegisterNewButton;
        private System.Windows.Forms.Button userRegisterEditButton;
        private System.Windows.Forms.Button userRegisterDeleteButton;
        private System.Windows.Forms.Button userRegisterSaveButton;
        private System.Windows.Forms.Button userRegisterCancelButton;
        private System.Windows.Forms.Button userRegisterSearchButton;
        private System.Windows.Forms.Button userRegisterPrintButton;
        private System.Windows.Forms.Button userRegisterExitButton;
        private FinancialDataSet financialDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private FinancialDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private FinancialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox userRegisterCodeText;
        private System.Windows.Forms.TextBox userRegisterNameText;
        private System.Windows.Forms.TextBox userRegisterLevelText;
        private System.Windows.Forms.TextBox userRegisterLoginText;
        private System.Windows.Forms.TextBox userRegisterPasswordText;
    }
}