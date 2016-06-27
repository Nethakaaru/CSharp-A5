namespace Assignment5
{
    partial class MainForm
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
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRecipeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDetails = new System.Windows.Forms.TextBox();
            this.btnDelRecipe = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxRecipeIngredients = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxDesc);
            this.groupBox1.Controls.Add(this.btnAddIngredients);
            this.groupBox1.Controls.Add(this.cBoxCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxRecipeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new recipe";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(6, 77);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(333, 212);
            this.txtBoxDesc.TabIndex = 5;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(242, 48);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(98, 23);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(93, 48);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.cBoxCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // txtBoxRecipeName
            // 
            this.txtBoxRecipeName.Location = new System.Drawing.Point(93, 12);
            this.txtBoxRecipeName.Name = "txtBoxRecipeName";
            this.txtBoxRecipeName.Size = new System.Drawing.Size(247, 20);
            this.txtBoxRecipeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(16, 322);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(336, 23);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 14;
            this.listBoxRecipes.Location = new System.Drawing.Point(382, 38);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(331, 256);
            this.listBoxRecipes.TabIndex = 2;
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. of ingredients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Location = new System.Drawing.Point(392, 321);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(146, 23);
            this.btnEditRecipe.TabIndex = 7;
            this.btnEditRecipe.Text = "Edit Recipe";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(849, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Recipe Details";
            // 
            // txtBoxDetails
            // 
            this.txtBoxDetails.Location = new System.Drawing.Point(751, 38);
            this.txtBoxDetails.Multiline = true;
            this.txtBoxDetails.Name = "txtBoxDetails";
            this.txtBoxDetails.ReadOnly = true;
            this.txtBoxDetails.Size = new System.Drawing.Size(263, 127);
            this.txtBoxDetails.TabIndex = 9;
            this.txtBoxDetails.Text = "Click on a recipe";
            // 
            // btnDelRecipe
            // 
            this.btnDelRecipe.Location = new System.Drawing.Point(588, 321);
            this.btnDelRecipe.Name = "btnDelRecipe";
            this.btnDelRecipe.Size = new System.Drawing.Size(125, 23);
            this.btnDelRecipe.TabIndex = 10;
            this.btnDelRecipe.Text = "Delete Recipe";
            this.btnDelRecipe.UseVisualStyleBackColor = true;
            this.btnDelRecipe.Click += new System.EventHandler(this.btnDelRecipe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ingredients";
            // 
            // txtBoxRecipeIngredients
            // 
            this.txtBoxRecipeIngredients.Location = new System.Drawing.Point(751, 198);
            this.txtBoxRecipeIngredients.Multiline = true;
            this.txtBoxRecipeIngredients.Name = "txtBoxRecipeIngredients";
            this.txtBoxRecipeIngredients.ReadOnly = true;
            this.txtBoxRecipeIngredients.Size = new System.Drawing.Size(263, 127);
            this.txtBoxRecipeIngredients.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 356);
            this.Controls.Add(this.txtBoxRecipeIngredients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelRecipe);
            this.Controls.Add(this.txtBoxDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Apu\'s Cook Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRecipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDetails;
        private System.Windows.Forms.Button btnDelRecipe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxRecipeIngredients;
    }
}

