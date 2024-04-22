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
            textBox_Shelf = new TextBox();
            label_W = new Label();
            textBox_Height = new TextBox();
            label_H = new Label();
            textBox_Width = new TextBox();
            textBox_Length = new TextBox();
            label_L = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            button_Decide.Click += button_Decide_Click;
            // 
            // button_Skip
            // 
            button_Skip.Location = new Point(113, 124);
            button_Skip.Name = "button_Skip";
            button_Skip.Size = new Size(101, 23);
            button_Skip.TabIndex = 5;
            button_Skip.Text = "スキップ";
            button_Skip.UseVisualStyleBackColor = true;
            button_Skip.Click += button_Skip_Click;
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
            label3.Text = "棚段";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Shelf
            // 
            textBox_Shelf.Enabled = false;
            textBox_Shelf.Location = new Point(94, 64);
            textBox_Shelf.Name = "textBox_Shelf";
            textBox_Shelf.ReadOnly = true;
            textBox_Shelf.Size = new Size(120, 23);
            textBox_Shelf.TabIndex = 2;
            // 
            // label_W
            // 
            label_W.BackColor = SystemColors.Menu;
            label_W.Location = new Point(58, 94);
            label_W.Name = "label_W";
            label_W.Size = new Size(54, 23);
            label_W.TabIndex = 12;
            label_W.Text = "横幅";
            label_W.TextAlign = ContentAlignment.MiddleCenter;
            label_W.Click += label_W_Click;
            // 
            // textBox_Height
            // 
            textBox_Height.Location = new Point(152, 96);
            textBox_Height.Name = "textBox_Height";
            textBox_Height.Size = new Size(30, 23);
            textBox_Height.TabIndex = 13;
            // 
            // label_H
            // 
            label_H.BackColor = SystemColors.Menu;
            label_H.Location = new Point(119, 95);
            label_H.Name = "label_H";
            label_H.Size = new Size(40, 23);
            label_H.TabIndex = 16;
            label_H.Text = "高さ";
            label_H.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Width
            // 
            textBox_Width.Location = new Point(94, 95);
            textBox_Width.Name = "textBox_Width";
            textBox_Width.Size = new Size(30, 23);
            textBox_Width.TabIndex = 17;
            textBox_Width.TextChanged += textBox_Width_TextChanged;
            // 
            // textBox_Length
            // 
            textBox_Length.Location = new Point(38, 94);
            textBox_Length.Name = "textBox_Length";
            textBox_Length.Size = new Size(33, 23);
            textBox_Length.TabIndex = 14;
            // 
            // label_L
            // 
            label_L.BackColor = SystemColors.Menu;
            label_L.Location = new Point(3, 94);
            label_L.Name = "label_L";
            label_L.Size = new Size(40, 23);
            label_L.TabIndex = 15;
            label_L.Text = "縦幅 ";
            label_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(220, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 141);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Add_Warehouse_SecondInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 155);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_Height);
            Controls.Add(textBox_Width);
            Controls.Add(textBox_Length);
            Controls.Add(label_L);
            Controls.Add(label_W);
            Controls.Add(label3);
            Controls.Add(textBox_Shelf);
            Controls.Add(label2);
            Controls.Add(textBox_SelectedArea);
            Controls.Add(textBox_Name);
            Controls.Add(button_Skip);
            Controls.Add(button_Decide);
            Controls.Add(label1);
            Controls.Add(label_H);
            Name = "Add_Warehouse_SecondInfo";
            Text = "Add_WarehouseSecondInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox_Shelf;
        private Label label_W;
        private TextBox textBox_Height;
        private Label label_H;
        private TextBox textBox_Width;
        private TextBox textBox_Length;
        private Label label_L;
        private PictureBox pictureBox1;
    }
}