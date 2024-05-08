using System.Windows.Forms;

namespace WHMS
{
    partial class View_WarehouseList_Area
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
            button_Cancel = new Button();
            label_Name = new Label();
            label_Area1 = new Label();
            label_Shelf = new Label();
            button_Add_Warehouse = new Button();
            dataGridView_WarehouseLists = new DataGridView();
            comboBox_Area = new ComboBox();
            pictureBox_Image = new PictureBox();
            comboBox_Shelf = new ComboBox();
            label_City = new Label();
            comboBox_City = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_WarehouseLists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Name
            // 
            comboBox_Name.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(212, 36);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(121, 23);
            comboBox_Name.TabIndex = 0;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            comboBox_Name.SelectionChangeCommitted += comboBox_Name_SelectionChangeCommitted;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(93, 4);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 3;
            button_Cancel.Text = "戻る";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(163, 40);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(43, 15);
            label_Name.TabIndex = 5;
            label_Name.Text = "倉庫名";
            label_Name.Click += label_Name_Click;
            // 
            // label_Area1
            // 
            label_Area1.AutoSize = true;
            label_Area1.Location = new Point(339, 40);
            label_Area1.Name = "label_Area1";
            label_Area1.Size = new Size(61, 15);
            label_Area1.TabIndex = 6;
            label_Area1.Text = "置場区分1";
            // 
            // label_Shelf
            // 
            label_Shelf.AutoSize = true;
            label_Shelf.Location = new Point(533, 40);
            label_Shelf.Name = "label_Shelf";
            label_Shelf.Size = new Size(61, 15);
            label_Shelf.TabIndex = 7;
            label_Shelf.Text = "置場区分2";
            // 
            // button_Add_Warehouse
            // 
            button_Add_Warehouse.Location = new Point(12, 4);
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
            // comboBox_Area
            // 
            comboBox_Area.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Area.FormattingEnabled = true;
            comboBox_Area.Location = new Point(406, 36);
            comboBox_Area.Name = "comboBox_Area";
            comboBox_Area.Size = new Size(121, 23);
            comboBox_Area.TabIndex = 13;
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
            // comboBox_Shelf
            // 
            comboBox_Shelf.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Shelf.FormattingEnabled = true;
            comboBox_Shelf.Location = new Point(600, 36);
            comboBox_Shelf.Name = "comboBox_Shelf";
            comboBox_Shelf.Size = new Size(121, 23);
            comboBox_Shelf.TabIndex = 17;
            // 
            // label_City
            // 
            label_City.AutoSize = true;
            label_City.Location = new Point(12, 40);
            label_City.Name = "label_City";
            label_City.Size = new Size(31, 15);
            label_City.TabIndex = 18;
            label_City.Text = "地域";
            // 
            // comboBox_City
            // 
            comboBox_City.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_City.FormattingEnabled = true;
            comboBox_City.Location = new Point(56, 36);
            comboBox_City.Name = "comboBox_City";
            comboBox_City.Size = new Size(101, 23);
            comboBox_City.TabIndex = 19;
            // 
            // View_WarehouseList_Area
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 290);
            Controls.Add(comboBox_City);
            Controls.Add(label_City);
            Controls.Add(comboBox_Shelf);
            Controls.Add(pictureBox_Image);
            Controls.Add(comboBox_Area);
            Controls.Add(dataGridView_WarehouseLists);
            Controls.Add(button_Add_Warehouse);
            Controls.Add(label_Shelf);
            Controls.Add(label_Area1);
            Controls.Add(label_Name);
            Controls.Add(button_Cancel);
            Controls.Add(comboBox_Name);
            Name = "View_WarehouseList_Area";
            Text = "Add_WarehouseList_Area";
            ((System.ComponentModel.ISupportInitialize)dataGridView_WarehouseLists).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Name;
        private Button button_Cancel;
        private Label label_Name;
        private Label label_Area1;
        private Label label_Shelf;
        private Button button_Add_Warehouse;
        private DataGridView dataGridView_WarehouseLists;
        private ComboBox comboBox_Area;
        private PictureBox pictureBox_Image;
        private ComboBox comboBox_Shelf;
        private Label label_City;
        private ComboBox comboBox_City;
    }
}