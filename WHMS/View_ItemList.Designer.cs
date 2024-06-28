namespace WHMS
{
    partial class View_ItemList
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
            button_New = new Button();
            button_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 142);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1216, 314);
            dataGridView.TabIndex = 0;
            // 
            // button_New
            // 
            button_New.Location = new Point(12, 113);
            button_New.Name = "button_New";
            button_New.Size = new Size(75, 23);
            button_New.TabIndex = 1;
            button_New.Text = "新規登録";
            button_New.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            button_Close.Location = new Point(93, 113);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(75, 23);
            button_Close.TabIndex = 2;
            button_Close.Text = "戻る";
            button_Close.UseVisualStyleBackColor = true;
            // 
            // View_ItemList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 468);
            Controls.Add(button_Close);
            Controls.Add(button_New);
            Controls.Add(dataGridView);
            Name = "View_ItemList";
            Text = "View_ItemList";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button button_New;
        private Button button_Close;
    }
}