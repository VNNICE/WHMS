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
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(51, 38);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(110, 23);
            textBox_Name.TabIndex = 1;
            // 
            // label_City
            // 
            label_City.AutoSize = true;
            label_City.Location = new Point(7, 9);
            label_City.Name = "label_City";
            label_City.Size = new Size(43, 15);
            label_City.TabIndex = 2;
            label_City.Text = "地　域";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 41);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "倉庫名";
            // 
            // comboBox_City
            // 
            comboBox_City.FormattingEnabled = true;
            comboBox_City.Location = new Point(51, 6);
            comboBox_City.Name = "comboBox_City";
            comboBox_City.Size = new Size(110, 23);
            comboBox_City.TabIndex = 0;
            // 
            // button_Apply
            // 
            button_Apply.Location = new Point(6, 152);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(75, 23);
            button_Apply.TabIndex = 4;
            button_Apply.Text = "登録";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Click += button_Apply_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(85, 152);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_Add_Images
            // 
            button_Add_Images.Location = new Point(6, 96);
            button_Add_Images.Name = "button_Add_Images";
            button_Add_Images.Size = new Size(154, 23);
            button_Add_Images.TabIndex = 3;
            button_Add_Images.Text = "画像追加";
            button_Add_Images.UseVisualStyleBackColor = true;
            button_Add_Images.Click += button_Add_Images_Click;
            // 
            // textBox_Show_ImagesPath
            // 
            textBox_Show_ImagesPath.Enabled = false;
            textBox_Show_ImagesPath.Location = new Point(6, 123);
            textBox_Show_ImagesPath.Name = "textBox_Show_ImagesPath";
            textBox_Show_ImagesPath.ReadOnly = true;
            textBox_Show_ImagesPath.Size = new Size(151, 23);
            textBox_Show_ImagesPath.TabIndex = 8;
            // 
            // textBox_Add_Areas
            // 
            textBox_Add_Areas.Location = new Point(96, 67);
            textBox_Add_Areas.Name = "textBox_Add_Areas";
            textBox_Add_Areas.Size = new Size(65, 23);
            textBox_Add_Areas.TabIndex = 2;
            // 
            // label_Add_Areas
            // 
            label_Add_Areas.AutoSize = true;
            label_Add_Areas.Location = new Point(7, 70);
            label_Add_Areas.Name = "label_Add_Areas";
            label_Add_Areas.Size = new Size(43, 15);
            label_Add_Areas.TabIndex = 10;
            label_Add_Areas.Text = "置場数";
            // 
            // Add_WarehouseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(172, 184);
            ControlBox = false;
            Controls.Add(label_Add_Areas);
            Controls.Add(textBox_Add_Areas);
            Controls.Add(textBox_Show_ImagesPath);
            Controls.Add(button_Add_Images);
            Controls.Add(button_Cancel);
            Controls.Add(button_Apply);
            Controls.Add(comboBox_City);
            Controls.Add(label2);
            Controls.Add(label_City);
            Controls.Add(textBox_Name);
            Name = "Add_WarehouseList";
            Text = "倉庫登録";
            ResumeLayout(false);
            PerformLayout();
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
    }
}