namespace CookBook
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddIngrButton = new System.Windows.Forms.Button();
            this.comboBox1AddIngr = new System.Windows.Forms.ComboBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameOfRecipeLbl = new System.Windows.Forms.Label();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.listBox1DEtails = new System.Windows.Forms.ListBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NrOfIngredLbl = new System.Windows.Forms.Label();
            this.label2Category = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.AddIngrButton);
            this.groupBox1.Controls.Add(this.comboBox1AddIngr);
            this.groupBox1.Controls.Add(this.CategoryLbl);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.NameOfRecipeLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new recipe";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 287);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // AddIngrButton
            // 
            this.AddIngrButton.Location = new System.Drawing.Point(265, 67);
            this.AddIngrButton.Name = "AddIngrButton";
            this.AddIngrButton.Size = new System.Drawing.Size(135, 23);
            this.AddIngrButton.TabIndex = 4;
            this.AddIngrButton.Text = "Add ingredients";
            this.AddIngrButton.UseVisualStyleBackColor = true;
            this.AddIngrButton.Click += new System.EventHandler(this.AddIngrButton_Click);
            // 
            // comboBox1AddIngr
            // 
            this.comboBox1AddIngr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1AddIngr.FormattingEnabled = true;
            this.comboBox1AddIngr.Location = new System.Drawing.Point(104, 70);
            this.comboBox1AddIngr.Name = "comboBox1AddIngr";
            this.comboBox1AddIngr.Size = new System.Drawing.Size(121, 21);
            this.comboBox1AddIngr.TabIndex = 3;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(18, 70);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(49, 13);
            this.CategoryLbl.TabIndex = 2;
            this.CategoryLbl.Text = "Category";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 1;
            // 
            // NameOfRecipeLbl
            // 
            this.NameOfRecipeLbl.AutoSize = true;
            this.NameOfRecipeLbl.Location = new System.Drawing.Point(18, 29);
            this.NameOfRecipeLbl.Name = "NameOfRecipeLbl";
            this.NameOfRecipeLbl.Size = new System.Drawing.Size(79, 13);
            this.NameOfRecipeLbl.TabIndex = 0;
            this.NameOfRecipeLbl.Text = "Name of recipe";
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(143, 440);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(148, 23);
            this.AddRecipeButton.TabIndex = 1;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // listBox1DEtails
            // 
            this.listBox1DEtails.FormattingEnabled = true;
            this.listBox1DEtails.Location = new System.Drawing.Point(447, 105);
            this.listBox1DEtails.Name = "listBox1DEtails";
            this.listBox1DEtails.Size = new System.Drawing.Size(346, 316);
            this.listBox1DEtails.TabIndex = 2;
            this.listBox1DEtails.SelectedIndexChanged += new System.EventHandler(this.listBox1DEtails_SelectedIndexChanged);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(447, 81);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Name";
            // 
            // NrOfIngredLbl
            // 
            this.NrOfIngredLbl.AutoSize = true;
            this.NrOfIngredLbl.Location = new System.Drawing.Point(596, 86);
            this.NrOfIngredLbl.Name = "NrOfIngredLbl";
            this.NrOfIngredLbl.Size = new System.Drawing.Size(71, 13);
            this.NrOfIngredLbl.TabIndex = 4;
            this.NrOfIngredLbl.Text = "No. of ingred.";
            // 
            // label2Category
            // 
            this.label2Category.AutoSize = true;
            this.label2Category.Location = new System.Drawing.Point(719, 84);
            this.label2Category.Name = "label2Category";
            this.label2Category.Size = new System.Drawing.Size(49, 13);
            this.label2Category.TabIndex = 6;
            this.label2Category.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recipe Details";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(808, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 316);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 482);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2Category);
            this.Controls.Add(this.NrOfIngredLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.listBox1DEtails);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddIngrButton;
        private System.Windows.Forms.ComboBox comboBox1AddIngr;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameOfRecipeLbl;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.ListBox listBox1DEtails;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label NrOfIngredLbl;
        private System.Windows.Forms.Label label2Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

