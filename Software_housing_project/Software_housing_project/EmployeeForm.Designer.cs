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
            this.tpTenants = new System.Windows.Forms.TabPage();
            this.rtbComplaint = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tpChores.SuspendLayout();
            this.tpComplaints.SuspendLayout();
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
            this.btnClearSelected.Text = "Clear\r\nSelected";
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
            this.tpRules.Location = new System.Drawing.Point(4, 29);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpRules.Size = new System.Drawing.Size(1168, 636);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // tpTenants
            // 
            this.tpTenants.Location = new System.Drawing.Point(4, 29);
            this.tpTenants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpTenants.Name = "tpTenants";
            this.tpTenants.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpTenants.Size = new System.Drawing.Size(1168, 636);
            this.tpTenants.TabIndex = 3;
            this.tpTenants.Text = "Tenants";
            this.tpTenants.UseVisualStyleBackColor = true;
            // 
            // rtbComplaint
            // 
            this.rtbComplaint.Location = new System.Drawing.Point(310, 106);
            this.rtbComplaint.Name = "rtbComplaint";
            this.rtbComplaint.Size = new System.Drawing.Size(384, 396);
            this.rtbComplaint.TabIndex = 6;
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
        private System.Windows.Forms.RichTextBox rtbComplaint;
    }
}