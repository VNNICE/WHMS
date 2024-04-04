namespace WHMS
{
    partial class Add_ItemList
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            input_AssetType = new TextBox();
            input_Type = new TextBox();
            button1 = new Button();
            text_Object = new Label();
            Text_Type = new Label();
            text_AssetType = new Label();
            text_Name = new Label();
            text_Manufacturer = new Label();
            text_SerialNumber = new Label();
            text_Quantity = new Label();
            text_Memo = new Label();
            input_Name = new TextBox();
            input_Manufacturer = new TextBox();
            input_SerialNumber = new TextBox();
            input_Quantity = new TextBox();
            input_Memo = new TextBox();
            input_Object = new ComboBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // input_AssetType
            // 
            input_AssetType.Location = new Point(84, 121);
            input_AssetType.Name = "input_AssetType";
            input_AssetType.Size = new Size(100, 23);
            input_AssetType.TabIndex = 2;
            input_AssetType.TextChanged += input_AssetType_TextChanged;
            // 
            // input_Type
            // 
            input_Type.Location = new Point(84, 92);
            input_Type.Name = "input_Type";
            input_Type.Size = new Size(100, 23);
            input_Type.TabIndex = 3;
            input_Type.TextChanged += input_Type_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // text_Object
            // 
            text_Object.AutoSize = true;
            text_Object.Location = new Point(12, 62);
            text_Object.Name = "text_Object";
            text_Object.Size = new Size(55, 15);
            text_Object.TabIndex = 5;
            text_Object.Text = "使用目的";
            text_Object.Click += text_Object_Click;
            // 
            // Text_Type
            // 
            Text_Type.AutoSize = true;
            Text_Type.Location = new Point(29, 92);
            Text_Type.Name = "Text_Type";
            Text_Type.Size = new Size(31, 15);
            Text_Type.TabIndex = 6;
            Text_Type.Text = "種類";
            Text_Type.Click += text_Type_Click;
            // 
            // text_AssetType
            // 
            text_AssetType.AutoSize = true;
            text_AssetType.Location = new Point(14, 121);
            text_AssetType.Name = "text_AssetType";
            text_AssetType.Size = new Size(55, 15);
            text_AssetType.TabIndex = 7;
            text_AssetType.Text = "資産管理";
            text_AssetType.Click += text_AssetType_Click;
            // 
            // text_Name
            // 
            text_Name.AutoSize = true;
            text_Name.Location = new Point(29, 150);
            text_Name.Name = "text_Name";
            text_Name.Size = new Size(31, 15);
            text_Name.TabIndex = 8;
            text_Name.Text = "品名";
            text_Name.Click += text_Name_Click;
            // 
            // text_Manufacturer
            // 
            text_Manufacturer.AutoSize = true;
            text_Manufacturer.Location = new Point(27, 182);
            text_Manufacturer.Name = "text_Manufacturer";
            text_Manufacturer.Size = new Size(40, 15);
            text_Manufacturer.TabIndex = 9;
            text_Manufacturer.Text = "メーカー";
            // 
            // text_SerialNumber
            // 
            text_SerialNumber.AutoSize = true;
            text_SerialNumber.Location = new Point(29, 208);
            text_SerialNumber.Name = "text_SerialNumber";
            text_SerialNumber.Size = new Size(31, 15);
            text_SerialNumber.TabIndex = 10;
            text_SerialNumber.Text = "型番";
            // 
            // text_Quantity
            // 
            text_Quantity.AutoSize = true;
            text_Quantity.Location = new Point(29, 237);
            text_Quantity.Name = "text_Quantity";
            text_Quantity.Size = new Size(31, 15);
            text_Quantity.TabIndex = 11;
            text_Quantity.Text = "数量";
            // 
            // text_Memo
            // 
            text_Memo.AutoSize = true;
            text_Memo.Location = new Point(29, 266);
            text_Memo.Name = "text_Memo";
            text_Memo.Size = new Size(31, 15);
            text_Memo.TabIndex = 12;
            text_Memo.Text = "備考";
            // 
            // input_Name
            // 
            input_Name.Location = new Point(84, 150);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(100, 23);
            input_Name.TabIndex = 13;
            // 
            // input_Manufacturer
            // 
            input_Manufacturer.Location = new Point(84, 179);
            input_Manufacturer.Name = "input_Manufacturer";
            input_Manufacturer.Size = new Size(100, 23);
            input_Manufacturer.TabIndex = 14;
            input_Manufacturer.TextChanged += input_Manufacturer_TextChanged;
            // 
            // input_SerialNumber
            // 
            input_SerialNumber.Location = new Point(84, 208);
            input_SerialNumber.Name = "input_SerialNumber";
            input_SerialNumber.Size = new Size(100, 23);
            input_SerialNumber.TabIndex = 15;
            input_SerialNumber.TextChanged += input_SerialNumber_TextChanged;
            // 
            // input_Quantity
            // 
            input_Quantity.Location = new Point(84, 237);
            input_Quantity.Name = "input_Quantity";
            input_Quantity.Size = new Size(100, 23);
            input_Quantity.TabIndex = 16;
            input_Quantity.TextChanged += input_Quantity_TextChanged;
            // 
            // input_Memo
            // 
            input_Memo.Location = new Point(84, 266);
            input_Memo.Name = "input_Memo";
            input_Memo.Size = new Size(100, 23);
            input_Memo.TabIndex = 17;
            input_Memo.TextChanged += input_Memo_TextChanged;
            // 
            // input_Object
            // 
            input_Object.AutoCompleteMode = AutoCompleteMode.Suggest;
            input_Object.AutoCompleteSource = AutoCompleteSource.ListItems;
            input_Object.FormattingEnabled = true;
            input_Object.Location = new Point(73, 62);
            input_Object.Name = "input_Object";
            input_Object.Size = new Size(121, 23);
            input_Object.TabIndex = 18;
            // 
            // Add_ItemList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 321);
            Controls.Add(input_Object);
            Controls.Add(input_Memo);
            Controls.Add(input_Quantity);
            Controls.Add(input_SerialNumber);
            Controls.Add(input_Manufacturer);
            Controls.Add(input_Name);
            Controls.Add(text_Memo);
            Controls.Add(text_Quantity);
            Controls.Add(text_SerialNumber);
            Controls.Add(text_Manufacturer);
            Controls.Add(text_Name);
            Controls.Add(text_AssetType);
            Controls.Add(Text_Type);
            Controls.Add(text_Object);
            Controls.Add(button1);
            Controls.Add(input_Type);
            Controls.Add(input_AssetType);
            Name = "Add_ItemList";
            Text = "Add_ItemList";
            Load += Add_ItemList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox input_AssetType;
        private TextBox input_Type;
        private Button button1;
        private Label text_Object;
        private Label Text_Type;
        private Label text_AssetType;
        private Label text_Name;
        private Label text_Manufacturer;
        private Label text_SerialNumber;
        private Label text_Quantity;
        private Label text_Memo;
        private TextBox input_Name;
        private TextBox input_Manufacturer;
        private TextBox input_SerialNumber;
        private TextBox input_Quantity;
        private TextBox input_Memo;
        private ComboBox input_Object;
    }
}