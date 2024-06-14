namespace WHMS
{
    partial class Add_AdminList
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
            label_Group = new Label();
            label_Region = new Label();
            comboBox_Region = new ComboBox();
            button_Decide = new Button();
            dataGridView = new DataGridView();
            textBox_Group = new TextBox();
            label_Description = new Label();
            Container_Region = new SplitContainer();
            Container_Group = new SplitContainer();
            button_Cancel = new Button();
            panel1 = new Panel();
            Container_Initial = new SplitContainer();
            label_Initial = new Label();
            textBox_Initial = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Container_Region).BeginInit();
            Container_Region.Panel1.SuspendLayout();
            Container_Region.Panel2.SuspendLayout();
            Container_Region.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Container_Group).BeginInit();
            Container_Group.Panel1.SuspendLayout();
            Container_Group.Panel2.SuspendLayout();
            Container_Group.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Container_Initial).BeginInit();
            Container_Initial.Panel1.SuspendLayout();
            Container_Initial.Panel2.SuspendLayout();
            Container_Initial.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Group
            // 
            label_Group.Dock = DockStyle.Fill;
            label_Group.Location = new Point(0, 0);
            label_Group.Name = "label_Group";
            label_Group.Size = new Size(90, 23);
            label_Group.TabIndex = 1;
            label_Group.Text = "グループ";
            label_Group.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Region
            // 
            label_Region.Dock = DockStyle.Fill;
            label_Region.Location = new Point(0, 0);
            label_Region.Name = "label_Region";
            label_Region.Size = new Size(91, 23);
            label_Region.TabIndex = 2;
            label_Region.Text = "管轄";
            label_Region.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_Region
            // 
            comboBox_Region.Dock = DockStyle.Fill;
            comboBox_Region.FormattingEnabled = true;
            comboBox_Region.Location = new Point(0, 0);
            comboBox_Region.Name = "comboBox_Region";
            comboBox_Region.Size = new Size(190, 23);
            comboBox_Region.TabIndex = 0;
            // 
            // button_Decide
            // 
            button_Decide.Dock = DockStyle.Fill;
            button_Decide.Location = new Point(106, 3);
            button_Decide.Name = "button_Decide";
            button_Decide.Size = new Size(97, 27);
            button_Decide.TabIndex = 3;
            button_Decide.Text = "登録";
            button_Decide.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(0, 136);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(322, 226);
            dataGridView.TabIndex = 9;
            // 
            // textBox_Group
            // 
            textBox_Group.Dock = DockStyle.Fill;
            textBox_Group.Location = new Point(0, 0);
            textBox_Group.Name = "textBox_Group";
            textBox_Group.Size = new Size(191, 23);
            textBox_Group.TabIndex = 1;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.BackColor = Color.White;
            label_Description.Dock = DockStyle.Fill;
            label_Description.Font = new Font("Yu Gothic UI", 10F);
            label_Description.ForeColor = SystemColors.ActiveCaptionText;
            label_Description.Location = new Point(0, 0);
            label_Description.Margin = new Padding(0);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(103, 33);
            label_Description.TabIndex = 11;
            label_Description.Text = "登録情報";
            label_Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Container_Region
            // 
            Container_Region.Location = new Point(3, 3);
            Container_Region.Name = "Container_Region";
            // 
            // Container_Region.Panel1
            // 
            Container_Region.Panel1.Controls.Add(label_Region);
            // 
            // Container_Region.Panel2
            // 
            Container_Region.Panel2.Controls.Add(comboBox_Region);
            Container_Region.Size = new Size(285, 23);
            Container_Region.SplitterDistance = 91;
            Container_Region.TabIndex = 0;
            // 
            // Container_Group
            // 
            Container_Group.Location = new Point(3, 32);
            Container_Group.Name = "Container_Group";
            // 
            // Container_Group.Panel1
            // 
            Container_Group.Panel1.Controls.Add(label_Group);
            // 
            // Container_Group.Panel2
            // 
            Container_Group.Panel2.Controls.Add(textBox_Group);
            Container_Group.Size = new Size(285, 23);
            Container_Group.SplitterDistance = 90;
            Container_Group.TabIndex = 2;
            // 
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(209, 3);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(97, 27);
            button_Cancel.TabIndex = 4;
            button_Cancel.Text = "キャンセル";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(Container_Initial);
            panel1.Controls.Add(Container_Group);
            panel1.Controls.Add(Container_Region);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 90);
            panel1.TabIndex = 16;
            // 
            // Container_Initial
            // 
            Container_Initial.Location = new Point(3, 58);
            Container_Initial.Name = "Container_Initial";
            // 
            // Container_Initial.Panel1
            // 
            Container_Initial.Panel1.Controls.Add(label_Initial);
            // 
            // Container_Initial.Panel2
            // 
            Container_Initial.Panel2.Controls.Add(textBox_Initial);
            Container_Initial.Size = new Size(285, 23);
            Container_Initial.SplitterDistance = 90;
            Container_Initial.TabIndex = 1;
            // 
            // label_Initial
            // 
            label_Initial.Dock = DockStyle.Fill;
            label_Initial.Location = new Point(0, 0);
            label_Initial.Name = "label_Initial";
            label_Initial.Size = new Size(90, 23);
            label_Initial.TabIndex = 6;
            label_Initial.Text = "略字登録";
            label_Initial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Initial
            // 
            textBox_Initial.Dock = DockStyle.Fill;
            textBox_Initial.Location = new Point(0, 0);
            textBox_Initial.Name = "textBox_Initial";
            textBox_Initial.Size = new Size(191, 23);
            textBox_Initial.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button_Cancel, 2, 0);
            tableLayoutPanel1.Controls.Add(button_Decide, 1, 0);
            tableLayoutPanel1.Controls.Add(label_Description, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(309, 33);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // Add_AdminList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 362);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_AdminList";
            Text = "管理者登録";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            Container_Region.Panel1.ResumeLayout(false);
            Container_Region.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Container_Region).EndInit();
            Container_Region.ResumeLayout(false);
            Container_Group.Panel1.ResumeLayout(false);
            Container_Group.Panel2.ResumeLayout(false);
            Container_Group.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Container_Group).EndInit();
            Container_Group.ResumeLayout(false);
            panel1.ResumeLayout(false);
            Container_Initial.Panel1.ResumeLayout(false);
            Container_Initial.Panel2.ResumeLayout(false);
            Container_Initial.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Container_Initial).EndInit();
            Container_Initial.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label_Group;
        private Label label_Region;
        private ComboBox comboBox_Region;
        private Button button_Decide;
        private DataGridView dataGridView;
        private TextBox textBox_Group;
        private Label label_Description;
        private SplitContainer Container_Region;
        private SplitContainer Container_Group;
        private Panel panel1;
        private Button button_Cancel;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer Container_Initial;
        private Label label_Initial;
        private TextBox textBox_Initial;
    }
}