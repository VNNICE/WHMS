namespace WHMS
{
    partial class Add_Warehouse_DefaultInfo
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
            textBox_Name = new TextBox();
            label_City = new Label();
            label2 = new Label();
            comboBox_City = new ComboBox();
            button_Apply = new Button();
            button_Cancel = new Button();
            button_Add_Images = new Button();
            textBox_Show_ImagesPath = new TextBox();
            textBox_Add_Areas = new TextBox();
            label_Add_Areas = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Dock = DockStyle.Fill;
            textBox_Name.Location = new Point(68, 32);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(164, 23);
            textBox_Name.TabIndex = 1;
            // 
            // label_City
            // 
            label_City.AutoSize = true;
            label_City.Dock = DockStyle.Fill;
            label_City.Location = new Point(3, 0);
            label_City.Name = "label_City";
            label_City.Size = new Size(59, 29);
            label_City.TabIndex = 2;
            label_City.Text = "地　域";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 29);
            label2.TabIndex = 3;
            label2.Text = "倉庫名";
            // 
            // comboBox_City
            // 
            comboBox_City.Dock = DockStyle.Fill;
            comboBox_City.FormattingEnabled = true;
            comboBox_City.Location = new Point(68, 3);
            comboBox_City.Name = "comboBox_City";
            comboBox_City.Size = new Size(164, 23);
            comboBox_City.TabIndex = 0;
            // 
            // button_Apply
            // 
            button_Apply.Dock = DockStyle.Fill;
            button_Apply.Location = new Point(3, 3);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(111, 23);
            button_Apply.TabIndex = 4;
            button_Apply.Text = "登録";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Click += button_Apply_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(120, 3);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(112, 23);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_Add_Images
            // 
            button_Add_Images.Dock = DockStyle.Fill;
            button_Add_Images.Location = new Point(3, 3);
            button_Add_Images.Name = "button_Add_Images";
            button_Add_Images.Size = new Size(229, 23);
            button_Add_Images.TabIndex = 3;
            button_Add_Images.Text = "画像追加";
            button_Add_Images.UseVisualStyleBackColor = true;
            button_Add_Images.Click += button_Add_Images_Click;
            // 
            // textBox_Show_ImagesPath
            // 
            textBox_Show_ImagesPath.Dock = DockStyle.Fill;
            textBox_Show_ImagesPath.Enabled = false;
            textBox_Show_ImagesPath.Location = new Point(3, 32);
            textBox_Show_ImagesPath.Name = "textBox_Show_ImagesPath";
            textBox_Show_ImagesPath.ReadOnly = true;
            textBox_Show_ImagesPath.Size = new Size(229, 23);
            textBox_Show_ImagesPath.TabIndex = 8;
            // 
            // textBox_Add_Areas
            // 
            textBox_Add_Areas.Dock = DockStyle.Fill;
            textBox_Add_Areas.Location = new Point(68, 61);
            textBox_Add_Areas.Name = "textBox_Add_Areas";
            textBox_Add_Areas.Size = new Size(164, 23);
            textBox_Add_Areas.TabIndex = 2;
            // 
            // label_Add_Areas
            // 
            label_Add_Areas.AutoSize = true;
            label_Add_Areas.Dock = DockStyle.Fill;
            label_Add_Areas.Location = new Point(3, 58);
            label_Add_Areas.Name = "label_Add_Areas";
            label_Add_Areas.Size = new Size(59, 29);
            label_Add_Areas.TabIndex = 10;
            label_Add_Areas.Text = "置場数";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6595745F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.34042F));
            tableLayoutPanel1.Controls.Add(comboBox_City, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_Add_Areas, 1, 2);
            tableLayoutPanel1.Controls.Add(label_Add_Areas, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label_City, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(235, 87);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button_Add_Images, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox_Show_ImagesPath, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 87);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(235, 58);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button_Apply, 0, 0);
            tableLayoutPanel3.Controls.Add(button_Cancel, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 145);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(235, 29);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel3);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 177);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Add_Warehouse_DefaultInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 202);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Name = "Add_Warehouse_DefaultInfo";
            Text = "倉庫登録";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox_Name;
        private Label label_City;
        private Label label2;
        private ComboBox comboBox_City;
        private Button button_Apply;
        private Button button_Cancel;
        private Button button_Add_Images;
        private TextBox textBox_Show_ImagesPath;
        private TextBox textBox_Add_Areas;
        private Label label_Add_Areas;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}