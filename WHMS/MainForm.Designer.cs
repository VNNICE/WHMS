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
            button_Add_WarehouseList = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button_Add_WarehouseList
            // 
            button_Add_WarehouseList.Font = new Font("Yu Gothic UI", 20F);
            button_Add_WarehouseList.Location = new Point(12, 12);
            button_Add_WarehouseList.Name = "button_Add_WarehouseList";
            button_Add_WarehouseList.Size = new Size(172, 90);
            button_Add_WarehouseList.TabIndex = 1;
            button_Add_WarehouseList.Text = "倉庫管理";
            button_Add_WarehouseList.UseVisualStyleBackColor = true;
            button_Add_WarehouseList.Click += button_Add_WarehouseList_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 20F);
            button1.Location = new Point(204, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 90);
            button1.TabIndex = 2;
            button1.Text = "入出庫管理";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 20F);
            button2.Location = new Point(12, 141);
            button2.Name = "button2";
            button2.Size = new Size(172, 90);
            button2.TabIndex = 3;
            button2.Text = "機能３";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 20F);
            button3.Location = new Point(204, 141);
            button3.Name = "button3";
            button3.Size = new Size(172, 90);
            button3.TabIndex = 4;
            button3.Text = "機能４";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 250);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_Add_WarehouseList);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button_Add_WarehouseList;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
