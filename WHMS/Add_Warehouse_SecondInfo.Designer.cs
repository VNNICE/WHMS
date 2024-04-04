namespace WHMS
{
    partial class Add_Warehouse_SecondInfo
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
            label1 = new Label();
            butto_AddImage = new Button();
            button_Decide = new Button();
            button_Skip = new Button();
            textBox_Name = new TextBox();
            textBox_SelectedArea = new TextBox();
            label2 = new Label();
            textBox_ImagePath = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "倉庫名";
            // 
            // butto_AddImage
            // 
            butto_AddImage.Location = new Point(3, 93);
            butto_AddImage.Name = "butto_AddImage";
            butto_AddImage.Size = new Size(203, 23);
            butto_AddImage.TabIndex = 3;
            butto_AddImage.Text = "図面追加";
            butto_AddImage.UseVisualStyleBackColor = true;
            // 
            // button_Decide
            // 
            button_Decide.Location = new Point(3, 151);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(96, 23);
            button_Decide.TabIndex = 4;
            button_Decide.Text = "確定";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Skip
            // 
            button_Skip.Location = new Point(105, 151);
            button_Skip.Name = "button_Skip";
            button_Skip.Size = new Size(101, 23);
            button_Skip.TabIndex = 5;
            button_Skip.Text = "スキップ";
            button_Skip.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Enabled = false;
            textBox_Name.Location = new Point(94, 6);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.ReadOnly = true;
            textBox_Name.Size = new Size(112, 23);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_SelectedArea
            // 
            textBox_SelectedArea.Enabled = false;
            textBox_SelectedArea.Location = new Point(94, 35);
            textBox_SelectedArea.Name = "textBox_SelectedArea";
            textBox_SelectedArea.ReadOnly = true;
            textBox_SelectedArea.Size = new Size(112, 23);
            textBox_SelectedArea.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 38);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "対象置場";
            // 
            // textBox_ImagePath
            // 
            textBox_ImagePath.Enabled = false;
            textBox_ImagePath.Location = new Point(3, 122);
            textBox_ImagePath.Name = "textBox_ImagePath";
            textBox_ImagePath.ReadOnly = true;
            textBox_ImagePath.Size = new Size(203, 23);
            textBox_ImagePath.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 10;
            label3.Text = "置場区分2生成";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 2;
            // 
            // Add_Warehouse_SecondInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 183);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(textBox_ImagePath);
            Controls.Add(label2);
            Controls.Add(textBox_SelectedArea);
            Controls.Add(textBox_Name);
            Controls.Add(button_Skip);
            Controls.Add(button_Decide);
            Controls.Add(butto_AddImage);
            Controls.Add(label1);
            Name = "Add_Warehouse_SecondInfo";
            Text = "Add_WarehouseSecondInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butto_AddImage;
        private Button button_Decide;
        private Button button_Skip;
        private TextBox textBox_Name;
        private TextBox textBox_SelectedArea;
        private Label label2;
        private TextBox textBox_ImagePath;
        private Label label3;
        private TextBox textBox1;
    }
}