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
            textBox_Depth = new TextBox();
            label_H = new Label();
            textBox_Width = new TextBox();
            textBox_Height = new TextBox();
            label_D = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Menu;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 0;
            label1.Text = "倉庫名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Decide
            // 
            button_Decide.Dock = DockStyle.Fill;
            button_Decide.Location = new Point(3, 3);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(110, 27);
            button_Decide.TabIndex = 3;
            button_Decide.Text = "確定";
            button_Decide.UseVisualStyleBackColor = true;
            button_Decide.Click += button_Decide_Click;
            // 
            // button_Skip
            // 
            button_Skip.Dock = DockStyle.Fill;
            button_Skip.Location = new Point(119, 3);
            button_Skip.Name = "button_Skip";
            button_Skip.Size = new Size(110, 27);
            button_Skip.TabIndex = 4;
            button_Skip.Text = "スキップ";
            button_Skip.UseVisualStyleBackColor = true;
            button_Skip.Click += button_Skip_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Dock = DockStyle.Fill;
            textBox_Name.Enabled = false;
            textBox_Name.Location = new Point(119, 3);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.ReadOnly = true;
            textBox_Name.Size = new Size(110, 23);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_SelectedArea
            // 
            textBox_SelectedArea.Dock = DockStyle.Fill;
            textBox_SelectedArea.Enabled = false;
            textBox_SelectedArea.Location = new Point(119, 32);
            textBox_SelectedArea.Name = "textBox_SelectedArea";
            textBox_SelectedArea.ReadOnly = true;
            textBox_SelectedArea.Size = new Size(110, 23);
            textBox_SelectedArea.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Menu;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 7;
            label2.Text = "対象置場";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Menu;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 10;
            label3.Text = "棚段";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Shelf
            // 
            textBox_Shelf.Dock = DockStyle.Fill;
            textBox_Shelf.Enabled = false;
            textBox_Shelf.Location = new Point(119, 61);
            textBox_Shelf.Name = "textBox_Shelf";
            textBox_Shelf.ReadOnly = true;
            textBox_Shelf.Size = new Size(110, 23);
            textBox_Shelf.TabIndex = 2;
            // 
            // label_W
            // 
            label_W.BackColor = SystemColors.Menu;
            label_W.Dock = DockStyle.Fill;
            label_W.Location = new Point(3, 87);
            label_W.Name = "label_W";
            label_W.Size = new Size(110, 29);
            label_W.TabIndex = 12;
            label_W.Text = "幅";
            label_W.TextAlign = ContentAlignment.MiddleCenter;
            label_W.Click += label_W_Click;
            // 
            // textBox_Depth
            // 
            textBox_Depth.Dock = DockStyle.Fill;
            textBox_Depth.Location = new Point(119, 119);
            textBox_Depth.Name = "textBox_Depth";
            textBox_Depth.Size = new Size(110, 23);
            textBox_Depth.TabIndex = 1;
            // 
            // label_H
            // 
            label_H.BackColor = SystemColors.Menu;
            label_H.Dock = DockStyle.Fill;
            label_H.Location = new Point(3, 145);
            label_H.Name = "label_H";
            label_H.Size = new Size(110, 29);
            label_H.TabIndex = 1;
            label_H.Text = "高さ";
            label_H.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Width
            // 
            textBox_Width.Dock = DockStyle.Fill;
            textBox_Width.Location = new Point(119, 90);
            textBox_Width.Name = "textBox_Width";
            textBox_Width.Size = new Size(110, 23);
            textBox_Width.TabIndex = 0;
            textBox_Width.TextChanged += textBox_Width_TextChanged;
            // 
            // textBox_Height
            // 
            textBox_Height.Dock = DockStyle.Fill;
            textBox_Height.Location = new Point(119, 148);
            textBox_Height.Name = "textBox_Height";
            textBox_Height.Size = new Size(110, 23);
            textBox_Height.TabIndex = 2;
            // 
            // label_D
            // 
            label_D.BackColor = SystemColors.Menu;
            label_D.Dock = DockStyle.Fill;
            label_D.Location = new Point(3, 116);
            label_D.Name = "label_D";
            label_D.Size = new Size(110, 29);
            label_D.TabIndex = 4;
            label_D.Text = "奥行";
            label_D.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox_Name, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_Height, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox_Depth, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_Width, 1, 3);
            tableLayoutPanel1.Controls.Add(label_H, 0, 5);
            tableLayoutPanel1.Controls.Add(label_D, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox_SelectedArea, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label_W, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox_Shelf, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(232, 174);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button_Decide, 0, 0);
            tableLayoutPanel2.Controls.Add(button_Skip, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 186);
            tableLayoutPanel2.Margin = new Padding(3, 0, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(232, 33);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // Add_Warehouse_SecondInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 228);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_Warehouse_SecondInfo";
            Text = "Add_WarehouseSecondInfo";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox textBox_Depth;
        private Label label_H;
        private TextBox textBox_Width;
        private TextBox textBox_Height;
        private Label label_D;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}