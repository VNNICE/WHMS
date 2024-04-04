namespace WHMS
{
    partial class Add_AdminList_Name
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
            label_Name = new Label();
            comboBox_Name = new ComboBox();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(1, 26);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(43, 15);
            label_Name.TabIndex = 7;
            label_Name.Text = "倉庫名";
            label_Name.Click += label_Name_Click;
            // 
            // comboBox_Name
            // 
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(50, 23);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(121, 23);
            comboBox_Name.TabIndex = 6;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            // 
            // Add_AdminList_Name
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 158);
            Controls.Add(label_Name);
            Controls.Add(comboBox_Name);
            Name = "Add_AdminList_Name";
            Text = "Add_AdminList_Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private ComboBox comboBox_Name;
    }
}