namespace WindowsFormsApplication4
{
    partial class Form4
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
            this.CPUVersion_combobox = new System.Windows.Forms.ComboBox();
            this.CPU_combobox = new System.Windows.Forms.ComboBox();
            this.image_combobox = new System.Windows.Forms.ComboBox();
            this.tia_combobox = new System.Windows.Forms.ComboBox();
            this.target_comboBox = new System.Windows.Forms.ComboBox();
            this.Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPUVersion_combobox
            // 
            this.CPUVersion_combobox.FormattingEnabled = true;
            this.CPUVersion_combobox.Location = new System.Drawing.Point(233, 248);
            this.CPUVersion_combobox.Name = "CPUVersion_combobox";
            this.CPUVersion_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPUVersion_combobox.TabIndex = 13;
            // 
            // CPU_combobox
            // 
            this.CPU_combobox.FormattingEnabled = true;
            this.CPU_combobox.Location = new System.Drawing.Point(233, 169);
            this.CPU_combobox.Name = "CPU_combobox";
            this.CPU_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPU_combobox.TabIndex = 12;
            // 
            // image_combobox
            // 
            this.image_combobox.FormattingEnabled = true;
            this.image_combobox.Location = new System.Drawing.Point(233, 97);
            this.image_combobox.Name = "image_combobox";
            this.image_combobox.Size = new System.Drawing.Size(121, 24);
            this.image_combobox.TabIndex = 11;
            // 
            // tia_combobox
            // 
            this.tia_combobox.FormattingEnabled = true;
            this.tia_combobox.Location = new System.Drawing.Point(12, 248);
            this.tia_combobox.Name = "tia_combobox";
            this.tia_combobox.Size = new System.Drawing.Size(121, 24);
            this.tia_combobox.TabIndex = 10;
            // 
            // target_comboBox
            // 
            this.target_comboBox.FormattingEnabled = true;
            this.target_comboBox.Location = new System.Drawing.Point(12, 169);
            this.target_comboBox.Name = "target_comboBox";
            this.target_comboBox.Size = new System.Drawing.Size(121, 24);
            this.target_comboBox.TabIndex = 9;
            // 
            // Name_ComboBox
            // 
            this.Name_ComboBox.FormattingEnabled = true;
            this.Name_ComboBox.Location = new System.Drawing.Point(12, 97);
            this.Name_ComboBox.Name = "Name_ComboBox";
            this.Name_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Name_ComboBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CPUVersion_combobox);
            this.Controls.Add(this.CPU_combobox);
            this.Controls.Add(this.image_combobox);
            this.Controls.Add(this.tia_combobox);
            this.Controls.Add(this.target_comboBox);
            this.Controls.Add(this.Name_ComboBox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CPUVersion_combobox;
        private System.Windows.Forms.ComboBox CPU_combobox;
        private System.Windows.Forms.ComboBox image_combobox;
        private System.Windows.Forms.ComboBox tia_combobox;
        private System.Windows.Forms.ComboBox target_comboBox;
        private System.Windows.Forms.ComboBox Name_ComboBox;
        private System.Windows.Forms.Button button1;
    }
}