namespace Software_housing_project
{
    partial class StudentForm
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
            this.tcTabControl = new System.Windows.Forms.TabControl();
            this.tpChores = new System.Windows.Forms.TabPage();
            this.clbChores = new System.Windows.Forms.CheckedListBox();
            this.btnAddChore = new System.Windows.Forms.Button();
            this.mcChore = new System.Windows.Forms.MonthCalendar();
            this.cbxChore = new System.Windows.Forms.ComboBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rtbComplaints = new System.Windows.Forms.RichTextBox();
            this.mcComplaint = new System.Windows.Forms.MonthCalendar();
            this.btnFileComplaint = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.lbxRules = new System.Windows.Forms.ListBox();
            this.tcTabControl.SuspendLayout();
            this.tpChores.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTabControl
            // 
            this.tcTabControl.Controls.Add(this.tpChores);
            this.tcTabControl.Controls.Add(this.tpComplaints);
            this.tcTabControl.Controls.Add(this.tpRules);
            this.tcTabControl.Location = new System.Drawing.Point(3, 11);
            this.tcTabControl.Name = "tcTabControl";
            this.tcTabControl.SelectedIndex = 0;
            this.tcTabControl.Size = new System.Drawing.Size(633, 353);
            this.tcTabControl.TabIndex = 0;
            // 
            // tpChores
            // 
            this.tpChores.Controls.Add(this.clbChores);
            this.tpChores.Controls.Add(this.btnAddChore);
            this.tpChores.Controls.Add(this.mcChore);
            this.tpChores.Controls.Add(this.cbxChore);
            this.tpChores.Controls.Add(this.cbxName);
            this.tpChores.Location = new System.Drawing.Point(4, 22);
            this.tpChores.Name = "tpChores";
            this.tpChores.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpChores.Size = new System.Drawing.Size(625, 327);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            // 
            // clbChores
            // 
            this.clbChores.FormattingEnabled = true;
            this.clbChores.Location = new System.Drawing.Point(390, 31);
            this.clbChores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbChores.Name = "clbChores";
            this.clbChores.Size = new System.Drawing.Size(198, 244);
            this.clbChores.TabIndex = 4;
            // 
            // btnAddChore
            // 
            this.btnAddChore.Location = new System.Drawing.Point(17, 275);
            this.btnAddChore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(106, 32);
            this.btnAddChore.TabIndex = 3;
            this.btnAddChore.Text = "Add Chore";
            this.btnAddChore.UseVisualStyleBackColor = true;
            // 
            // mcChore
            // 
            this.mcChore.Location = new System.Drawing.Point(165, 31);
            this.mcChore.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mcChore.Name = "mcChore";
            this.mcChore.TabIndex = 2;
            // 
            // cbxChore
            // 
            this.cbxChore.FormattingEnabled = true;
            this.cbxChore.Location = new System.Drawing.Point(17, 63);
            this.cbxChore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxChore.Name = "cbxChore";
            this.cbxChore.Size = new System.Drawing.Size(108, 21);
            this.cbxChore.TabIndex = 1;
            this.cbxChore.Text = "Chore";
            // 
            // cbxName
            // 
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(17, 31);
            this.cbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(108, 21);
            this.cbxName.TabIndex = 0;
            this.cbxName.Text = "Your Name";
            // 
            // tpComplaints
            // 
            this.tpComplaints.Controls.Add(this.btnNext);
            this.tpComplaints.Controls.Add(this.btnPrevious);
            this.tpComplaints.Controls.Add(this.rtbComplaints);
            this.tpComplaints.Controls.Add(this.mcComplaint);
            this.tpComplaints.Controls.Add(this.btnFileComplaint);
            this.tpComplaints.Controls.Add(this.rtbDescription);
            this.tpComplaints.Location = new System.Drawing.Point(4, 22);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpComplaints.Size = new System.Drawing.Size(625, 327);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(551, 279);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 19);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(410, 279);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 19);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // rtbComplaints
            // 
            this.rtbComplaints.Location = new System.Drawing.Point(410, 20);
            this.rtbComplaints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbComplaints.Name = "rtbComplaints";
            this.rtbComplaints.Size = new System.Drawing.Size(198, 244);
            this.rtbComplaints.TabIndex = 3;
            this.rtbComplaints.Text = "Complaint";
            // 
            // mcComplaint
            // 
            this.mcComplaint.Location = new System.Drawing.Point(191, 20);
            this.mcComplaint.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mcComplaint.Name = "mcComplaint";
            this.mcComplaint.TabIndex = 2;
            // 
            // btnFileComplaint
            // 
            this.btnFileComplaint.Location = new System.Drawing.Point(13, 279);
            this.btnFileComplaint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileComplaint.Name = "btnFileComplaint";
            this.btnFileComplaint.Size = new System.Drawing.Size(122, 33);
            this.btnFileComplaint.TabIndex = 1;
            this.btnFileComplaint.Text = "File Complaint";
            this.btnFileComplaint.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(13, 20);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(184, 244);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "Description";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.lbxRules);
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRules.Size = new System.Drawing.Size(625, 327);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.Location = new System.Drawing.Point(171, 31);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(282, 277);
            this.lbxRules.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.tcTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentForm";
            this.Text = "HouseMate";
            this.tcTabControl.ResumeLayout(false);
            this.tpChores.ResumeLayout(false);
            this.tpComplaints.ResumeLayout(false);
            this.tpRules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabControl;
        private System.Windows.Forms.TabPage tpChores;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.CheckedListBox clbChores;
        private System.Windows.Forms.Button btnAddChore;
        private System.Windows.Forms.MonthCalendar mcChore;
        private System.Windows.Forms.ComboBox cbxChore;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.RichTextBox rtbComplaints;
        private System.Windows.Forms.MonthCalendar mcComplaint;
        private System.Windows.Forms.Button btnFileComplaint;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.ListBox lbxRules;
    }
}

