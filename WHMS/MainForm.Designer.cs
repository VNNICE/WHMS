namespace WHMS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            管理者 = new DataGridViewTextBoxColumn();
            使用目的 = new DataGridViewTextBoxColumn();
            種類 = new DataGridViewTextBoxColumn();
            倉庫名 = new DataGridViewButtonColumn();
            button_Add_WarehouseList = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, 管理者, 使用目的, 種類, 倉庫名 });
            dataGridView1.Location = new Point(59, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 373);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // 管理者
            // 
            管理者.Frozen = true;
            管理者.HeaderText = "管理者";
            管理者.Name = "管理者";
            管理者.ReadOnly = true;
            // 
            // 使用目的
            // 
            使用目的.Frozen = true;
            使用目的.HeaderText = "使用目的";
            使用目的.Name = "使用目的";
            使用目的.ReadOnly = true;
            // 
            // 種類
            // 
            種類.Frozen = true;
            種類.HeaderText = "種類";
            種類.Name = "種類";
            種類.ReadOnly = true;
            // 
            // 倉庫名
            // 
            倉庫名.FlatStyle = FlatStyle.Flat;
            倉庫名.Frozen = true;
            倉庫名.HeaderText = "倉庫名";
            倉庫名.Name = "倉庫名";
            倉庫名.ReadOnly = true;
            倉庫名.Resizable = DataGridViewTriState.False;
            倉庫名.SortMode = DataGridViewColumnSortMode.Automatic;
            倉庫名.UseColumnTextForButtonValue = true;
            // 
            // button_Add_WarehouseList
            // 
            button_Add_WarehouseList.Location = new Point(499, 52);
            button_Add_WarehouseList.Name = "button_Add_WarehouseList";
            button_Add_WarehouseList.Size = new Size(75, 23);
            button_Add_WarehouseList.TabIndex = 1;
            button_Add_WarehouseList.Text = "倉庫管理";
            button_Add_WarehouseList.UseVisualStyleBackColor = true;
            button_Add_WarehouseList.Click += button_Add_WarehouseList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 458);
            Controls.Add(button_Add_WarehouseList);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn 管理者;
        private DataGridViewTextBoxColumn 使用目的;
        private DataGridViewTextBoxColumn 種類;
        private DataGridViewButtonColumn 倉庫名;
        private Button button_Add_WarehouseList;
    }
}
