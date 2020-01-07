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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpChores = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxChores = new System.Windows.Forms.ListBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.rtbComplaint = new System.Windows.Forms.RichTextBox();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tpChores.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.tpTenants.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpChores);
            this.tabControl1.Controls.Add(this.tpComplaints);
            this.tabControl1.Controls.Add(this.tpRules);
            this.tabControl1.Controls.Add(this.tpTenants);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tpChores
            // 
            this.tpChores.Controls.Add(this.label1);
            this.tpChores.Controls.Add(this.lbxChores);
            this.tpChores.Location = new System.Drawing.Point(4, 22);
            this.tpChores.Name = "tpChores";
            this.tpChores.Padding = new System.Windows.Forms.Padding(3);
            this.tpChores.Size = new System.Drawing.Size(776, 409);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chores List";
            // 
            // lbxChores
            // 
            this.lbxChores.FormattingEnabled = true;
            this.lbxChores.Location = new System.Drawing.Point(263, 78);
            this.lbxChores.Name = "lbxChores";
            this.lbxChores.Size = new System.Drawing.Size(229, 264);
            this.lbxChores.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.Controls.Add(this.rtbComplaint);
            this.tpComplaints.Controls.Add(this.btnClearSelected);
            this.tpComplaints.Controls.Add(this.btnClearAll);
            this.tpComplaints.Controls.Add(this.btnNext);
            this.tpComplaints.Controls.Add(this.btnPrevious);
            this.tpComplaints.Controls.Add(this.label2);
            this.tpComplaints.Location = new System.Drawing.Point(4, 22);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3);
            this.tpComplaints.Size = new System.Drawing.Size(776, 409);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // rtbComplaint
            // 
            this.rtbComplaint.Enabled = false;
            this.rtbComplaint.Location = new System.Drawing.Point(207, 58);
            this.rtbComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.rtbComplaint.Name = "rtbComplaint";
            this.rtbComplaint.Size = new System.Drawing.Size(258, 273);
            this.rtbComplaint.TabIndex = 7;
            this.rtbComplaint.Text = "";
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSelected.Location = new System.Drawing.Point(496, 175);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(75, 52);
            this.btnClearSelected.TabIndex = 5;
            this.btnClearSelected.Text = "Clear Selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(493, 291);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(78, 40);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(388, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(207, 342);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 40);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complaints";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.label10);
            this.tpRules.Controls.Add(this.label5);
            this.tpRules.Controls.Add(this.btnRemoveSelected);
            this.tpRules.Controls.Add(this.btnRemoveAll);
            this.tpRules.Controls.Add(this.lbxRules);
            this.tpRules.Controls.Add(this.btnAddToList);
            this.tpRules.Controls.Add(this.rtbRulesToAdd);
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Margin = new System.Windows.Forms.Padding(2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(2);
            this.tpRules.Size = new System.Drawing.Size(776, 409);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Rules";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Write the rule";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(454, 314);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(105, 48);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(640, 314);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(104, 48);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.Location = new System.Drawing.Point(454, 46);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(290, 238);
            this.lbxRules.TabIndex = 2;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.Location = new System.Drawing.Point(128, 314);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(98, 48);
            this.btnAddToList.TabIndex = 1;
            this.btnAddToList.Text = "Add To List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // rtbRulesToAdd
            // 
            this.rtbRulesToAdd.Location = new System.Drawing.Point(17, 46);
            this.rtbRulesToAdd.Name = "rtbRulesToAdd";
            this.rtbRulesToAdd.Size = new System.Drawing.Size(331, 236);
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
            this.tpTenants.Location = new System.Drawing.Point(4, 22);
            this.tpTenants.Name = "tpTenants";
            this.tpTenants.Padding = new System.Windows.Forms.Padding(3);
            this.tpTenants.Size = new System.Drawing.Size(776, 409);
            this.tpTenants.TabIndex = 3;
            this.tpTenants.Text = "Tenants";
            this.tpTenants.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTenant
            // 
            this.btnRemoveTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTenant.Location = new System.Drawing.Point(650, 329);
            this.btnRemoveTenant.Name = "btnRemoveTenant";
            this.btnRemoveTenant.Size = new System.Drawing.Size(106, 53);
            this.btnRemoveTenant.TabIndex = 16;
            this.btnRemoveTenant.Text = "Remove Tenant";
            this.btnRemoveTenant.UseVisualStyleBackColor = true;
            this.btnRemoveTenant.Click += new System.EventHandler(this.btnRemoveTenant_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(526, 329);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(105, 53);
            this.btnShowInfo.TabIndex = 15;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lbxTenants
            // 
            this.lbxTenants.FormattingEnabled = true;
            this.lbxTenants.Location = new System.Drawing.Point(526, 78);
            this.lbxTenants.Name = "lbxTenants";
            this.lbxTenants.Size = new System.Drawing.Size(230, 238);
            this.lbxTenants.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(613, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tenants";
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTenant.Location = new System.Drawing.Point(218, 214);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(106, 41);
            this.btnAddTenant.TabIndex = 12;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "School";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(371, 85);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(128, 20);
            this.tbxAge.TabIndex = 5;
            // 
            // tbxCourse
            // 
            this.tbxCourse.Location = new System.Drawing.Point(206, 154);
            this.tbxCourse.Name = "tbxCourse";
            this.tbxCourse.Size = new System.Drawing.Size(128, 20);
            this.tbxCourse.TabIndex = 4;
            // 
            // tbxSchool
            // 
            this.tbxSchool.Location = new System.Drawing.Point(25, 154);
            this.tbxSchool.Name = "tbxSchool";
            this.tbxSchool.Size = new System.Drawing.Size(128, 20);
            this.tbxSchool.TabIndex = 3;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(206, 85);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(128, 20);
            this.tbxLastName.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(25, 85);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(128, 20);
            this.tbxFirstName.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 423);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "HouseMate";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpChores.ResumeLayout(false);
            this.tpChores.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.tpComplaints.PerformLayout();
            this.tpRules.ResumeLayout(false);
            this.tpRules.PerformLayout();
            this.tpTenants.ResumeLayout(false);
            this.tpTenants.PerformLayout();
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
        private System.Windows.Forms.RichTextBox rtbComplaint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
    }
}