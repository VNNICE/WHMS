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
            button_AddAdmin = new Button();
            textBox_Name = new TextBox();
            label_Name = new Label();
            label_Group = new Label();
            comboBox_Group = new ComboBox();
            button_Decide = new Button();
            button_Cancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Region
            // 
            label_Region.AutoSize = true;
            label_Region.Dock = DockStyle.Fill;
            label_Region.Location = new Point(3, 0);
            label_Region.Name = "label_Region";
            label_Region.Size = new Size(44, 29);
            label_Region.TabIndex = 7;
            label_Region.Text = "管轄";
            label_Region.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_Region
            // 
            comboBox_Region.Dock = DockStyle.Fill;
            comboBox_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Region.FormattingEnabled = true;
            comboBox_Region.Location = new Point(53, 3);
            comboBox_Region.Name = "comboBox_Region";
            comboBox_Region.Size = new Size(94, 23);
            comboBox_Region.TabIndex = 0;
            // 
            // button_AddAdmin
            // 
            button_AddAdmin.Dock = DockStyle.Fill;
            button_AddAdmin.Location = new Point(153, 3);
            button_AddAdmin.Name = "button_AddAdmin";
            button_AddAdmin.Size = new Size(94, 23);
            button_AddAdmin.TabIndex = 5;
            button_AddAdmin.Text = "グループ登録";
            button_AddAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Dock = DockStyle.Fill;
            textBox_Name.Location = new Point(53, 61);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(94, 23);
            textBox_Name.TabIndex = 2;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Dock = DockStyle.Fill;
            label_Name.Location = new Point(3, 58);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(44, 29);
            label_Name.TabIndex = 10;
            label_Name.Text = "氏名";
            label_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Group
            // 
            label_Group.AutoSize = true;
            label_Group.Dock = DockStyle.Fill;
            label_Group.Location = new Point(3, 29);
            label_Group.Name = "label_Group";
            label_Group.Size = new Size(44, 29);
            label_Group.TabIndex = 12;
            label_Group.Text = "グループ";
            label_Group.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_Group
            // 
            comboBox_Group.Dock = DockStyle.Fill;
            comboBox_Group.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Group.FormattingEnabled = true;
            comboBox_Group.Location = new Point(53, 32);
            comboBox_Group.Name = "comboBox_Group";
            comboBox_Group.Size = new Size(94, 23);
            comboBox_Group.TabIndex = 1;
            // 
            // button_Decide
            // 
            button_Decide.Dock = DockStyle.Fill;
            button_Decide.Location = new Point(53, 90);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(94, 25);
            button_Decide.TabIndex = 3;
            button_Decide.Text = "登　録";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(153, 90);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 25);
            button_Cancel.TabIndex = 4;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(label_Region, 0, 0);
            tableLayoutPanel1.Controls.Add(button_AddAdmin, 2, 0);
            tableLayoutPanel1.Controls.Add(comboBox_Region, 1, 0);
            tableLayoutPanel1.Controls.Add(label_Group, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 2);
            tableLayoutPanel1.Controls.Add(label_Name, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBox_Group, 1, 1);
            tableLayoutPanel1.Controls.Add(button_Cancel, 2, 3);
            tableLayoutPanel1.Controls.Add(button_Decide, 1, 3);
            tableLayoutPanel1.Location = new Point(9, 9);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(250, 118);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // Add_AdminList_Name
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 126);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_AdminList_Name";
            Text = "Add_AdminList_Name";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Region;
        private ComboBox comboBox_Region;
        private Button button_AddAdmin;
        private TextBox textBox_Name;
        private Label label_Name;
        private Label label_Group;
        private ComboBox comboBox_Group;
        private Button button_Decide;
        private Button button_Cancel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}