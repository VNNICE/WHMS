namespace WHMS
{
    partial class Add_AdminList
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
            comboBox_Group = new ComboBox();
            label_Group = new Label();
            label_Region = new Label();
            comboBox_Region = new ComboBox();
            button_Decide = new Button();
            button_Cancle = new Button();
            label_Initial = new Label();
            textBox_Initial = new TextBox();
            SuspendLayout();
            // 
            // comboBox_Group
            // 
            comboBox_Group.FormattingEnabled = true;
            comboBox_Group.Location = new Point(72, 41);
            comboBox_Group.Name = "comboBox_Group";
            comboBox_Group.Size = new Size(128, 23);
            comboBox_Group.TabIndex = 0;
            // 
            // label_Group
            // 
            label_Group.AutoSize = true;
            label_Group.Location = new Point(12, 44);
            label_Group.Name = "label_Group";
            label_Group.Size = new Size(42, 15);
            label_Group.TabIndex = 1;
            label_Group.Text = "グループ";
            // 
            // label_Region
            // 
            label_Region.AutoSize = true;
            label_Region.Location = new Point(23, 15);
            label_Region.Name = "label_Region";
            label_Region.Size = new Size(31, 15);
            label_Region.TabIndex = 2;
            label_Region.Text = "管轄";
            // 
            // comboBox_Region
            // 
            comboBox_Region.FormattingEnabled = true;
            comboBox_Region.Location = new Point(72, 12);
            comboBox_Region.Name = "comboBox_Region";
            comboBox_Region.Size = new Size(128, 23);
            comboBox_Region.TabIndex = 3;
            // 
            // button_Decide
            // 
            button_Decide.Location = new Point(8, 101);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(75, 23);
            button_Decide.TabIndex = 4;
            button_Decide.Text = "登録";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Cancle
            // 
            button_Cancle.Location = new Point(125, 99);
            button_Cancle.Name = "button_Cancle";
            button_Cancle.Size = new Size(75, 23);
            button_Cancle.TabIndex = 5;
            button_Cancle.Text = "キャンセル";
            button_Cancle.UseVisualStyleBackColor = true;
            // 
            // label_Initial
            // 
            label_Initial.AutoSize = true;
            label_Initial.Location = new Point(8, 73);
            label_Initial.Name = "label_Initial";
            label_Initial.Size = new Size(55, 15);
            label_Initial.TabIndex = 6;
            label_Initial.Text = "略字登録";
            // 
            // textBox_Initial
            // 
            textBox_Initial.Location = new Point(72, 70);
            textBox_Initial.Name = "textBox_Initial";
            textBox_Initial.Size = new Size(128, 23);
            textBox_Initial.TabIndex = 8;
            // 
            // Add_AdminList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 130);
            Controls.Add(textBox_Initial);
            Controls.Add(label_Initial);
            Controls.Add(button_Cancle);
            Controls.Add(button_Decide);
            Controls.Add(comboBox_Region);
            Controls.Add(label_Region);
            Controls.Add(label_Group);
            Controls.Add(comboBox_Group);
            Name = "Add_AdminList";
            Text = "Add_AdminList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Group;
        private Label label_Group;
        private Label label_Region;
        private ComboBox comboBox_Region;
        private Button button_Decide;
        private Button button_Cancle;
        private Label label_Initial;
        private TextBox textBox_Initial;
    }
}