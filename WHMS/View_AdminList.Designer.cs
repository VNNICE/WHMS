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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 99);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(434, 150);
            dataGridView.TabIndex = 0;
            // 
            // button_GoToAddAdmin
            // 
            button_GoToAddAdmin.Location = new Point(12, 70);
            button_GoToAddAdmin.Name = "button_GoToAddAdmin";
            button_GoToAddAdmin.Size = new Size(75, 23);
            button_GoToAddAdmin.TabIndex = 1;
            button_GoToAddAdmin.Text = "管理者追加";
            button_GoToAddAdmin.UseVisualStyleBackColor = true;
            // 
            // View_AdminList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 261);
            Controls.Add(button_GoToAddAdmin);
            Controls.Add(dataGridView);
            Name = "View_AdminList";
            Text = "View_AdminList";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button button_GoToAddAdmin;
    }
}