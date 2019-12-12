namespace Software_housing_project
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpChores = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxChores = new System.Windows.Forms.ListBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lbxRules = new System.Windows.Forms.ListBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.rtbRulesToAdd = new System.Windows.Forms.RichTextBox();
            this.tpTenants = new System.Windows.Forms.TabPage();
            this.btnRemoveTenant = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lbxTenants = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxCourse = new System.Windows.Forms.TextBox();
            this.tbxSchool = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rtbComplaint = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tpChores.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.tpTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpChores);
            this.tabControl1.Controls.Add(this.tpComplaints);
            this.tabControl1.Controls.Add(this.tpRules);
            this.tabControl1.Controls.Add(this.tpTenants);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 669);
            this.tabControl1.TabIndex = 1;
            // 
            // tpChores
            // 
            this.tpChores.Controls.Add(this.label1);
            this.tpChores.Controls.Add(this.lbxChores);
            this.tpChores.Location = new System.Drawing.Point(4, 29);
            this.tpChores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpChores.Name = "tpChores";
            this.tpChores.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpChores.Size = new System.Drawing.Size(1168, 636);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chores List";
            // 
            // lbxChores
            // 
            this.lbxChores.FormattingEnabled = true;
            this.lbxChores.ItemHeight = 20;
            this.lbxChores.Location = new System.Drawing.Point(386, 154);
            this.lbxChores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxChores.Name = "lbxChores";
            this.lbxChores.Size = new System.Drawing.Size(342, 404);
            this.lbxChores.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.Controls.Add(this.rtbComplaint);
            this.tpComplaints.Controls.Add(this.bindingNavigator1);
            this.tpComplaints.Controls.Add(this.btnClearSelected);
            this.tpComplaints.Controls.Add(this.btnClearAll);
            this.tpComplaints.Controls.Add(this.btnNext);
            this.tpComplaints.Controls.Add(this.btnPrevious);
            this.tpComplaints.Controls.Add(this.label2);
            this.tpComplaints.Location = new System.Drawing.Point(4, 29);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpComplaints.Size = new System.Drawing.Size(1168, 636);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(744, 269);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(108, 62);
            this.btnClearSelected.TabIndex = 5;
            this.btnClearSelected.Text = "Clear Selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(884, 540);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(112, 35);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(582, 540);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(310, 540);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 35);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complaints";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.btnRemoveSelected);
            this.tpRules.Controls.Add(this.btnRemoveAll);
            this.tpRules.Controls.Add(this.lbxRules);
            this.tpRules.Controls.Add(this.btnAddToList);
            this.tpRules.Controls.Add(this.rtbRulesToAdd);
            this.tpRules.Location = new System.Drawing.Point(4, 29);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpRules.Size = new System.Drawing.Size(1168, 636);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(926, 483);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(158, 74);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(722, 483);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(160, 74);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.ItemHeight = 20;
            this.lbxRules.Location = new System.Drawing.Point(682, 71);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(434, 364);
            this.lbxRules.TabIndex = 2;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(180, 483);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(146, 74);
            this.btnAddToList.TabIndex = 1;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // rtbRulesToAdd
            // 
            this.rtbRulesToAdd.Location = new System.Drawing.Point(26, 71);
            this.rtbRulesToAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbRulesToAdd.Name = "rtbRulesToAdd";
            this.rtbRulesToAdd.Size = new System.Drawing.Size(494, 362);
            this.rtbRulesToAdd.TabIndex = 0;
            this.rtbRulesToAdd.Text = "";
            // 
            // tpTenants
            // 
            this.tpTenants.Controls.Add(this.btnRemoveTenant);
            this.tpTenants.Controls.Add(this.btnShowInfo);
            this.tpTenants.Controls.Add(this.lbxTenants);
            this.tpTenants.Controls.Add(this.label9);
            this.tpTenants.Controls.Add(this.btnAddTenant);
            this.tpTenants.Controls.Add(this.label8);
            this.tpTenants.Controls.Add(this.label7);
            this.tpTenants.Controls.Add(this.label6);
            this.tpTenants.Controls.Add(this.label4);
            this.tpTenants.Controls.Add(this.label3);
            this.tpTenants.Controls.Add(this.tbxAge);
            this.tpTenants.Controls.Add(this.tbxCourse);
            this.tpTenants.Controls.Add(this.tbxSchool);
            this.tpTenants.Controls.Add(this.tbxLastName);
            this.tpTenants.Controls.Add(this.tbxFirstName);
            this.tpTenants.Location = new System.Drawing.Point(4, 29);
            this.tpTenants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpTenants.Name = "tpTenants";
            this.tpTenants.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpTenants.Size = new System.Drawing.Size(1168, 636);
            this.tpTenants.TabIndex = 3;
            this.tpTenants.Text = "Tenants";
            this.tpTenants.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Location = new System.Drawing.Point(975, 525);
            this.btnRemoveTenant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(160, 62);
            this.btnRemoveTenant.TabIndex = 16;
            this.btnRemoveTenant.Text = "Remove Tenant";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.btnRemoveTenant_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(790, 525);
            this.btnShowInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(160, 62);
            this.btnShowInfo.TabIndex = 15;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lbxTenants
            // 
            this.lbxTenants.FormattingEnabled = true;
            this.lbxTenants.ItemHeight = 20;
            this.lbxTenants.Location = new System.Drawing.Point(790, 120);
            this.lbxTenants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxTenants.Name = "lbxTenants";
            this.lbxTenants.Size = new System.Drawing.Size(343, 364);
            this.lbxTenants.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(934, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tenants";
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Location = new System.Drawing.Point(309, 525);
            this.btnAddTenant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(160, 62);
            this.btnAddTenant.TabIndex = 12;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "School";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(291, 357);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(190, 26);
            this.tbxAge.TabIndex = 5;
            // 
            // tbxCourse
            // 
            this.tbxCourse.Location = new System.Drawing.Point(464, 234);
            this.tbxCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxCourse.Name = "tbxCourse";
            this.tbxCourse.Size = new System.Drawing.Size(175, 26);
            this.tbxCourse.TabIndex = 4;
            // 
            // tbxSchool
            // 
            this.tbxSchool.Location = new System.Drawing.Point(134, 234);
            this.tbxSchool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSchool.Name = "tbxSchool";
            this.tbxSchool.Size = new System.Drawing.Size(190, 26);
            this.tbxSchool.TabIndex = 3;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(464, 120);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(190, 26);
            this.tbxLastName.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(134, 120);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(175, 26);
            this.tbxFirstName.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 5);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1160, 27);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // rtbComplaint
            // 
            this.rtbComplaint.Location = new System.Drawing.Point(310, 90);
            this.rtbComplaint.Name = "rtbComplaint";
            this.rtbComplaint.Size = new System.Drawing.Size(384, 418);
            this.rtbComplaint.TabIndex = 7;
            this.rtbComplaint.Text = "";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeForm";
            this.Text = "HouseMate";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpChores.ResumeLayout(false);
            this.tpChores.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.tpComplaints.PerformLayout();
            this.tpRules.ResumeLayout(false);
            this.tpTenants.ResumeLayout(false);
            this.tpTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpChores;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpTenants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxChores;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.ListBox lbxRules;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.RichTextBox rtbRulesToAdd;
        private System.Windows.Forms.Button btnRemoveTenant;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.ListBox lbxTenants;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxCourse;
        private System.Windows.Forms.TextBox tbxSchool;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.RichTextBox rtbComplaint;
    }
}