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
            this.clbChores = new System.Windows.Forms.ListBox();
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
            this.tcTabControl.Location = new System.Drawing.Point(4, 15);
            this.tcTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcTabControl.Name = "tcTabControl";
            this.tcTabControl.SelectedIndex = 0;
            this.tcTabControl.Size = new System.Drawing.Size(971, 434);
            this.tcTabControl.TabIndex = 0;
            // 
            // tpChores
            // 
            this.tpChores.Controls.Add(this.clbChores);
            this.tpChores.Controls.Add(this.btnAddChore);
            this.tpChores.Controls.Add(this.mcChore);
            this.tpChores.Controls.Add(this.cbxChore);
            this.tpChores.Controls.Add(this.cbxName);
            this.tpChores.Location = new System.Drawing.Point(4, 25);
            this.tpChores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpChores.Name = "tpChores";
            this.tpChores.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpChores.Size = new System.Drawing.Size(963, 405);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            this.tpChores.DoubleClick += new System.EventHandler(this.tpChores_DoubleClick);
            // 
            // clbChores
            // 
            this.clbChores.FormattingEnabled = true;
            this.clbChores.ItemHeight = 16;
            this.clbChores.Location = new System.Drawing.Point(549, 38);
            this.clbChores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbChores.Name = "clbChores";
            this.clbChores.Size = new System.Drawing.Size(401, 276);
            this.clbChores.TabIndex = 4;
            this.clbChores.DoubleClick += new System.EventHandler(this.clbChores_DoubleClick);
            // 
            // btnAddChore
            // 
            this.btnAddChore.Location = new System.Drawing.Point(23, 338);
            this.btnAddChore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(141, 39);
            this.btnAddChore.TabIndex = 3;
            this.btnAddChore.Text = "Add Chore";
            this.btnAddChore.UseVisualStyleBackColor = true;
            this.btnAddChore.Click += new System.EventHandler(this.btnAddChore_Click);
            // 
            // mcChore
            // 
            this.mcChore.Location = new System.Drawing.Point(220, 38);
            this.mcChore.MaxSelectionCount = 1;
            this.mcChore.Name = "mcChore";
            this.mcChore.TabIndex = 2;
            // 
            // cbxChore
            // 
            this.cbxChore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChore.FormattingEnabled = true;
            this.cbxChore.Location = new System.Drawing.Point(23, 78);
            this.cbxChore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChore.Name = "cbxChore";
            this.cbxChore.Size = new System.Drawing.Size(184, 24);
            this.cbxChore.TabIndex = 1;
            // 
            // cbxName
            // 
            this.cbxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(23, 38);
            this.cbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(184, 24);
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
            this.tpComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpComplaints.Size = new System.Drawing.Size(963, 405);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(847, 343);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(547, 343);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rtbComplaints
            // 
            this.rtbComplaints.Location = new System.Drawing.Point(569, 25);
            this.rtbComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbComplaints.Name = "rtbComplaints";
            this.rtbComplaints.Size = new System.Drawing.Size(351, 299);
            this.rtbComplaints.TabIndex = 3;
            this.rtbComplaints.Text = "Complaint";
            // 
            // mcComplaint
            // 
            this.mcComplaint.Location = new System.Drawing.Point(255, 25);
            this.mcComplaint.Name = "mcComplaint";
            this.mcComplaint.TabIndex = 2;
            // 
            // btnFileComplaint
            // 
            this.btnFileComplaint.Location = new System.Drawing.Point(17, 343);
            this.btnFileComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFileComplaint.Name = "btnFileComplaint";
            this.btnFileComplaint.Size = new System.Drawing.Size(163, 41);
            this.btnFileComplaint.TabIndex = 1;
            this.btnFileComplaint.Text = "File Complaint";
            this.btnFileComplaint.UseVisualStyleBackColor = true;
            this.btnFileComplaint.Click += new System.EventHandler(this.btnFileComplaint_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(17, 25);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(224, 299);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "Description";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.lbxRules);
            this.tpRules.Location = new System.Drawing.Point(4, 25);
            this.tpRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRules.Size = new System.Drawing.Size(963, 405);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.ItemHeight = 16;
            this.lbxRules.Location = new System.Drawing.Point(300, 38);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(375, 340);
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
            this.tpEvents.Location = new System.Drawing.Point(4, 25);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(963, 405);
            this.tpEvents.TabIndex = 3;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Date";
            // 
            // btnShowInfoEvent
            // 
            this.btnShowInfoEvent.Location = new System.Drawing.Point(623, 334);
            this.btnShowInfoEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowInfoEvent.Name = "btnShowInfoEvent";
            this.btnShowInfoEvent.Size = new System.Drawing.Size(100, 28);
            this.btnShowInfoEvent.TabIndex = 7;
            this.btnShowInfoEvent.Text = "Show Info";
            this.btnShowInfoEvent.UseVisualStyleBackColor = true;
            this.btnShowInfoEvent.Click += new System.EventHandler(this.btnShowInfoEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(236, 334);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(100, 28);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // rtbEventDescription
            // 
            this.rtbEventDescription.Location = new System.Drawing.Point(19, 228);
            this.rtbEventDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbEventDescription.Name = "rtbEventDescription";
            this.rtbEventDescription.Size = new System.Drawing.Size(205, 133);
            this.rtbEventDescription.TabIndex = 5;
            this.rtbEventDescription.Text = "Description";
            // 
            // tbxEventTitle
            // 
            this.tbxEventTitle.Location = new System.Drawing.Point(19, 156);
            this.tbxEventTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEventTitle.Name = "tbxEventTitle";
            this.tbxEventTitle.Size = new System.Drawing.Size(132, 22);
            this.tbxEventTitle.TabIndex = 4;
            this.tbxEventTitle.Text = "Event Title";
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(19, 101);
            this.tbxStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(132, 22);
            this.tbxStudentID.TabIndex = 3;
            this.tbxStudentID.Text = "Student ID";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(19, 33);
            this.tbxStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(132, 22);
            this.tbxStudentName.TabIndex = 2;
            this.tbxStudentName.Text = "Your Name";
            // 
            // mcEvents
            // 
            this.mcEvents.Location = new System.Drawing.Point(236, 60);
            this.mcEvents.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcEvents.Name = "mcEvents";
            this.mcEvents.TabIndex = 1;
            // 
            // clbEvents
            // 
            this.clbEvents.FormattingEnabled = true;
            this.clbEvents.Location = new System.Drawing.Point(555, 65);
            this.clbEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbEvents.Name = "clbEvents";
            this.clbEvents.Size = new System.Drawing.Size(383, 157);
            this.clbEvents.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.tcTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListBox clbChores;
    }
}

