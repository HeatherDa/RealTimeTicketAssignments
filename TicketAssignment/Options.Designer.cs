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
            this.numGuestsperWindow = new System.Windows.Forms.NumericUpDown();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPerWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsperWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number:";
            // 
            // numMinPerWindow
            // 
            this.numMinPerWindow.Location = new System.Drawing.Point(123, 11);
            this.numMinPerWindow.Name = "numMinPerWindow";
            this.numMinPerWindow.Size = new System.Drawing.Size(120, 20);
            this.numMinPerWindow.TabIndex = 6;
            // 
            // numGuestsperWindow
            // 
            this.numGuestsperWindow.Location = new System.Drawing.Point(123, 47);
            this.numGuestsperWindow.Name = "numGuestsperWindow";
            this.numGuestsperWindow.Size = new System.Drawing.Size(120, 20);
            this.numGuestsperWindow.TabIndex = 7;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(123, 115);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(120, 20);
            this.txtEndTime.TabIndex = 9;
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(123, 150);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(120, 20);
            this.txtFirstNum.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(123, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(123, 81);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(120, 20);
            this.txtStartTime.TabIndex = 12;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 230);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.numGuestsperWindow);
            this.Controls.Add(this.numMinPerWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numMinPerWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuestsperWindow)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numGuestsperWindow;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtStartTime;
    }
}