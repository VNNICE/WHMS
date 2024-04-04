using System.Windows.Forms;

namespace WHMS
{
    partial class Add_WarehouseList_Area
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
            comboBox_Name = new ComboBox();
            button_Apply = new Button();
            button_Cancel = new Button();
            textBox_Area2 = new TextBox();
            label_Name = new Label();
            label_Area1 = new Label();
            label_Area2 = new Label();
            label_Err2 = new Label();
            button_Add_Warehouse = new Button();
            dataGridView_WarehouseLists = new DataGridView();
            comboBox_Area1 = new ComboBox();
            textBox1 = new TextBox();
            button_Add_Images = new Button();
            pictureBox_Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_WarehouseLists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Name
            // 
            comboBox_Name.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(61, 9);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(121, 23);
            comboBox_Name.TabIndex = 0;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            comboBox_Name.SelectionChangeCommitted += comboBox_Name_SelectionChangeCommitted;
            // 
            // button_Apply
            // 
            button_Apply.Location = new Point(627, 8);
            button_Apply.Name = "button_Apply";
            button_Apply.Size = new Size(75, 23);
            button_Apply.TabIndex = 2;
            button_Apply.Text = "追加";
            button_Apply.UseVisualStyleBackColor = true;
            button_Apply.Click += button_Apply_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(93, 38);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 3;
            button_Cancel.Text = "戻る";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // textBox_Area2
            // 
            textBox_Area2.Location = new Point(473, 9);
            textBox_Area2.Name = "textBox_Area2";
            textBox_Area2.Size = new Size(121, 23);
            textBox_Area2.TabIndex = 4;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(12, 12);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(43, 15);
            label_Name.TabIndex = 5;
            label_Name.Text = "倉庫名";
            label_Name.Click += label_Name_Click;
            // 
            // label_Area1
            // 
            label_Area1.AutoSize = true;
            label_Area1.Location = new Point(188, 12);
            label_Area1.Name = "label_Area1";
            label_Area1.Size = new Size(61, 15);
            label_Area1.TabIndex = 6;
            label_Area1.Text = "置場区分1";
            // 
            // label_Area2
            // 
            label_Area2.AutoSize = true;
            label_Area2.Location = new Point(382, 12);
            label_Area2.Name = "label_Area2";
            label_Area2.Size = new Size(85, 15);
            label_Area2.TabIndex = 7;
            label_Area2.Text = "置場区分2登録";
            // 
            // label_Err2
            // 
            label_Err2.AutoSize = true;
            label_Err2.BackColor = SystemColors.Menu;
            label_Err2.Enabled = false;
            label_Err2.ForeColor = Color.Red;
            label_Err2.Location = new Point(473, 12);
            label_Err2.Name = "label_Err2";
            label_Err2.Size = new Size(148, 15);
            label_Err2.TabIndex = 9;
            label_Err2.Text = "半角数字で入力してください。";
            // 
            // button_Add_Warehouse
            // 
            button_Add_Warehouse.Location = new Point(12, 38);
            button_Add_Warehouse.Name = "button_Add_Warehouse";
            button_Add_Warehouse.Size = new Size(75, 23);
            button_Add_Warehouse.TabIndex = 10;
            button_Add_Warehouse.Text = "倉庫登録へ";
            button_Add_Warehouse.UseVisualStyleBackColor = true;
            button_Add_Warehouse.Click += button_Add_Warehouse_Click;
            // 
            // dataGridView_WarehouseLists
            // 
            dataGridView_WarehouseLists.AllowUserToAddRows = false;
            dataGridView_WarehouseLists.AllowUserToDeleteRows = false;
            dataGridView_WarehouseLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_WarehouseLists.Location = new Point(12, 67);
            dataGridView_WarehouseLists.Name = "dataGridView_WarehouseLists";
            dataGridView_WarehouseLists.ReadOnly = true;
            dataGridView_WarehouseLists.Size = new Size(709, 211);
            dataGridView_WarehouseLists.TabIndex = 11;
            // 
            // comboBox_Area1
            // 
            comboBox_Area1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Area1.FormattingEnabled = true;
            comboBox_Area1.Location = new Point(255, 9);
            comboBox_Area1.Name = "comboBox_Area1";
            comboBox_Area1.Size = new Size(121, 23);
            comboBox_Area1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(473, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 14;
            // 
            // button_Add_Images
            // 
            button_Add_Images.Location = new Point(370, 38);
            button_Add_Images.Name = "button_Add_Images";
            button_Add_Images.Size = new Size(97, 23);
            button_Add_Images.TabIndex = 15;
            button_Add_Images.Text = "置場画像追加";
            button_Add_Images.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Image
            // 
            pictureBox_Image.Location = new Point(727, 8);
            pictureBox_Image.Name = "pictureBox_Image";
            pictureBox_Image.Size = new Size(260, 270);
            pictureBox_Image.TabIndex = 16;
            pictureBox_Image.TabStop = false;
            pictureBox_Image.Click += pictureBox_Image_Click;
            // 
            // Add_WarehouseList_Area
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 290);
            Controls.Add(pictureBox_Image);
            Controls.Add(button_Add_Images);
            Controls.Add(textBox1);
            Controls.Add(comboBox_Area1);
            Controls.Add(dataGridView_WarehouseLists);
            Controls.Add(button_Add_Warehouse);
            Controls.Add(label_Err2);
            Controls.Add(label_Area2);
            Controls.Add(label_Area1);
            Controls.Add(label_Name);
            Controls.Add(textBox_Area2);
            Controls.Add(button_Cancel);
            Controls.Add(button_Apply);
            Controls.Add(comboBox_Name);
            Name = "Add_WarehouseList_Area";
            Text = "Add_WarehouseList_Area";
            ((System.ComponentModel.ISupportInitialize)dataGridView_WarehouseLists).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Name;
        private Button button_Apply;
        private Button button_Cancel;
        private TextBox textBox_Area2;
        private Label label_Name;
        private Label label_Area1;
        private Label label_Area2;
        private Label label_Err2;
        private Button button_Add_Warehouse;
        private DataGridView dataGridView_WarehouseLists;
        private ComboBox comboBox_Area1;
        private TextBox textBox1;
        private Button button_Add_Images;
        private PictureBox pictureBox_Image;
    }
}