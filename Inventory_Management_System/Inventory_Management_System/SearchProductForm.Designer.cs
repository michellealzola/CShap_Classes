namespace Inventory_Management_System
{
    partial class SearchProductForm
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
            label1 = new Label();
            input_Search = new TextBox();
            button_Search = new Button();
            listBox_SearchResult = new ListBox();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // input_Search
            // 
            input_Search.Location = new Point(185, 41);
            input_Search.Name = "input_Search";
            input_Search.Size = new Size(334, 33);
            input_Search.TabIndex = 1;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(41, 107);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(478, 58);
            button_Search.TabIndex = 2;
            button_Search.Text = "Search Products";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // listBox_SearchResult
            // 
            listBox_SearchResult.FormattingEnabled = true;
            listBox_SearchResult.ItemHeight = 25;
            listBox_SearchResult.Location = new Point(41, 185);
            listBox_SearchResult.Name = "listBox_SearchResult";
            listBox_SearchResult.Size = new Size(478, 104);
            listBox_SearchResult.TabIndex = 3;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(41, 312);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(478, 58);
            button_Exit.TabIndex = 2;
            button_Exit.Text = "E&xit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // SearchProductForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 396);
            Controls.Add(listBox_SearchResult);
            Controls.Add(button_Exit);
            Controls.Add(button_Search);
            Controls.Add(input_Search);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "SearchProductForm";
            Text = "Search Product Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_Search;
        private Button button_Search;
        private ListBox listBox_SearchResult;
        private Button button_Exit;
    }
}