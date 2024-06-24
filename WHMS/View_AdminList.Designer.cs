namespace WHMS
{
    partial class View_AdminList
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
            dataGridView = new DataGridView();
            button_GoToAddAdmin = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            comboBox_RegionList = new ComboBox();
            comboBox_SortGroup = new ComboBox();
            button_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 73);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(276, 217);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // button_GoToAddAdmin
            // 
            button_GoToAddAdmin.Dock = DockStyle.Fill;
            button_GoToAddAdmin.Location = new Point(153, 3);
            button_GoToAddAdmin.Name = "button_GoToAddAdmin";
            button_GoToAddAdmin.Size = new Size(104, 23);
            button_GoToAddAdmin.TabIndex = 1;
            button_GoToAddAdmin.Text = "管理者追加";
            button_GoToAddAdmin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBox_RegionList, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox_SortGroup, 1, 1);
            tableLayoutPanel1.Controls.Add(button_GoToAddAdmin, 2, 0);
            tableLayoutPanel1.Controls.Add(button_Back, 2, 1);
            tableLayoutPanel1.Location = new Point(9, 9);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(260, 61);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 0;
            label1.Text = "管轄";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 29);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 2;
            label3.Text = "グループ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_RegionList
            // 
            comboBox_RegionList.Dock = DockStyle.Fill;
            comboBox_RegionList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_RegionList.FormattingEnabled = true;
            comboBox_RegionList.Location = new Point(53, 3);
            comboBox_RegionList.Name = "comboBox_RegionList";
            comboBox_RegionList.Size = new Size(94, 23);
            comboBox_RegionList.TabIndex = 4;
            // 
            // comboBox_SortGroup
            // 
            comboBox_SortGroup.Dock = DockStyle.Fill;
            comboBox_SortGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_SortGroup.Enabled = false;
            comboBox_SortGroup.FormattingEnabled = true;
            comboBox_SortGroup.Location = new Point(53, 32);
            comboBox_SortGroup.Name = "comboBox_SortGroup";
            comboBox_SortGroup.Size = new Size(94, 23);
            comboBox_SortGroup.TabIndex = 5;
            // 
            // button_Back
            // 
            button_Back.Dock = DockStyle.Fill;
            button_Back.Location = new Point(153, 32);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(104, 26);
            button_Back.TabIndex = 6;
            button_Back.Text = "戻る";
            button_Back.UseVisualStyleBackColor = true;
            // 
            // View_AdminList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 290);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView);
            Name = "View_AdminList";
            Text = "View_AdminList";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button button_GoToAddAdmin;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox comboBox_RegionList;
        private Label label3;
        private ComboBox comboBox_SortGroup;
        private Button button_Back;
    }
}