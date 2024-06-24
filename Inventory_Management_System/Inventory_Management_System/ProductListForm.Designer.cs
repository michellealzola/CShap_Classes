namespace Inventory_Management_System
{
    partial class ProductListForm
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
            listBox_ProductsInfo = new ListBox();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // listBox_ProductsInfo
            // 
            listBox_ProductsInfo.FormattingEnabled = true;
            listBox_ProductsInfo.ItemHeight = 25;
            listBox_ProductsInfo.Location = new Point(18, 20);
            listBox_ProductsInfo.Name = "listBox_ProductsInfo";
            listBox_ProductsInfo.Size = new Size(491, 404);
            listBox_ProductsInfo.TabIndex = 0;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(18, 446);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(491, 57);
            button_Exit.TabIndex = 1;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 530);
            Controls.Add(button_Exit);
            Controls.Add(listBox_ProductsInfo);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "ProductListForm";
            Text = "Product List Form";
            Load += ProductListForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button_Exit;
        protected internal ListBox listBox_ProductsInfo;
    }
}