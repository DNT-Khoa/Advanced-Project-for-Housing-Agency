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
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.tpTenants = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpChores);
            this.tabControl1.Controls.Add(this.tpComplaints);
            this.tabControl1.Controls.Add(this.tpRules);
            this.tabControl1.Controls.Add(this.tpTenants);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tpChores
            // 
            this.tpChores.Location = new System.Drawing.Point(4, 22);
            this.tpChores.Name = "tpChores";
            this.tpChores.Padding = new System.Windows.Forms.Padding(3);
            this.tpChores.Size = new System.Drawing.Size(776, 409);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            // 
            // tpComplaints
            // 
            this.tpComplaints.Location = new System.Drawing.Point(4, 22);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3);
            this.tpComplaints.Size = new System.Drawing.Size(776, 409);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // tpRules
            // 
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Margin = new System.Windows.Forms.Padding(2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(2);
            this.tpRules.Size = new System.Drawing.Size(776, 409);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // tpTenants
            // 
            this.tpTenants.Location = new System.Drawing.Point(4, 22);
            this.tpTenants.Name = "tpTenants";
            this.tpTenants.Padding = new System.Windows.Forms.Padding(3);
            this.tpTenants.Size = new System.Drawing.Size(776, 409);
            this.tpTenants.TabIndex = 3;
            this.tpTenants.Text = "Tenants";
            this.tpTenants.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeForm";
            this.Text = "HouseMate";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpChores;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpTenants;
    }
}