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
            button_Decide = new Button();
            button_Skip = new Button();
            textBox_Name = new TextBox();
            textBox_SelectedArea = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox_Area2 = new TextBox();
            label_LWH = new Label();
            textBox_Height = new TextBox();
            textBox_Length = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox_Width = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Menu;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "倉庫名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Decide
            // 
            button_Decide.Location = new Point(3, 124);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(96, 23);
            button_Decide.TabIndex = 4;
            button_Decide.Text = "確定";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // button_Skip
            // 
            button_Skip.Location = new Point(113, 124);
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
            textBox_Name.Size = new Size(120, 23);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_SelectedArea
            // 
            textBox_SelectedArea.Enabled = false;
            textBox_SelectedArea.Location = new Point(94, 35);
            textBox_SelectedArea.Name = "textBox_SelectedArea";
            textBox_SelectedArea.ReadOnly = true;
            textBox_SelectedArea.Size = new Size(120, 23);
            textBox_SelectedArea.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Menu;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 7;
            label2.Text = "対象置場";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Menu;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 10;
            label3.Text = "置場区分2生成";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Area2
            // 
            textBox_Area2.Location = new Point(94, 64);
            textBox_Area2.Name = "textBox_Area2";
            textBox_Area2.Size = new Size(120, 23);
            textBox_Area2.TabIndex = 2;
            // 
            // label_LWH
            // 
            label_LWH.BackColor = SystemColors.Menu;
            label_LWH.Location = new Point(3, 95);
            label_LWH.Name = "label_LWH";
            label_LWH.Size = new Size(54, 23);
            label_LWH.TabIndex = 12;
            label_LWH.Text = "横幅";
            label_LWH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Height
            // 
            textBox_Height.Location = new Point(183, 95);
            textBox_Height.Name = "textBox_Height";
            textBox_Height.Size = new Size(30, 23);
            textBox_Height.TabIndex = 13;
            // 
            // textBox_Length
            // 
            textBox_Length.Location = new Point(113, 95);
            textBox_Length.Name = "textBox_Length";
            textBox_Length.Size = new Size(30, 23);
            textBox_Length.TabIndex = 14;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Menu;
            label4.Location = new Point(73, 95);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 15;
            label4.Text = "縦幅 ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Menu;
            label5.Location = new Point(143, 94);
            label5.Name = "label5";
            label5.Size = new Size(40, 23);
            label5.TabIndex = 16;
            label5.Text = "高さ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Width
            // 
            textBox_Width.Location = new Point(43, 95);
            textBox_Width.Name = "textBox_Width";
            textBox_Width.Size = new Size(30, 23);
            textBox_Width.TabIndex = 17;
            // 
            // Add_Warehouse_SecondInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 156);
            Controls.Add(textBox_Width);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_Length);
            Controls.Add(textBox_Height);
            Controls.Add(label_LWH);
            Controls.Add(label3);
            Controls.Add(textBox_Area2);
            Controls.Add(label2);
            Controls.Add(textBox_SelectedArea);
            Controls.Add(textBox_Name);
            Controls.Add(button_Skip);
            Controls.Add(button_Decide);
            Controls.Add(label1);
            Name = "Add_Warehouse_SecondInfo";
            Text = "Add_WarehouseSecondInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Decide;
        private Button button_Skip;
        private TextBox textBox_Name;
        private TextBox textBox_SelectedArea;
        private Label label2;
        private Label label3;
        private TextBox textBox_Area2;
        private Label label_LWH;
        private TextBox textBox_Height;
        private TextBox textBox_Length;
        private Label label4;
        private Label label5;
        private TextBox textBox_Width;
    }
}