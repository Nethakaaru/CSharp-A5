namespace Assignment5
{
    partial class FormIngredient
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoOfIngredients = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.txtBoxAddIngredient = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of ingredients";
            // 
            // lblNoOfIngredients
            // 
            this.lblNoOfIngredients.AutoSize = true;
            this.lblNoOfIngredients.Location = new System.Drawing.Point(370, 13);
            this.lblNoOfIngredients.Name = "lblNoOfIngredients";
            this.lblNoOfIngredients.Size = new System.Drawing.Size(0, 13);
            this.lblNoOfIngredients.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteIngredient);
            this.groupBox1.Controls.Add(this.btnEditIngredient);
            this.groupBox1.Controls.Add(this.listBoxIngredients);
            this.groupBox1.Controls.Add(this.btnAddIngredient);
            this.groupBox1.Controls.Add(this.txtBoxAddIngredient);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient";
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Enabled = false;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(311, 129);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIngredient.TabIndex = 4;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Enabled = false;
            this.btnEditIngredient.Location = new System.Drawing.Point(311, 100);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnEditIngredient.TabIndex = 3;
            this.btnEditIngredient.Text = "Edit";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(7, 47);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(298, 186);
            this.listBoxIngredients.TabIndex = 2;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(311, 18);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 1;
            this.btnAddIngredient.Text = "Add ";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // txtBoxAddIngredient
            // 
            this.txtBoxAddIngredient.Location = new System.Drawing.Point(7, 20);
            this.txtBoxAddIngredient.Name = "txtBoxAddIngredient";
            this.txtBoxAddIngredient.Size = new System.Drawing.Size(298, 20);
            this.txtBoxAddIngredient.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(124, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNoOfIngredients);
            this.Controls.Add(this.label1);
            this.Name = "FormIngredient";
            this.Text = "FormIngredient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoOfIngredients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxAddIngredient;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Button button1;
    }
}