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
            label_Group = new Label();
            label_Region = new Label();
            comboBox_Region = new ComboBox();
            button_Decide = new Button();
            button_Cancle = new Button();
            label_Initial = new Label();
            textBox_Initial = new TextBox();
            dataGridView = new DataGridView();
            textBox_Group = new TextBox();
            label_Description = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
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
            comboBox_Region.TabIndex = 0;
            // 
            // button_Decide
            // 
            button_Decide.Location = new Point(8, 205);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(75, 23);
            button_Decide.TabIndex = 3;
            button_Decide.Text = "登録";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Cancle
            // 
            button_Cancle.Location = new Point(125, 203);
            button_Cancle.Name = "button_Cancle";
            button_Cancle.Size = new Size(75, 23);
            button_Cancle.TabIndex = 4;
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
            textBox_Initial.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(206, 59);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(342, 169);
            dataGridView.TabIndex = 9;
            // 
            // textBox_Group
            // 
            textBox_Group.Location = new Point(72, 41);
            textBox_Group.Name = "textBox_Group";
            textBox_Group.Size = new Size(128, 23);
            textBox_Group.TabIndex = 1;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.BackColor = Color.White;
            label_Description.Font = new Font("Yu Gothic UI", 20F);
            label_Description.ForeColor = SystemColors.ActiveCaptionText;
            label_Description.Location = new Point(314, 9);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(125, 37);
            label_Description.TabIndex = 11;
            label_Description.Text = "登録情報";
            // 
            // Add_AdminList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 240);
            Controls.Add(label_Description);
            Controls.Add(textBox_Group);
            Controls.Add(dataGridView);
            Controls.Add(textBox_Initial);
            Controls.Add(label_Initial);
            Controls.Add(button_Cancle);
            Controls.Add(button_Decide);
            Controls.Add(comboBox_Region);
            Controls.Add(label_Region);
            Controls.Add(label_Group);
            Name = "Add_AdminList";
            Text = "Add_AdminList";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Group;
        private Label label_Region;
        private ComboBox comboBox_Region;
        private Button button_Decide;
        private Button button_Cancle;
        private Label label_Initial;
        private TextBox textBox_Initial;
        private DataGridView dataGridView;
        private TextBox textBox_Group;
        private Label label_Description;
    }
}