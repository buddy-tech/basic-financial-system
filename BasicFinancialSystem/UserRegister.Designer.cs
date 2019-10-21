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
            this.userRegisterExitButton = new System.Windows.Forms.Button();
            this.financialDataSet = new BasicFinancialSystem.FinancialDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new BasicFinancialSystem.FinancialDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new BasicFinancialSystem.FinancialDataSetTableAdapters.TableAdapterManager();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userRegisterCodeText = new System.Windows.Forms.TextBox();
            this.userRegisterNameText = new System.Windows.Forms.TextBox();
            this.userRegisterLevelText = new System.Windows.Forms.TextBox();
            this.userRegisterLoginText = new System.Windows.Forms.TextBox();
            this.userRegisterPasswordText = new System.Windows.Forms.TextBox();
            this.userRegisterSearchPanel = new System.Windows.Forms.Panel();
            this.uRPanelBillToReceiveButton = new System.Windows.Forms.Button();
            this.uRPanelBillToPayButton = new System.Windows.Forms.Button();
            this.uRPanelProviderButton = new System.Windows.Forms.Button();
            this.uRPanelCustomerButton = new System.Windows.Forms.Button();
            this.SearchPanelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userRegisterBackButton = new System.Windows.Forms.Button();
            this.userRegisterPrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.userRegisterSearchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRegisterCodeLabel
            // 
            this.userRegisterCodeLabel.AutoSize = true;
            this.userRegisterCodeLabel.BackColor = System.Drawing.Color.White;
            this.userRegisterCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterCodeLabel.Location = new System.Drawing.Point(78, 44);
            this.userRegisterCodeLabel.Name = "userRegisterCodeLabel";
            this.userRegisterCodeLabel.Size = new System.Drawing.Size(63, 21);
            this.userRegisterCodeLabel.TabIndex = 0;
            this.userRegisterCodeLabel.Text = "Código:";
            // 
            // userRegisterNameLabel
            // 
            this.userRegisterNameLabel.AutoSize = true;
            this.userRegisterNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterNameLabel.Location = new System.Drawing.Point(78, 103);
            this.userRegisterNameLabel.Name = "userRegisterNameLabel";
            this.userRegisterNameLabel.Size = new System.Drawing.Size(56, 21);
            this.userRegisterNameLabel.TabIndex = 2;
            this.userRegisterNameLabel.Text = "Nome:";
            // 
            // userRegisterLevelLabel
            // 
            this.userRegisterLevelLabel.AutoSize = true;
            this.userRegisterLevelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterLevelLabel.Location = new System.Drawing.Point(78, 159);
            this.userRegisterLevelLabel.Name = "userRegisterLevelLabel";
            this.userRegisterLevelLabel.Size = new System.Drawing.Size(49, 21);
            this.userRegisterLevelLabel.TabIndex = 4;
            this.userRegisterLevelLabel.Text = "Nível:";
            // 
            // userRegistrationLoginLabel
            // 
            this.userRegistrationLoginLabel.AutoSize = true;
            this.userRegistrationLoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegistrationLoginLabel.Location = new System.Drawing.Point(78, 216);
            this.userRegistrationLoginLabel.Name = "userRegistrationLoginLabel";
            this.userRegistrationLoginLabel.Size = new System.Drawing.Size(52, 21);
            this.userRegistrationLoginLabel.TabIndex = 6;
            this.userRegistrationLoginLabel.Text = "Login:";
            // 
            // userRegisterPasswordLabel
            // 
            this.userRegisterPasswordLabel.AutoSize = true;
            this.userRegisterPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterPasswordLabel.Location = new System.Drawing.Point(79, 274);
            this.userRegisterPasswordLabel.Name = "userRegisterPasswordLabel";
            this.userRegisterPasswordLabel.Size = new System.Drawing.Size(56, 21);
            this.userRegisterPasswordLabel.TabIndex = 8;
            this.userRegisterPasswordLabel.Text = "Senha:";
            // 
            // userRegisterPreviousButton
            // 
            this.userRegisterPreviousButton.BackColor = System.Drawing.Color.SteelBlue;
            this.userRegisterPreviousButton.FlatAppearance.BorderSize = 0;
            this.userRegisterPreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterPreviousButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterPreviousButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterPreviousButton.Location = new System.Drawing.Point(82, 349);
            this.userRegisterPreviousButton.Name = "userRegisterPreviousButton";
            this.userRegisterPreviousButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterPreviousButton.TabIndex = 10;
            this.userRegisterPreviousButton.Text = "Anterior";
            this.userRegisterPreviousButton.UseVisualStyleBackColor = false;
            this.userRegisterPreviousButton.Click += new System.EventHandler(this.userRegisterPreviousButton_Click);
            // 
            // userRegisterNextButton
            // 
            this.userRegisterNextButton.BackColor = System.Drawing.Color.SteelBlue;
            this.userRegisterNextButton.FlatAppearance.BorderSize = 0;
            this.userRegisterNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterNextButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterNextButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterNextButton.Location = new System.Drawing.Point(163, 349);
            this.userRegisterNextButton.Name = "userRegisterNextButton";
            this.userRegisterNextButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterNextButton.TabIndex = 11;
            this.userRegisterNextButton.Text = "Próximo";
            this.userRegisterNextButton.UseVisualStyleBackColor = false;
            // 
            // userRegisterNewButton
            // 
            this.userRegisterNewButton.BackColor = System.Drawing.Color.SteelBlue;
            this.userRegisterNewButton.FlatAppearance.BorderSize = 0;
            this.userRegisterNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterNewButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterNewButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterNewButton.Location = new System.Drawing.Point(244, 392);
            this.userRegisterNewButton.Name = "userRegisterNewButton";
            this.userRegisterNewButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterNewButton.TabIndex = 12;
            this.userRegisterNewButton.Text = "Novo";
            this.userRegisterNewButton.UseVisualStyleBackColor = false;
            // 
            // userRegisterEditButton
            // 
            this.userRegisterEditButton.BackColor = System.Drawing.Color.SteelBlue;
            this.userRegisterEditButton.FlatAppearance.BorderSize = 0;
            this.userRegisterEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterEditButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterEditButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterEditButton.Location = new System.Drawing.Point(82, 392);
            this.userRegisterEditButton.Name = "userRegisterEditButton";
            this.userRegisterEditButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterEditButton.TabIndex = 13;
            this.userRegisterEditButton.Text = "Editar";
            this.userRegisterEditButton.UseVisualStyleBackColor = false;
            // 
            // userRegisterDeleteButton
            // 
            this.userRegisterDeleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.userRegisterDeleteButton.FlatAppearance.BorderSize = 0;
            this.userRegisterDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterDeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterDeleteButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterDeleteButton.Location = new System.Drawing.Point(163, 392);
            this.userRegisterDeleteButton.Name = "userRegisterDeleteButton";
            this.userRegisterDeleteButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterDeleteButton.TabIndex = 14;
            this.userRegisterDeleteButton.Text = "Deletar";
            this.userRegisterDeleteButton.UseVisualStyleBackColor = false;
            this.userRegisterDeleteButton.Click += new System.EventHandler(this.userRegisterDeleteButton_Click);
            // 
            // userRegisterSaveButton
            // 
            this.userRegisterSaveButton.BackColor = System.Drawing.Color.SeaGreen;
            this.userRegisterSaveButton.FlatAppearance.BorderSize = 0;
            this.userRegisterSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterSaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterSaveButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterSaveButton.Location = new System.Drawing.Point(459, 392);
            this.userRegisterSaveButton.Name = "userRegisterSaveButton";
            this.userRegisterSaveButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterSaveButton.TabIndex = 15;
            this.userRegisterSaveButton.Text = "Salvar";
            this.userRegisterSaveButton.UseVisualStyleBackColor = false;
            this.userRegisterSaveButton.Click += new System.EventHandler(this.userRegisterSaveButton_Click);
            // 
            // userRegisterCancelButton
            // 
            this.userRegisterCancelButton.BackColor = System.Drawing.Color.Firebrick;
            this.userRegisterCancelButton.FlatAppearance.BorderSize = 0;
            this.userRegisterCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterCancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterCancelButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterCancelButton.Location = new System.Drawing.Point(552, 392);
            this.userRegisterCancelButton.Name = "userRegisterCancelButton";
            this.userRegisterCancelButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterCancelButton.TabIndex = 16;
            this.userRegisterCancelButton.Text = "Cancelar";
            this.userRegisterCancelButton.UseVisualStyleBackColor = false;
            // 
            // userRegisterSearchButton
            // 
            this.userRegisterSearchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.userRegisterSearchButton.FlatAppearance.BorderSize = 0;
            this.userRegisterSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterSearchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterSearchButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterSearchButton.Location = new System.Drawing.Point(244, 349);
            this.userRegisterSearchButton.Name = "userRegisterSearchButton";
            this.userRegisterSearchButton.Size = new System.Drawing.Size(75, 37);
            this.userRegisterSearchButton.TabIndex = 17;
            this.userRegisterSearchButton.Text = "Buscar";
            this.userRegisterSearchButton.UseVisualStyleBackColor = false;
            // 
            // userRegisterExitButton
            // 
            this.userRegisterExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.userRegisterExitButton.FlatAppearance.BorderSize = 0;
            this.userRegisterExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterExitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterExitButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterExitButton.Location = new System.Drawing.Point(42, 392);
            this.userRegisterExitButton.Name = "userRegisterExitButton";
            this.userRegisterExitButton.Size = new System.Drawing.Size(123, 37);
            this.userRegisterExitButton.TabIndex = 19;
            this.userRegisterExitButton.Text = "Sair";
            this.userRegisterExitButton.UseVisualStyleBackColor = false;
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
            this.userBindingNavigator.Size = new System.Drawing.Size(818, 25);
            this.userBindingNavigator.TabIndex = 20;
            this.userBindingNavigator.Text = "bindingNavigator1";
            this.userBindingNavigator.Visible = false;
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
            this.userRegisterCodeText.Location = new System.Drawing.Point(82, 70);
            this.userRegisterCodeText.Name = "userRegisterCodeText";
            this.userRegisterCodeText.Size = new System.Drawing.Size(57, 20);
            this.userRegisterCodeText.TabIndex = 22;
            // 
            // userRegisterNameText
            // 
            this.userRegisterNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "name", true));
            this.userRegisterNameText.Location = new System.Drawing.Point(82, 127);
            this.userRegisterNameText.Name = "userRegisterNameText";
            this.userRegisterNameText.Size = new System.Drawing.Size(290, 20);
            this.userRegisterNameText.TabIndex = 24;
            // 
            // userRegisterLevelText
            // 
            this.userRegisterLevelText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "level", true));
            this.userRegisterLevelText.Location = new System.Drawing.Point(82, 183);
            this.userRegisterLevelText.Name = "userRegisterLevelText";
            this.userRegisterLevelText.Size = new System.Drawing.Size(28, 20);
            this.userRegisterLevelText.TabIndex = 26;
            // 
            // userRegisterLoginText
            // 
            this.userRegisterLoginText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "login", true));
            this.userRegisterLoginText.Location = new System.Drawing.Point(82, 240);
            this.userRegisterLoginText.Name = "userRegisterLoginText";
            this.userRegisterLoginText.Size = new System.Drawing.Size(196, 20);
            this.userRegisterLoginText.TabIndex = 28;
            // 
            // userRegisterPasswordText
            // 
            this.userRegisterPasswordText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.userRegisterPasswordText.Location = new System.Drawing.Point(82, 298);
            this.userRegisterPasswordText.Name = "userRegisterPasswordText";
            this.userRegisterPasswordText.Size = new System.Drawing.Size(196, 20);
            this.userRegisterPasswordText.TabIndex = 30;
            this.userRegisterPasswordText.UseSystemPasswordChar = true;
            // 
            // userRegisterSearchPanel
            // 
            this.userRegisterSearchPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.userRegisterSearchPanel.Controls.Add(this.uRPanelBillToReceiveButton);
            this.userRegisterSearchPanel.Controls.Add(this.uRPanelBillToPayButton);
            this.userRegisterSearchPanel.Controls.Add(this.uRPanelProviderButton);
            this.userRegisterSearchPanel.Controls.Add(this.uRPanelCustomerButton);
            this.userRegisterSearchPanel.Controls.Add(this.SearchPanelLabel);
            this.userRegisterSearchPanel.Controls.Add(this.userRegisterExitButton);
            this.userRegisterSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userRegisterSearchPanel.Location = new System.Drawing.Point(654, 0);
            this.userRegisterSearchPanel.Name = "userRegisterSearchPanel";
            this.userRegisterSearchPanel.Size = new System.Drawing.Size(200, 493);
            this.userRegisterSearchPanel.TabIndex = 31;
            // 
            // uRPanelBillToReceiveButton
            // 
            this.uRPanelBillToReceiveButton.FlatAppearance.BorderSize = 0;
            this.uRPanelBillToReceiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRPanelBillToReceiveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRPanelBillToReceiveButton.ForeColor = System.Drawing.Color.White;
            this.uRPanelBillToReceiveButton.Location = new System.Drawing.Point(13, 274);
            this.uRPanelBillToReceiveButton.Name = "uRPanelBillToReceiveButton";
            this.uRPanelBillToReceiveButton.Size = new System.Drawing.Size(184, 51);
            this.uRPanelBillToReceiveButton.TabIndex = 23;
            this.uRPanelBillToReceiveButton.Text = "Cadastro de Contas a Receber";
            this.uRPanelBillToReceiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uRPanelBillToReceiveButton.UseVisualStyleBackColor = true;
            // 
            // uRPanelBillToPayButton
            // 
            this.uRPanelBillToPayButton.FlatAppearance.BorderSize = 0;
            this.uRPanelBillToPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRPanelBillToPayButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRPanelBillToPayButton.ForeColor = System.Drawing.Color.White;
            this.uRPanelBillToPayButton.Location = new System.Drawing.Point(12, 209);
            this.uRPanelBillToPayButton.Name = "uRPanelBillToPayButton";
            this.uRPanelBillToPayButton.Size = new System.Drawing.Size(187, 51);
            this.uRPanelBillToPayButton.TabIndex = 22;
            this.uRPanelBillToPayButton.Text = "Cadastro de Contas a Pagar";
            this.uRPanelBillToPayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uRPanelBillToPayButton.UseVisualStyleBackColor = true;
            // 
            // uRPanelProviderButton
            // 
            this.uRPanelProviderButton.FlatAppearance.BorderSize = 0;
            this.uRPanelProviderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRPanelProviderButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRPanelProviderButton.ForeColor = System.Drawing.Color.White;
            this.uRPanelProviderButton.Location = new System.Drawing.Point(12, 140);
            this.uRPanelProviderButton.Name = "uRPanelProviderButton";
            this.uRPanelProviderButton.Size = new System.Drawing.Size(187, 51);
            this.uRPanelProviderButton.TabIndex = 21;
            this.uRPanelProviderButton.Text = "Cadastro de Fornecedores";
            this.uRPanelProviderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uRPanelProviderButton.UseVisualStyleBackColor = true;
            // 
            // uRPanelCustomerButton
            // 
            this.uRPanelCustomerButton.FlatAppearance.BorderSize = 0;
            this.uRPanelCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRPanelCustomerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRPanelCustomerButton.ForeColor = System.Drawing.Color.White;
            this.uRPanelCustomerButton.Location = new System.Drawing.Point(13, 84);
            this.uRPanelCustomerButton.Name = "uRPanelCustomerButton";
            this.uRPanelCustomerButton.Size = new System.Drawing.Size(186, 40);
            this.uRPanelCustomerButton.TabIndex = 20;
            this.uRPanelCustomerButton.Text = "Cadastro de Clientes";
            this.uRPanelCustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uRPanelCustomerButton.UseVisualStyleBackColor = true;
            // 
            // SearchPanelLabel
            // 
            this.SearchPanelLabel.AutoSize = true;
            this.SearchPanelLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPanelLabel.ForeColor = System.Drawing.Color.White;
            this.SearchPanelLabel.Location = new System.Drawing.Point(13, 35);
            this.SearchPanelLabel.Name = "SearchPanelLabel";
            this.SearchPanelLabel.Size = new System.Drawing.Size(140, 30);
            this.SearchPanelLabel.TabIndex = 0;
            this.SearchPanelLabel.Text = "Veja também:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userRegisterBackButton);
            this.panel1.Controls.Add(this.userRegisterCodeText);
            this.panel1.Controls.Add(this.userRegisterLoginText);
            this.panel1.Controls.Add(this.userRegisterPasswordText);
            this.panel1.Controls.Add(this.userRegisterPrintButton);
            this.panel1.Controls.Add(this.userRegisterLevelText);
            this.panel1.Controls.Add(this.userRegisterNameText);
            this.panel1.Controls.Add(this.userRegisterNameLabel);
            this.panel1.Controls.Add(this.userRegisterCodeLabel);
            this.panel1.Controls.Add(this.userRegisterPasswordLabel);
            this.panel1.Controls.Add(this.userRegisterLevelLabel);
            this.panel1.Controls.Add(this.userRegistrationLoginLabel);
            this.panel1.Controls.Add(this.userRegisterSearchButton);
            this.panel1.Controls.Add(this.userRegisterDeleteButton);
            this.panel1.Controls.Add(this.userRegisterCancelButton);
            this.panel1.Controls.Add(this.userRegisterPreviousButton);
            this.panel1.Controls.Add(this.userRegisterSaveButton);
            this.panel1.Controls.Add(this.userRegisterNextButton);
            this.panel1.Controls.Add(this.userRegisterNewButton);
            this.panel1.Controls.Add(this.userRegisterEditButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 493);
            this.panel1.TabIndex = 32;
            // 
            // userRegisterBackButton
            // 
            this.userRegisterBackButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.userRegisterBackButton.FlatAppearance.BorderSize = 0;
            this.userRegisterBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterBackButton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegisterBackButton.ForeColor = System.Drawing.Color.White;
            this.userRegisterBackButton.Location = new System.Drawing.Point(-1, 0);
            this.userRegisterBackButton.Name = "userRegisterBackButton";
            this.userRegisterBackButton.Size = new System.Drawing.Size(53, 42);
            this.userRegisterBackButton.TabIndex = 31;
            this.userRegisterBackButton.Text = "<-";
            this.userRegisterBackButton.UseVisualStyleBackColor = false;
            this.userRegisterBackButton.Click += new System.EventHandler(this.userRegisterBackButton_Click);
            // 
            // userRegisterPrintButton
            // 
            this.userRegisterPrintButton.FlatAppearance.BorderSize = 0;
            this.userRegisterPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRegisterPrintButton.Image = ((System.Drawing.Image)(resources.GetObject("userRegisterPrintButton.Image")));
            this.userRegisterPrintButton.Location = new System.Drawing.Point(562, 44);
            this.userRegisterPrintButton.Name = "userRegisterPrintButton";
            this.userRegisterPrintButton.Size = new System.Drawing.Size(65, 46);
            this.userRegisterPrintButton.TabIndex = 18;
            this.userRegisterPrintButton.UseVisualStyleBackColor = true;
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 493);
            this.Controls.Add(this.userRegisterSearchPanel);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.UserRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.userRegisterSearchPanel.ResumeLayout(false);
            this.userRegisterSearchPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label userRegisterCodeLabel;
        private System.Windows.Forms.Panel userRegisterSearchPanel;
        private System.Windows.Forms.Label SearchPanelLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userRegisterPrintButton;
        private System.Windows.Forms.Button uRPanelBillToReceiveButton;
        private System.Windows.Forms.Button uRPanelBillToPayButton;
        private System.Windows.Forms.Button uRPanelProviderButton;
        private System.Windows.Forms.Button uRPanelCustomerButton;
        private System.Windows.Forms.Button userRegisterBackButton;
    }
}