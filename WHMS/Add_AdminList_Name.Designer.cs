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
            label_Region = new Label();
            comboBox_Region = new ComboBox();
            button_FindList = new Button();
            textBox_Name = new TextBox();
            label_Name = new Label();
            label_Group = new Label();
            comboBox_Group = new ComboBox();
            button_Decide = new Button();
            button_Cancel = new Button();
            button_Refresh = new Button();
            SuspendLayout();
            // 
            // label_Region
            // 
            label_Region.AutoSize = true;
            label_Region.Location = new Point(6, 15);
            label_Region.Name = "label_Region";
            label_Region.Size = new Size(31, 15);
            label_Region.TabIndex = 7;
            label_Region.Text = "管轄";
            // 
            // comboBox_Region
            // 
            comboBox_Region.FormattingEnabled = true;
            comboBox_Region.Location = new Point(52, 12);
            comboBox_Region.Name = "comboBox_Region";
            comboBox_Region.Size = new Size(121, 23);
            comboBox_Region.TabIndex = 0;
            // 
            // button_FindList
            // 
            button_FindList.Location = new Point(179, 12);
            button_FindList.Name = "button_FindList";
            button_FindList.Size = new Size(75, 23);
            button_FindList.TabIndex = 5;
            button_FindList.Text = "グループ登録";
            button_FindList.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(52, 70);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(121, 23);
            textBox_Name.TabIndex = 2;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(8, 73);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(31, 15);
            label_Name.TabIndex = 10;
            label_Name.Text = "氏名";
            // 
            // label_Group
            // 
            label_Group.AutoSize = true;
            label_Group.Location = new Point(3, 44);
            label_Group.Name = "label_Group";
            label_Group.Size = new Size(42, 15);
            label_Group.TabIndex = 12;
            label_Group.Text = "グループ";
            // 
            // comboBox_Group
            // 
            comboBox_Group.FormattingEnabled = true;
            comboBox_Group.Location = new Point(52, 41);
            comboBox_Group.Name = "comboBox_Group";
            comboBox_Group.Size = new Size(121, 23);
            comboBox_Group.TabIndex = 1;
            // 
            // button_Decide
            // 
            button_Decide.Location = new Point(8, 99);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(75, 23);
            button_Decide.TabIndex = 3;
            button_Decide.Text = "登　録";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(98, 99);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 4;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(179, 44);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(75, 23);
            button_Refresh.TabIndex = 13;
            button_Refresh.Text = "リフレッシュ";
            button_Refresh.UseVisualStyleBackColor = true;
            // 
            // Add_AdminList_Name
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 130);
            Controls.Add(button_Refresh);
            Controls.Add(button_Cancel);
            Controls.Add(button_Decide);
            Controls.Add(label_Group);
            Controls.Add(comboBox_Group);
            Controls.Add(label_Name);
            Controls.Add(textBox_Name);
            Controls.Add(button_FindList);
            Controls.Add(label_Region);
            Controls.Add(comboBox_Region);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_AdminList_Name";
            Text = "Add_AdminList_Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Region;
        private ComboBox comboBox_Region;
        private Button button_FindList;
        private TextBox textBox_Name;
        private Label label_Name;
        private Label label_Group;
        private ComboBox comboBox_Group;
        private Button button_Decide;
        private Button button_Cancel;
        private Button button_Refresh;
    }
}