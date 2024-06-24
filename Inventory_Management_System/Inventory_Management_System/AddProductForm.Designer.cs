namespace Inventory_Management_System
{
    partial class AddProductForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            input_ProductId = new TextBox();
            input_Name = new TextBox();
            input_Price = new TextBox();
            input_Quantity = new TextBox();
            button_AddProduct = new Button();
            button_SearchProduct = new Button();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 124);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 189);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 254);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 0;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 319);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 0;
            label4.Text = "Quantity:";
            // 
            // input_ProductId
            // 
            input_ProductId.Location = new Point(226, 120);
            input_ProductId.Name = "input_ProductId";
            input_ProductId.Size = new Size(419, 33);
            input_ProductId.TabIndex = 1;
            // 
            // input_Name
            // 
            input_Name.Location = new Point(226, 185);
            input_Name.Name = "input_Name";
            input_Name.Size = new Size(419, 33);
            input_Name.TabIndex = 2;
            // 
            // input_Price
            // 
            input_Price.Location = new Point(226, 250);
            input_Price.Name = "input_Price";
            input_Price.Size = new Size(419, 33);
            input_Price.TabIndex = 3;
            // 
            // input_Quantity
            // 
            input_Quantity.Location = new Point(226, 315);
            input_Quantity.Name = "input_Quantity";
            input_Quantity.Size = new Size(419, 33);
            input_Quantity.TabIndex = 4;
            // 
            // button_AddProduct
            // 
            button_AddProduct.Location = new Point(81, 405);
            button_AddProduct.Name = "button_AddProduct";
            button_AddProduct.Size = new Size(564, 59);
            button_AddProduct.TabIndex = 5;
            button_AddProduct.Text = "Add Product";
            button_AddProduct.UseVisualStyleBackColor = true;
            button_AddProduct.Click += button_AddProduct_Click;
            // 
            // button_SearchProduct
            // 
            button_SearchProduct.Location = new Point(81, 470);
            button_SearchProduct.Name = "button_SearchProduct";
            button_SearchProduct.Size = new Size(564, 59);
            button_SearchProduct.TabIndex = 6;
            button_SearchProduct.Text = "Search Product";
            button_SearchProduct.UseVisualStyleBackColor = true;
            button_SearchProduct.Click += button_SearchProduct_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(81, 535);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(564, 59);
            button_Exit.TabIndex = 7;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 750);
            Controls.Add(button_Exit);
            Controls.Add(button_SearchProduct);
            Controls.Add(button_AddProduct);
            Controls.Add(input_Quantity);
            Controls.Add(input_Price);
            Controls.Add(input_Name);
            Controls.Add(input_ProductId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "AddProductForm";
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox input_ProductId;
        private TextBox input_Name;
        private TextBox input_Price;
        private TextBox input_Quantity;
        private Button button_AddProduct;
        private Button button_SearchProduct;
        private Button button_Exit;
    }
}
