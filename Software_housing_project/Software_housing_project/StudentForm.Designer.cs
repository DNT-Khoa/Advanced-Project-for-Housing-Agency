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
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowInfoEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.rtbEventDescription = new System.Windows.Forms.RichTextBox();
            this.tbxEventTitle = new System.Windows.Forms.TextBox();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.mcEvents = new System.Windows.Forms.MonthCalendar();
            this.clbEvents = new System.Windows.Forms.CheckedListBox();
            this.tcTabControl.SuspendLayout();
            this.tpChores.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTabControl
            // 
            this.tcTabControl.Controls.Add(this.tpChores);
            this.tcTabControl.Controls.Add(this.tpComplaints);
            this.tcTabControl.Controls.Add(this.tpRules);
            this.tcTabControl.Controls.Add(this.tpEvents);
            this.tcTabControl.Location = new System.Drawing.Point(3, 12);
            this.tcTabControl.Name = "tcTabControl";
            this.tcTabControl.SelectedIndex = 0;
            this.tcTabControl.Size = new System.Drawing.Size(728, 353);
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
            this.tpChores.Size = new System.Drawing.Size(720, 327);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            // 
            // clbChores
            // 
            this.clbChores.FormattingEnabled = true;
            this.clbChores.Location = new System.Drawing.Point(401, 31);
            this.clbChores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbChores.Name = "clbChores";
            this.clbChores.Size = new System.Drawing.Size(302, 229);
            this.clbChores.TabIndex = 4;
            this.clbChores.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbChores_ItemCheck);
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
            this.btnAddChore.Click += new System.EventHandler(this.btnAddChore_Click);
            // 
            // mcChore
            // 
            this.mcChore.Location = new System.Drawing.Point(165, 31);
            this.mcChore.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mcChore.MaxSelectionCount = 1;
            this.mcChore.Name = "mcChore";
            this.mcChore.TabIndex = 2;
            // 
            // cbxChore
            // 
            this.cbxChore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChore.FormattingEnabled = true;
            this.cbxChore.Location = new System.Drawing.Point(17, 63);
            this.cbxChore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxChore.Name = "cbxChore";
            this.cbxChore.Size = new System.Drawing.Size(139, 21);
            this.cbxChore.TabIndex = 1;
            // 
            // cbxName
            // 
            this.cbxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(17, 31);
            this.cbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(139, 21);
            this.cbxName.TabIndex = 0;
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
            this.tpComplaints.Size = new System.Drawing.Size(720, 327);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(635, 279);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 19);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rtbComplaints
            // 
            this.rtbComplaints.Location = new System.Drawing.Point(427, 20);
            this.rtbComplaints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbComplaints.Name = "rtbComplaints";
            this.rtbComplaints.Size = new System.Drawing.Size(264, 244);
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
            this.btnFileComplaint.Click += new System.EventHandler(this.btnFileComplaint_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(13, 20);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(169, 244);
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
            this.tpRules.Size = new System.Drawing.Size(720, 327);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.Location = new System.Drawing.Point(225, 31);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(282, 277);
            this.lbxRules.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.label2);
            this.tpEvents.Controls.Add(this.label1);
            this.tpEvents.Controls.Add(this.btnShowInfoEvent);
            this.tpEvents.Controls.Add(this.btnAddEvent);
            this.tpEvents.Controls.Add(this.rtbEventDescription);
            this.tpEvents.Controls.Add(this.tbxEventTitle);
            this.tpEvents.Controls.Add(this.tbxStudentID);
            this.tpEvents.Controls.Add(this.tbxStudentName);
            this.tpEvents.Controls.Add(this.mcEvents);
            this.tpEvents.Controls.Add(this.clbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(720, 327);
            this.tpEvents.TabIndex = 3;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Date";
            // 
            // btnShowInfoEvent
            // 
            this.btnShowInfoEvent.Location = new System.Drawing.Point(467, 271);
            this.btnShowInfoEvent.Name = "btnShowInfoEvent";
            this.btnShowInfoEvent.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfoEvent.TabIndex = 7;
            this.btnShowInfoEvent.Text = "Show Info";
            this.btnShowInfoEvent.UseVisualStyleBackColor = true;
            this.btnShowInfoEvent.Click += new System.EventHandler(this.btnShowInfoEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(177, 271);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // rtbEventDescription
            // 
            this.rtbEventDescription.Location = new System.Drawing.Point(14, 185);
            this.rtbEventDescription.Name = "rtbEventDescription";
            this.rtbEventDescription.Size = new System.Drawing.Size(155, 109);
            this.rtbEventDescription.TabIndex = 5;
            this.rtbEventDescription.Text = "Description";
            // 
            // tbxEventTitle
            // 
            this.tbxEventTitle.Location = new System.Drawing.Point(14, 127);
            this.tbxEventTitle.Name = "tbxEventTitle";
            this.tbxEventTitle.Size = new System.Drawing.Size(100, 20);
            this.tbxEventTitle.TabIndex = 4;
            this.tbxEventTitle.Text = "Event Title";
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(14, 82);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentID.TabIndex = 3;
            this.tbxStudentID.Text = "Student ID";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(14, 27);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentName.TabIndex = 2;
            this.tbxStudentName.Text = "Your Name";
            // 
            // mcEvents
            // 
            this.mcEvents.Location = new System.Drawing.Point(177, 49);
            this.mcEvents.Name = "mcEvents";
            this.mcEvents.TabIndex = 1;
            // 
            // clbEvents
            // 
            this.clbEvents.FormattingEnabled = true;
            this.clbEvents.Location = new System.Drawing.Point(416, 53);
            this.clbEvents.Name = "clbEvents";
            this.clbEvents.Size = new System.Drawing.Size(288, 139);
            this.clbEvents.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 366);
            this.Controls.Add(this.tcTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentForm";
            this.Text = "HouseMate";
            this.tcTabControl.ResumeLayout(false);
            this.tpChores.ResumeLayout(false);
            this.tpComplaints.ResumeLayout(false);
            this.tpRules.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
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
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.Button btnShowInfoEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.RichTextBox rtbEventDescription;
        private System.Windows.Forms.TextBox tbxEventTitle;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.MonthCalendar mcEvents;
        private System.Windows.Forms.CheckedListBox clbEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

