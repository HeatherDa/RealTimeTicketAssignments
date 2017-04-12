namespace TicketAssignment
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutstandingTotal = new System.Windows.Forms.Label();
            this.lblNextEntryTime = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNextEntryTime);
            this.groupBox2.Controls.Add(this.lblOutstandingTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.btnIssueTicket);
            this.groupBox2.Location = new System.Drawing.Point(13, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(13, 182);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(259, 134);
            this.lstTickets.TabIndex = 2;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(13, 323);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(185, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Location = new System.Drawing.Point(7, 73);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(75, 23);
            this.btnIssueTicket.TabIndex = 0;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Total tickets outstanding: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Next available entry: ";
            // 
            // lblOutstandingTotal
            // 
            this.lblOutstandingTotal.AutoSize = true;
            this.lblOutstandingTotal.Location = new System.Drawing.Point(144, 17);
            this.lblOutstandingTotal.Name = "lblOutstandingTotal";
            this.lblOutstandingTotal.Size = new System.Drawing.Size(13, 13);
            this.lblOutstandingTotal.TabIndex = 3;
            this.lblOutstandingTotal.Text = "_";
            // 
            // lblNextEntryTime
            // 
            this.lblNextEntryTime.AutoSize = true;
            this.lblNextEntryTime.Location = new System.Drawing.Point(144, 44);
            this.lblNextEntryTime.Name = "lblNextEntryTime";
            this.lblNextEntryTime.Size = new System.Drawing.Size(13, 13);
            this.lblNextEntryTime.TabIndex = 4;
            this.lblNextEntryTime.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 373);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "_";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNextEntryTime;
        private System.Windows.Forms.Label lblOutstandingTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
    }
}

