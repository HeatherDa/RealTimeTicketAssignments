namespace TicketAssignment
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numMinPerWindow = new System.Windows.Forms.NumericUpDown();
            this.numGuestsPerWindow = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.numFirstTicket = new System.Windows.Forms.NumericUpDown();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPerWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsPerWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number:";
            // 
            // numMinPerWindow
            // 
            this.numMinPerWindow.Location = new System.Drawing.Point(164, 14);
            this.numMinPerWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMinPerWindow.Name = "numMinPerWindow";
            this.numMinPerWindow.Size = new System.Drawing.Size(160, 22);
            this.numMinPerWindow.TabIndex = 6;
            this.numMinPerWindow.ValueChanged += new System.EventHandler(this.numMinPerWindow_ValueChanged);
            // 
            // numGuestsPerWindow
            // 
            this.numGuestsPerWindow.Location = new System.Drawing.Point(164, 58);
            this.numGuestsPerWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numGuestsPerWindow.Name = "numGuestsPerWindow";
            this.numGuestsPerWindow.Size = new System.Drawing.Size(160, 22);
            this.numGuestsPerWindow.TabIndex = 7;
            this.numGuestsPerWindow.ValueChanged += new System.EventHandler(this.numGuestsPerWindow_ValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 239);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numFirstTicket
            // 
            this.numFirstTicket.Location = new System.Drawing.Point(164, 186);
            this.numFirstTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFirstTicket.Name = "numFirstTicket";
            this.numFirstTicket.Size = new System.Drawing.Size(160, 22);
            this.numFirstTicket.TabIndex = 13;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(164, 96);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(159, 22);
            this.dtpStartTime.TabIndex = 14;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(164, 138);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(159, 22);
            this.dtpEndTime.TabIndex = 15;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 283);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.numFirstTicket);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numGuestsPerWindow);
            this.Controls.Add(this.numMinPerWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numMinPerWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsPerWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMinPerWindow;
        private System.Windows.Forms.NumericUpDown numGuestsPerWindow;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numFirstTicket;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
    }
}