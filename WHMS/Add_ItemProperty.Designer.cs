namespace WHMS
{
    partial class Add_ItemProperty
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
            label_Property = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_Initial = new Label();
            textBox_Property = new TextBox();
            textBox_Initial = new TextBox();
            button_Add = new Button();
            button_Cancel = new Button();
            dataGridView = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_Property
            // 
            label_Property.AutoSize = true;
            label_Property.Dock = DockStyle.Fill;
            label_Property.Location = new Point(3, 0);
            label_Property.Name = "label_Property";
            label_Property.Size = new Size(54, 29);
            label_Property.TabIndex = 2;
            label_Property.Text = "テクスト";
            label_Property.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(label_Initial, 0, 1);
            tableLayoutPanel1.Controls.Add(label_Property, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_Property, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_Initial, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(200, 58);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label_Initial
            // 
            label_Initial.AutoSize = true;
            label_Initial.Dock = DockStyle.Fill;
            label_Initial.Location = new Point(3, 29);
            label_Initial.Name = "label_Initial";
            label_Initial.Size = new Size(54, 29);
            label_Initial.TabIndex = 3;
            label_Initial.Text = "略字";
            label_Initial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Property
            // 
            textBox_Property.Dock = DockStyle.Fill;
            textBox_Property.Location = new Point(63, 3);
            textBox_Property.Name = "textBox_Property";
            textBox_Property.Size = new Size(134, 23);
            textBox_Property.TabIndex = 4;
            // 
            // textBox_Initial
            // 
            textBox_Initial.Dock = DockStyle.Fill;
            textBox_Initial.Location = new Point(63, 32);
            textBox_Initial.Name = "textBox_Initial";
            textBox_Initial.Size = new Size(134, 23);
            textBox_Initial.TabIndex = 5;
            // 
            // button_Add
            // 
            button_Add.Dock = DockStyle.Fill;
            button_Add.Location = new Point(3, 3);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 23);
            button_Add.TabIndex = 5;
            button_Add.Text = "追加";
            button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(103, 3);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 23);
            button_Cancel.TabIndex = 6;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 112);
            dataGridView.Margin = new Padding(0);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(223, 156);
            dataGridView.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button_Add, 0, 0);
            tableLayoutPanel2.Controls.Add(button_Cancel, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 70);
            tableLayoutPanel2.Margin = new Padding(3, 0, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(200, 29);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // Add_ItemProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 268);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView);
            Controls.Add(tableLayoutPanel1);
            Name = "Add_ItemProperty";
            Text = "Add_ItemProperty";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label_Property;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Initial;
        private Button button_Add;
        private Button button_Cancel;
        private TextBox textBox_Property;
        private TextBox textBox_Initial;
        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel2;
    }
}