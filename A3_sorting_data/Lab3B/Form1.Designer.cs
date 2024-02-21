namespace Lab3B
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
            this.HairdresserDropdownBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChargedItemsListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PriceBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPriceDisplayBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HairdresserDropdownBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // HairdresserDropdownBox
            // 
            this.HairdresserDropdownBox.FormattingEnabled = true;
            this.HairdresserDropdownBox.Location = new System.Drawing.Point(6, 23);
            this.HairdresserDropdownBox.Name = "HairdresserDropdownBox";
            this.HairdresserDropdownBox.Size = new System.Drawing.Size(188, 26);
            this.HairdresserDropdownBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServiceListBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.ItemHeight = 18;
            this.ServiceListBox.Location = new System.Drawing.Point(7, 23);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ServiceListBox.Size = new System.Drawing.Size(226, 166);
            this.ServiceListBox.TabIndex = 0;
            this.ServiceListBox.SelectedIndexChanged += new System.EventHandler(this.ServiceListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChargedItemsListBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(487, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // ChargedItemsListBox
            // 
            this.ChargedItemsListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ChargedItemsListBox.FormattingEnabled = true;
            this.ChargedItemsListBox.ItemHeight = 18;
            this.ChargedItemsListBox.Location = new System.Drawing.Point(0, 22);
            this.ChargedItemsListBox.Name = "ChargedItemsListBox";
            this.ChargedItemsListBox.Size = new System.Drawing.Size(241, 166);
            this.ChargedItemsListBox.TabIndex = 0;
          
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PriceBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(747, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PriceBox.FormattingEnabled = true;
            this.PriceBox.ItemHeight = 18;
            this.PriceBox.Location = new System.Drawing.Point(7, 22);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceBox.Size = new System.Drawing.Size(90, 166);
            this.PriceBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Price:";
            // 
            // TotalPriceDisplayBox
            // 
            this.TotalPriceDisplayBox.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPriceDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceDisplayBox.Location = new System.Drawing.Point(744, 226);
            this.TotalPriceDisplayBox.Name = "TotalPriceDisplayBox";
            this.TotalPriceDisplayBox.ReadOnly = true;
            this.TotalPriceDisplayBox.Size = new System.Drawing.Size(106, 24);
            this.TotalPriceDisplayBox.TabIndex = 5;
            this.TotalPriceDisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(672, 257);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 28);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(497, 257);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(169, 28);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(298, 257);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(193, 28);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Total Price";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServiceButton.Location = new System.Drawing.Point(119, 257);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(173, 28);
            this.AddServiceButton.TabIndex = 9;
            this.AddServiceButton.Text = "Add Service";
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 298);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TotalPriceDisplayBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox HairdresserDropdownBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ChargedItemsListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox PriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalPriceDisplayBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button AddServiceButton;
    }
}

