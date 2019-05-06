namespace WindowsFormsApplication4
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
            this.registertable = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.target_comboBox = new System.Windows.Forms.ComboBox();
            this.tia_combobox = new System.Windows.Forms.ComboBox();
            this.image_combobox = new System.Windows.Forms.ComboBox();
            this.CPU_combobox = new System.Windows.Forms.ComboBox();
            this.CPUVersion_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.registertable)).BeginInit();
            this.SuspendLayout();
            // 
            // registertable
            // 
            this.registertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registertable.Location = new System.Drawing.Point(62, 219);
            this.registertable.Name = "registertable";
            this.registertable.RowTemplate.Height = 24;
            this.registertable.Size = new System.Drawing.Size(613, 173);
            this.registertable.TabIndex = 0;
            this.registertable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(865, 553);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add New";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_ComboBox
            // 
            this.Name_ComboBox.FormattingEnabled = true;
            this.Name_ComboBox.Location = new System.Drawing.Point(62, 42);
            this.Name_ComboBox.Name = "Name_ComboBox";
            this.Name_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Name_ComboBox.TabIndex = 2;
            // 
            // target_comboBox
            // 
            this.target_comboBox.FormattingEnabled = true;
            this.target_comboBox.Location = new System.Drawing.Point(238, 42);
            this.target_comboBox.Name = "target_comboBox";
            this.target_comboBox.Size = new System.Drawing.Size(121, 24);
            this.target_comboBox.TabIndex = 3;
            // 
            // tia_combobox
            // 
            this.tia_combobox.FormattingEnabled = true;
            this.tia_combobox.Location = new System.Drawing.Point(411, 40);
            this.tia_combobox.Name = "tia_combobox";
            this.tia_combobox.Size = new System.Drawing.Size(121, 24);
            this.tia_combobox.TabIndex = 4;
            // 
            // image_combobox
            // 
            this.image_combobox.FormattingEnabled = true;
            this.image_combobox.Location = new System.Drawing.Point(590, 40);
            this.image_combobox.Name = "image_combobox";
            this.image_combobox.Size = new System.Drawing.Size(121, 24);
            this.image_combobox.TabIndex = 5;
            // 
            // CPU_combobox
            // 
            this.CPU_combobox.FormattingEnabled = true;
            this.CPU_combobox.Location = new System.Drawing.Point(757, 40);
            this.CPU_combobox.Name = "CPU_combobox";
            this.CPU_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPU_combobox.TabIndex = 6;
            // 
            // CPUVersion_combobox
            // 
            this.CPUVersion_combobox.FormattingEnabled = true;
            this.CPUVersion_combobox.Location = new System.Drawing.Point(934, 42);
            this.CPUVersion_combobox.Name = "CPUVersion_combobox";
            this.CPUVersion_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPUVersion_combobox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 634);
            this.Controls.Add(this.CPUVersion_combobox);
            this.Controls.Add(this.CPU_combobox);
            this.Controls.Add(this.image_combobox);
            this.Controls.Add(this.tia_combobox);
            this.Controls.Add(this.target_comboBox);
            this.Controls.Add(this.Name_ComboBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.registertable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.registertable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView registertable;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox Name_ComboBox;
        private System.Windows.Forms.ComboBox target_comboBox;
        private System.Windows.Forms.ComboBox tia_combobox;
        private System.Windows.Forms.ComboBox image_combobox;
        private System.Windows.Forms.ComboBox CPU_combobox;
        private System.Windows.Forms.ComboBox CPUVersion_combobox;
    }
}

