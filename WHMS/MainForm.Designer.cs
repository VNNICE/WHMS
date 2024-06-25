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
            button_WhManager = new Button();
            button1 = new Button();
            button_ItemManager = new Button();
            button_AdminManager = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button_WhManager
            // 
            button_WhManager.Font = new Font("Yu Gothic UI", 20F);
            button_WhManager.Location = new Point(12, 12);
            button_WhManager.Name = "button_WhManager";
            button_WhManager.Size = new Size(172, 90);
            button_WhManager.TabIndex = 1;
            button_WhManager.Text = "倉庫管理";
            button_WhManager.UseVisualStyleBackColor = true;
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
            // button_ItemManager
            // 
            button_ItemManager.Font = new Font("Yu Gothic UI", 20F);
            button_ItemManager.Location = new Point(12, 141);
            button_ItemManager.Name = "button_ItemManager";
            button_ItemManager.Size = new Size(172, 90);
            button_ItemManager.TabIndex = 3;
            button_ItemManager.Text = "ItemManager";
            button_ItemManager.UseVisualStyleBackColor = true;
            // 
            // button_AdminManager
            // 
            button_AdminManager.Font = new Font("Yu Gothic UI", 20F);
            button_AdminManager.Location = new Point(204, 141);
            button_AdminManager.Name = "button_AdminManager";
            button_AdminManager.Size = new Size(172, 90);
            button_AdminManager.TabIndex = 4;
            button_AdminManager.Text = "管理者管理";
            button_AdminManager.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(157, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 250);
            Controls.Add(button2);
            Controls.Add(button_AdminManager);
            Controls.Add(button_ItemManager);
            Controls.Add(button1);
            Controls.Add(button_WhManager);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button_WhManager;
        private Button button1;
        private Button button_ItemManager;
        private Button button_AdminManager;
        private Button button2;
    }
}
