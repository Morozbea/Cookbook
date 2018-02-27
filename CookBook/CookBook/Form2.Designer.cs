namespace CookBook
{
    partial class Form2
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
            this.NrOfIngrForm2Lbl = new System.Windows.Forms.Label();
            this.NrOfIngForm2Lbl = new System.Windows.Forms.Label();
            this.textBox1ingeredientsform2 = new System.Windows.Forms.TextBox();
            this.Form2Addbutton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxIngredForm2 = new System.Windows.Forms.GroupBox();
            this.groupBoxIngredForm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NrOfIngrForm2Lbl
            // 
            this.NrOfIngrForm2Lbl.AutoSize = true;
            this.NrOfIngrForm2Lbl.Location = new System.Drawing.Point(15, 22);
            this.NrOfIngrForm2Lbl.Name = "NrOfIngrForm2Lbl";
            this.NrOfIngrForm2Lbl.Size = new System.Drawing.Size(96, 13);
            this.NrOfIngrForm2Lbl.TabIndex = 0;
            this.NrOfIngrForm2Lbl.Text = "Num of Ingredients";
            // 
            // NrOfIngForm2Lbl
            // 
            this.NrOfIngForm2Lbl.AutoSize = true;
            this.NrOfIngForm2Lbl.Location = new System.Drawing.Point(388, 22);
            this.NrOfIngForm2Lbl.Name = "NrOfIngForm2Lbl";
            this.NrOfIngForm2Lbl.Size = new System.Drawing.Size(22, 13);
            this.NrOfIngForm2Lbl.TabIndex = 1;
            this.NrOfIngForm2Lbl.Text = ".....";
            // 
            // textBox1ingeredientsform2
            // 
            this.textBox1ingeredientsform2.Location = new System.Drawing.Point(6, 22);
            this.textBox1ingeredientsform2.Name = "textBox1ingeredientsform2";
            this.textBox1ingeredientsform2.Size = new System.Drawing.Size(357, 20);
            this.textBox1ingeredientsform2.TabIndex = 2;
            // 
            // Form2Addbutton1
            // 
            this.Form2Addbutton1.Location = new System.Drawing.Point(379, 19);
            this.Form2Addbutton1.Name = "Form2Addbutton1";
            this.Form2Addbutton1.Size = new System.Drawing.Size(75, 23);
            this.Form2Addbutton1.TabIndex = 3;
            this.Form2Addbutton1.Text = "Add";
            this.Form2Addbutton1.UseVisualStyleBackColor = true;
            this.Form2Addbutton1.Click += new System.EventHandler(this.Form2Addbutton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 225);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(379, 107);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(379, 136);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(83, 353);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(212, 353);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxIngredForm2
            // 
            this.groupBoxIngredForm2.Controls.Add(this.listBox1);
            this.groupBoxIngredForm2.Controls.Add(this.Form2Addbutton1);
            this.groupBoxIngredForm2.Controls.Add(this.textBox1ingeredientsform2);
            this.groupBoxIngredForm2.Controls.Add(this.buttonDelete);
            this.groupBoxIngredForm2.Controls.Add(this.buttonEdit);
            this.groupBoxIngredForm2.Location = new System.Drawing.Point(12, 45);
            this.groupBoxIngredForm2.Name = "groupBoxIngredForm2";
            this.groupBoxIngredForm2.Size = new System.Drawing.Size(469, 290);
            this.groupBoxIngredForm2.TabIndex = 9;
            this.groupBoxIngredForm2.TabStop = false;
            this.groupBoxIngredForm2.Text = "Ingredient";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 388);
            this.Controls.Add(this.groupBoxIngredForm2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.NrOfIngForm2Lbl);
            this.Controls.Add(this.NrOfIngrForm2Lbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxIngredForm2.ResumeLayout(false);
            this.groupBoxIngredForm2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NrOfIngrForm2Lbl;
        private System.Windows.Forms.Label NrOfIngForm2Lbl;
        private System.Windows.Forms.TextBox textBox1ingeredientsform2;
        private System.Windows.Forms.Button Form2Addbutton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxIngredForm2;
    }
}