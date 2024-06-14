namespace WHMS
{
    partial class Add_ItemTypeList
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button_Cancel = new Button();
            button_Decide = new Button();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox5 = new ComboBox();
            label_Category = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label_Code = new Label();
            textBox_Code = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button_Decide, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(button_Cancel, 2, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBox5, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 2);
            tableLayoutPanel1.Controls.Add(textBox_Code, 2, 1);
            tableLayoutPanel1.Controls.Add(label_Category, 1, 0);
            tableLayoutPanel1.Controls.Add(label_Code, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(346, 145);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(206, 119);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(137, 23);
            button_Cancel.TabIndex = 2;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Decide
            // 
            button_Decide.Dock = DockStyle.Fill;
            button_Decide.Location = new Point(64, 119);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(136, 23);
            button_Decide.TabIndex = 3;
            button_Decide.Text = "確定";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(64, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(64, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(136, 23);
            comboBox3.TabIndex = 2;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Fill;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(64, 90);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(136, 23);
            comboBox5.TabIndex = 6;
            // 
            // label_Category
            // 
            label_Category.AutoSize = true;
            label_Category.Dock = DockStyle.Fill;
            label_Category.Location = new Point(64, 0);
            label_Category.Name = "label_Category";
            label_Category.Size = new Size(136, 29);
            label_Category.TabIndex = 10;
            label_Category.Text = "分類";
            label_Category.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(55, 29);
            label2.TabIndex = 11;
            label2.Text = "使用目的";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(55, 29);
            label3.TabIndex = 12;
            label3.Text = "種類";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 87);
            label4.Name = "label4";
            label4.Size = new Size(55, 29);
            label4.TabIndex = 13;
            label4.Text = "資産管理";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Code
            // 
            label_Code.AutoSize = true;
            label_Code.Dock = DockStyle.Fill;
            label_Code.Location = new Point(206, 0);
            label_Code.Name = "label_Code";
            label_Code.Size = new Size(137, 29);
            label_Code.TabIndex = 14;
            label_Code.Text = "コード";
            label_Code.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Code
            // 
            textBox_Code.Dock = DockStyle.Fill;
            textBox_Code.Location = new Point(206, 32);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.Size = new Size(137, 23);
            textBox_Code.TabIndex = 7;
            textBox_Code.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(206, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(206, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 9;
            // 
            // Add_ItemTypeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 167);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_ItemTypeList";
            Text = "Add_ItemTypeList";
            Load += Add_ItemTypeList_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_Cancel;
        private Button button_Decide;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox5;
        private Label label_Category;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox_Code;
        private Label label_Code;
    }
}