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
            label_LW = new Label();
            textBox_Length = new TextBox();
            textBox_Width = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Menu;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "倉庫名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butto_AddImage
            // 
            butto_AddImage.Location = new Point(3, 122);
            butto_AddImage.Name = "butto_AddImage";
            butto_AddImage.Size = new Size(203, 23);
            butto_AddImage.TabIndex = 3;
            butto_AddImage.Text = "図面追加";
            butto_AddImage.UseVisualStyleBackColor = true;
            // 
            // button_Decide
            // 
            button_Decide.Location = new Point(3, 180);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(96, 23);
            button_Decide.TabIndex = 4;
            button_Decide.Text = "確定";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Skip
            // 
            button_Skip.Location = new Point(105, 180);
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
            label2.BackColor = SystemColors.Menu;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 7;
            label2.Text = "対象置場";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_ImagePath
            // 
            textBox_ImagePath.Enabled = false;
            textBox_ImagePath.Location = new Point(3, 151);
            textBox_ImagePath.Name = "textBox_ImagePath";
            textBox_ImagePath.ReadOnly = true;
            textBox_ImagePath.Size = new Size(203, 23);
            textBox_ImagePath.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Menu;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 10;
            label3.Text = "置場区分2生成";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 2;
            // 
            // label_LW
            // 
            label_LW.BackColor = SystemColors.Menu;
            label_LW.Location = new Point(3, 93);
            label_LW.Name = "label_LW";
            label_LW.Size = new Size(85, 15);
            label_LW.TabIndex = 12;
            label_LW.Text = "縦幅 / 横幅";
            label_LW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Length
            // 
            textBox_Length.Location = new Point(94, 93);
            textBox_Length.Name = "textBox_Length";
            textBox_Length.Size = new Size(40, 23);
            textBox_Length.TabIndex = 13;
            // 
            // textBox_Width
            // 
            textBox_Width.Location = new Point(166, 94);
            textBox_Width.Name = "textBox_Width";
            textBox_Width.Size = new Size(40, 23);
            textBox_Width.TabIndex = 14;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Menu;
            label4.Location = new Point(134, 93);
            label4.Name = "label4";
            label4.Size = new Size(32, 23);
            label4.TabIndex = 15;
            label4.Text = "/ ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Add_Warehouse_SecondInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 216);
            Controls.Add(label4);
            Controls.Add(textBox_Width);
            Controls.Add(textBox_Length);
            Controls.Add(label_LW);
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
        private Label label_LW;
        private TextBox textBox_Length;
        private TextBox textBox_Width;
        private Label label4;
    }
}