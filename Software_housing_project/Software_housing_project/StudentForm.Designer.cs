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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.tcTabControl = new System.Windows.Forms.TabControl();
            this.tpChores = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clbChores = new System.Windows.Forms.ListBox();
            this.btnAddChore = new System.Windows.Forms.Button();
            this.mcChore = new System.Windows.Forms.MonthCalendar();
            this.cbxChore = new System.Windows.Forms.ComboBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rtbComplaints = new System.Windows.Forms.RichTextBox();
            this.mcComplaint = new System.Windows.Forms.MonthCalendar();
            this.btnFileComplaint = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxRules = new System.Windows.Forms.ListBox();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEventHost = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowInfoEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.rtbEventDescription = new System.Windows.Forms.RichTextBox();
            this.tbxEventTitle = new System.Windows.Forms.TextBox();
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
            this.tcTabControl.Size = new System.Drawing.Size(728, 356);
            this.tcTabControl.TabIndex = 0;
            // 
            // tpChores
            // 
            this.tpChores.Controls.Add(this.label11);
            this.tpChores.Controls.Add(this.label10);
            this.tpChores.Controls.Add(this.clbChores);
            this.tpChores.Controls.Add(this.btnAddChore);
            this.tpChores.Controls.Add(this.mcChore);
            this.tpChores.Controls.Add(this.cbxChore);
            this.tpChores.Controls.Add(this.cbxName);
            this.tpChores.Location = new System.Drawing.Point(4, 22);
            this.tpChores.Name = "tpChores";
            this.tpChores.Padding = new System.Windows.Forms.Padding(3);
            this.tpChores.Size = new System.Drawing.Size(720, 330);
            this.tpChores.TabIndex = 0;
            this.tpChores.Text = "Chores";
            this.tpChores.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Select Chore";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Select student";
            // 
            // clbChores
            // 
            this.clbChores.FormattingEnabled = true;
            this.clbChores.Location = new System.Drawing.Point(412, 31);
            this.clbChores.Name = "clbChores";
            this.clbChores.Size = new System.Drawing.Size(302, 225);
            this.clbChores.TabIndex = 4;
            this.clbChores.DoubleClick += new System.EventHandler(this.clbChores_DoubleClick);
            // 
            // btnAddChore
            // 
            this.btnAddChore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChore.Location = new System.Drawing.Point(17, 197);
            this.btnAddChore.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(115, 59);
            this.btnAddChore.TabIndex = 3;
            this.btnAddChore.Text = "Add Chore";
            this.btnAddChore.UseVisualStyleBackColor = true;
            this.btnAddChore.Click += new System.EventHandler(this.btnAddChore_Click);
            // 
            // mcChore
            // 
            this.mcChore.Location = new System.Drawing.Point(165, 31);
            this.mcChore.Margin = new System.Windows.Forms.Padding(7);
            this.mcChore.MaxSelectionCount = 1;
            this.mcChore.Name = "mcChore";
            this.mcChore.TabIndex = 2;
            // 
            // cbxChore
            // 
            this.cbxChore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChore.FormattingEnabled = true;
            this.cbxChore.Location = new System.Drawing.Point(17, 147);
            this.cbxChore.Margin = new System.Windows.Forms.Padding(2);
            this.cbxChore.Name = "cbxChore";
            this.cbxChore.Size = new System.Drawing.Size(115, 21);
            this.cbxChore.TabIndex = 1;
            // 
            // cbxName
            // 
            this.cbxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(17, 62);
            this.cbxName.Margin = new System.Windows.Forms.Padding(2);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(115, 21);
            this.cbxName.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.Controls.Add(this.label5);
            this.tpComplaints.Controls.Add(this.label4);
            this.tpComplaints.Controls.Add(this.label3);
            this.tpComplaints.Controls.Add(this.btnNext);
            this.tpComplaints.Controls.Add(this.btnPrevious);
            this.tpComplaints.Controls.Add(this.rtbComplaints);
            this.tpComplaints.Controls.Add(this.mcComplaint);
            this.tpComplaints.Controls.Add(this.btnFileComplaint);
            this.tpComplaints.Controls.Add(this.rtbDescription);
            this.tpComplaints.Location = new System.Drawing.Point(4, 22);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3);
            this.tpComplaints.Size = new System.Drawing.Size(720, 330);
            this.tpComplaints.TabIndex = 1;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select a date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Complaints";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(619, 279);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 42);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(427, 279);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(65, 42);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rtbComplaints
            // 
            this.rtbComplaints.Location = new System.Drawing.Point(427, 46);
            this.rtbComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.rtbComplaints.Name = "rtbComplaints";
            this.rtbComplaints.Size = new System.Drawing.Size(264, 218);
            this.rtbComplaints.TabIndex = 3;
            this.rtbComplaints.Text = "";
            // 
            // mcComplaint
            // 
            this.mcComplaint.Location = new System.Drawing.Point(191, 46);
            this.mcComplaint.Margin = new System.Windows.Forms.Padding(7);
            this.mcComplaint.Name = "mcComplaint";
            this.mcComplaint.TabIndex = 2;
            // 
            // btnFileComplaint
            // 
            this.btnFileComplaint.Location = new System.Drawing.Point(13, 279);
            this.btnFileComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileComplaint.Name = "btnFileComplaint";
            this.btnFileComplaint.Size = new System.Drawing.Size(168, 33);
            this.btnFileComplaint.TabIndex = 1;
            this.btnFileComplaint.Text = "File Complaint";
            this.btnFileComplaint.UseVisualStyleBackColor = true;
            this.btnFileComplaint.Click += new System.EventHandler(this.btnFileComplaint_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(13, 46);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(169, 218);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.label6);
            this.tpRules.Controls.Add(this.lbxRules);
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Margin = new System.Windows.Forms.Padding(2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(2);
            this.tpRules.Size = new System.Drawing.Size(720, 330);
            this.tpRules.TabIndex = 2;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rules";
            // 
            // lbxRules
            // 
            this.lbxRules.FormattingEnabled = true;
            this.lbxRules.Location = new System.Drawing.Point(225, 57);
            this.lbxRules.Margin = new System.Windows.Forms.Padding(2);
            this.lbxRules.Name = "lbxRules";
            this.lbxRules.Size = new System.Drawing.Size(275, 251);
            this.lbxRules.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.label9);
            this.tpEvents.Controls.Add(this.label8);
            this.tpEvents.Controls.Add(this.label7);
            this.tpEvents.Controls.Add(this.cbxEventHost);
            this.tpEvents.Controls.Add(this.label2);
            this.tpEvents.Controls.Add(this.label1);
            this.tpEvents.Controls.Add(this.btnShowInfoEvent);
            this.tpEvents.Controls.Add(this.btnAddEvent);
            this.tpEvents.Controls.Add(this.rtbEventDescription);
            this.tpEvents.Controls.Add(this.tbxEventTitle);
            this.tpEvents.Controls.Add(this.mcEvents);
            this.tpEvents.Controls.Add(this.clbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(720, 330);
            this.tpEvents.TabIndex = 3;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Write Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select Host";
            // 
            // cbxEventHost
            // 
            this.cbxEventHost.FormattingEnabled = true;
            this.cbxEventHost.Location = new System.Drawing.Point(35, 68);
            this.cbxEventHost.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEventHost.Name = "cbxEventHost";
            this.cbxEventHost.Size = new System.Drawing.Size(100, 21);
            this.cbxEventHost.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Date";
            // 
            // btnShowInfoEvent
            // 
            this.btnShowInfoEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfoEvent.Location = new System.Drawing.Point(494, 232);
            this.btnShowInfoEvent.Name = "btnShowInfoEvent";
            this.btnShowInfoEvent.Size = new System.Drawing.Size(139, 57);
            this.btnShowInfoEvent.TabIndex = 7;
            this.btnShowInfoEvent.Text = "Show Info";
            this.btnShowInfoEvent.UseVisualStyleBackColor = true;
            this.btnShowInfoEvent.Click += new System.EventHandler(this.btnShowInfoEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(196, 259);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(101, 57);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // rtbEventDescription
            // 
            this.rtbEventDescription.Location = new System.Drawing.Point(13, 207);
            this.rtbEventDescription.Name = "rtbEventDescription";
            this.rtbEventDescription.Size = new System.Drawing.Size(155, 109);
            this.rtbEventDescription.TabIndex = 5;
            this.rtbEventDescription.Text = "";
            // 
            // tbxEventTitle
            // 
            this.tbxEventTitle.Location = new System.Drawing.Point(35, 133);
            this.tbxEventTitle.Multiline = true;
            this.tbxEventTitle.Name = "tbxEventTitle";
            this.tbxEventTitle.Size = new System.Drawing.Size(100, 41);
            this.tbxEventTitle.TabIndex = 4;
            // 
            // mcEvents
            // 
            this.mcEvents.Location = new System.Drawing.Point(196, 49);
            this.mcEvents.Name = "mcEvents";
            this.mcEvents.TabIndex = 1;
            // 
            // clbEvents
            // 
            this.clbEvents.FormattingEnabled = true;
            this.clbEvents.Location = new System.Drawing.Point(435, 51);
            this.clbEvents.Name = "clbEvents";
            this.clbEvents.Size = new System.Drawing.Size(266, 154);
            this.clbEvents.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 366);
            this.Controls.Add(this.tcTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "HouseMate";
            this.tcTabControl.ResumeLayout(false);
            this.tpChores.ResumeLayout(false);
            this.tpChores.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.tpComplaints.PerformLayout();
            this.tpRules.ResumeLayout(false);
            this.tpRules.PerformLayout();
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
        private System.Windows.Forms.MonthCalendar mcEvents;
        private System.Windows.Forms.CheckedListBox clbEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox clbChores;
        private System.Windows.Forms.ComboBox cbxEventHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

