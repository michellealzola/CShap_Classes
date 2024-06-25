namespace ReturningListofObjects
{
    partial class Form1
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
            input_ProductId = new TextBox();
            input_ProductName = new TextBox();
            input_Price = new TextBox();
            button_GetProductList = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 80);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 144);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 208);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // input_ProductId
            // 
            input_ProductId.Location = new Point(228, 76);
            input_ProductId.Name = "input_ProductId";
            input_ProductId.Size = new Size(350, 33);
            input_ProductId.TabIndex = 1;
            // 
            // input_ProductName
            // 
            input_ProductName.Location = new Point(228, 140);
            input_ProductName.Name = "input_ProductName";
            input_ProductName.Size = new Size(350, 33);
            input_ProductName.TabIndex = 2;
            // 
            // input_Price
            // 
            input_Price.Location = new Point(228, 204);
            input_Price.Name = "input_Price";
            input_Price.Size = new Size(350, 33);
            input_Price.TabIndex = 3;
            // 
            // button_GetProductList
            // 
            button_GetProductList.Location = new Point(42, 272);
            button_GetProductList.Name = "button_GetProductList";
            button_GetProductList.Size = new Size(536, 67);
            button_GetProductList.TabIndex = 4;
            button_GetProductList.Text = "Get Product List";
            button_GetProductList.UseVisualStyleBackColor = true;
            button_GetProductList.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 338);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 750);
            Controls.Add(dataGridView1);
            Controls.Add(button_GetProductList);
            Controls.Add(input_Price);
            Controls.Add(input_ProductName);
            Controls.Add(input_ProductId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Returning a List of Objects";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox input_ProductId;
        private TextBox input_ProductName;
        private TextBox input_Price;
        private Button button_GetProductList;
        private DataGridView dataGridView1;
    }
}
