namespace Assignment4
{
    partial class ChezSouSadForm
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
            this.lblListDishes = new System.Windows.Forms.Label();
            this.lstDishes = new System.Windows.Forms.ListView();
            this.lstSelectedPreppedItems = new System.Windows.Forms.ListView();
            this.lstPreppedItems = new System.Windows.Forms.ListView();
            this.btnSelectDish = new System.Windows.Forms.Button();
            this.btnDeslectDish = new System.Windows.Forms.Button();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.txtAddDish = new System.Windows.Forms.TextBox();
            this.txtAddPrepped = new System.Windows.Forms.TextBox();
            this.btnAddPrepped = new System.Windows.Forms.Button();
            this.txtAddRaw = new System.Windows.Forms.TextBox();
            this.btnAddRaw = new System.Windows.Forms.Button();
            this.btnDeselectRaw = new System.Windows.Forms.Button();
            this.btnSelectRaw = new System.Windows.Forms.Button();
            this.lstRaw = new System.Windows.Forms.ListView();
            this.lstSelectedRaw = new System.Windows.Forms.ListView();
            this.lblSelectedPreppedItem = new System.Windows.Forms.Label();
            this.lblPreppedItems = new System.Windows.Forms.Label();
            this.lblSelectedRaw = new System.Windows.Forms.Label();
            this.lblRaw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListDishes
            // 
            this.lblListDishes.AutoSize = true;
            this.lblListDishes.Location = new System.Drawing.Point(12, 30);
            this.lblListDishes.Name = "lblListDishes";
            this.lblListDishes.Size = new System.Drawing.Size(106, 16);
            this.lblListDishes.TabIndex = 0;
            this.lblListDishes.Text = "List of all Dishes:";
            // 
            // lstDishes
            // 
            this.lstDishes.HideSelection = false;
            this.lstDishes.Location = new System.Drawing.Point(12, 49);
            this.lstDishes.Name = "lstDishes";
            this.lstDishes.Size = new System.Drawing.Size(901, 101);
            this.lstDishes.TabIndex = 1;
            this.lstDishes.Tag = "";
            this.lstDishes.UseCompatibleStateImageBehavior = false;
            // 
            // lstSelectedPreppedItems
            // 
            this.lstSelectedPreppedItems.HideSelection = false;
            this.lstSelectedPreppedItems.Location = new System.Drawing.Point(15, 248);
            this.lstSelectedPreppedItems.Name = "lstSelectedPreppedItems";
            this.lstSelectedPreppedItems.Size = new System.Drawing.Size(339, 127);
            this.lstSelectedPreppedItems.TabIndex = 2;
            this.lstSelectedPreppedItems.UseCompatibleStateImageBehavior = false;
            // 
            // lstPreppedItems
            // 
            this.lstPreppedItems.HideSelection = false;
            this.lstPreppedItems.Location = new System.Drawing.Point(523, 248);
            this.lstPreppedItems.Name = "lstPreppedItems";
            this.lstPreppedItems.Size = new System.Drawing.Size(391, 127);
            this.lstPreppedItems.TabIndex = 3;
            this.lstPreppedItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelectDish
            // 
            this.btnSelectDish.Location = new System.Drawing.Point(384, 248);
            this.btnSelectDish.Name = "btnSelectDish";
            this.btnSelectDish.Size = new System.Drawing.Size(110, 52);
            this.btnSelectDish.TabIndex = 4;
            this.btnSelectDish.Text = "<--";
            this.btnSelectDish.UseVisualStyleBackColor = true;
            // 
            // btnDeslectDish
            // 
            this.btnDeslectDish.Location = new System.Drawing.Point(384, 323);
            this.btnDeslectDish.Name = "btnDeslectDish";
            this.btnDeslectDish.Size = new System.Drawing.Size(110, 52);
            this.btnDeslectDish.TabIndex = 5;
            this.btnDeslectDish.Text = "-->";
            this.btnDeslectDish.UseVisualStyleBackColor = true;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(532, 156);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(86, 57);
            this.btnAddDish.TabIndex = 6;
            this.btnAddDish.Text = "Add New Dish";
            this.btnAddDish.UseVisualStyleBackColor = true;
            // 
            // txtAddDish
            // 
            this.txtAddDish.Location = new System.Drawing.Point(625, 176);
            this.txtAddDish.Name = "txtAddDish";
            this.txtAddDish.Size = new System.Drawing.Size(289, 22);
            this.txtAddDish.TabIndex = 7;
            // 
            // txtAddPrepped
            // 
            this.txtAddPrepped.Location = new System.Drawing.Point(624, 406);
            this.txtAddPrepped.Name = "txtAddPrepped";
            this.txtAddPrepped.Size = new System.Drawing.Size(289, 22);
            this.txtAddPrepped.TabIndex = 9;
            // 
            // btnAddPrepped
            // 
            this.btnAddPrepped.Location = new System.Drawing.Point(531, 386);
            this.btnAddPrepped.Name = "btnAddPrepped";
            this.btnAddPrepped.Size = new System.Drawing.Size(86, 57);
            this.btnAddPrepped.TabIndex = 8;
            this.btnAddPrepped.Text = "Add New Prepped Item";
            this.btnAddPrepped.UseVisualStyleBackColor = true;
            // 
            // txtAddRaw
            // 
            this.txtAddRaw.Location = new System.Drawing.Point(624, 642);
            this.txtAddRaw.Name = "txtAddRaw";
            this.txtAddRaw.Size = new System.Drawing.Size(289, 22);
            this.txtAddRaw.TabIndex = 15;
            // 
            // btnAddRaw
            // 
            this.btnAddRaw.Location = new System.Drawing.Point(531, 622);
            this.btnAddRaw.Name = "btnAddRaw";
            this.btnAddRaw.Size = new System.Drawing.Size(86, 57);
            this.btnAddRaw.TabIndex = 14;
            this.btnAddRaw.Text = "Add New Raw Ingredient\r\n";
            this.btnAddRaw.UseVisualStyleBackColor = true;
            // 
            // btnDeselectRaw
            // 
            this.btnDeselectRaw.Location = new System.Drawing.Point(384, 559);
            this.btnDeselectRaw.Name = "btnDeselectRaw";
            this.btnDeselectRaw.Size = new System.Drawing.Size(110, 52);
            this.btnDeselectRaw.TabIndex = 13;
            this.btnDeselectRaw.Text = "-->";
            this.btnDeselectRaw.UseVisualStyleBackColor = true;
            // 
            // btnSelectRaw
            // 
            this.btnSelectRaw.Location = new System.Drawing.Point(384, 484);
            this.btnSelectRaw.Name = "btnSelectRaw";
            this.btnSelectRaw.Size = new System.Drawing.Size(110, 52);
            this.btnSelectRaw.TabIndex = 12;
            this.btnSelectRaw.Text = "<--";
            this.btnSelectRaw.UseVisualStyleBackColor = true;
            // 
            // lstRaw
            // 
            this.lstRaw.HideSelection = false;
            this.lstRaw.Location = new System.Drawing.Point(523, 484);
            this.lstRaw.Name = "lstRaw";
            this.lstRaw.Size = new System.Drawing.Size(391, 127);
            this.lstRaw.TabIndex = 11;
            this.lstRaw.UseCompatibleStateImageBehavior = false;
            // 
            // lstSelectedRaw
            // 
            this.lstSelectedRaw.HideSelection = false;
            this.lstSelectedRaw.Location = new System.Drawing.Point(15, 484);
            this.lstSelectedRaw.Name = "lstSelectedRaw";
            this.lstSelectedRaw.Size = new System.Drawing.Size(339, 127);
            this.lstSelectedRaw.TabIndex = 10;
            this.lstSelectedRaw.UseCompatibleStateImageBehavior = false;
            // 
            // lblSelectedPreppedItem
            // 
            this.lblSelectedPreppedItem.AutoSize = true;
            this.lblSelectedPreppedItem.Location = new System.Drawing.Point(12, 229);
            this.lblSelectedPreppedItem.Name = "lblSelectedPreppedItem";
            this.lblSelectedPreppedItem.Size = new System.Drawing.Size(198, 16);
            this.lblSelectedPreppedItem.TabIndex = 16;
            this.lblSelectedPreppedItem.Text = "Prepped Items in Selected Dish:";
            // 
            // lblPreppedItems
            // 
            this.lblPreppedItems.AutoSize = true;
            this.lblPreppedItems.Location = new System.Drawing.Point(520, 229);
            this.lblPreppedItems.Name = "lblPreppedItems";
            this.lblPreppedItems.Size = new System.Drawing.Size(152, 16);
            this.lblPreppedItems.TabIndex = 17;
            this.lblPreppedItems.Text = "List of all Prepped Items:";
            // 
            // lblSelectedRaw
            // 
            this.lblSelectedRaw.AutoSize = true;
            this.lblSelectedRaw.Location = new System.Drawing.Point(12, 465);
            this.lblSelectedRaw.Name = "lblSelectedRaw";
            this.lblSelectedRaw.Size = new System.Drawing.Size(260, 16);
            this.lblSelectedRaw.TabIndex = 18;
            this.lblSelectedRaw.Text = "Raw Ingredients in Selected Prepped Item:";
            // 
            // lblRaw
            // 
            this.lblRaw.AutoSize = true;
            this.lblRaw.Location = new System.Drawing.Point(520, 463);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(260, 16);
            this.lblRaw.TabIndex = 19;
            this.lblRaw.Text = "Raw Ingredients in Selected Prepped Item:";
            // 
            // ChezSouSadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 692);
            this.Controls.Add(this.lblRaw);
            this.Controls.Add(this.lblSelectedRaw);
            this.Controls.Add(this.lblPreppedItems);
            this.Controls.Add(this.lblSelectedPreppedItem);
            this.Controls.Add(this.txtAddRaw);
            this.Controls.Add(this.btnAddRaw);
            this.Controls.Add(this.btnDeselectRaw);
            this.Controls.Add(this.btnSelectRaw);
            this.Controls.Add(this.lstRaw);
            this.Controls.Add(this.lstSelectedRaw);
            this.Controls.Add(this.txtAddPrepped);
            this.Controls.Add(this.btnAddPrepped);
            this.Controls.Add(this.txtAddDish);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.btnDeslectDish);
            this.Controls.Add(this.btnSelectDish);
            this.Controls.Add(this.lstPreppedItems);
            this.Controls.Add(this.lstSelectedPreppedItems);
            this.Controls.Add(this.lstDishes);
            this.Controls.Add(this.lblListDishes);
            this.Name = "ChezSouSadForm";
            this.Text = "ChezSouSadForm";
            this.Load += new System.EventHandler(this.ChezSouSadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListDishes;
        private System.Windows.Forms.ListView lstDishes;
        private System.Windows.Forms.ListView lstSelectedPreppedItems;
        private System.Windows.Forms.ListView lstPreppedItems;
        private System.Windows.Forms.Button btnSelectDish;
        private System.Windows.Forms.Button btnDeslectDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TextBox txtAddDish;
        private System.Windows.Forms.TextBox txtAddPrepped;
        private System.Windows.Forms.Button btnAddPrepped;
        private System.Windows.Forms.TextBox txtAddRaw;
        private System.Windows.Forms.Button btnAddRaw;
        private System.Windows.Forms.Button btnDeselectRaw;
        private System.Windows.Forms.Button btnSelectRaw;
        private System.Windows.Forms.ListView lstRaw;
        private System.Windows.Forms.ListView lstSelectedRaw;
        private System.Windows.Forms.Label lblSelectedPreppedItem;
        private System.Windows.Forms.Label lblPreppedItems;
        private System.Windows.Forms.Label lblSelectedRaw;
        private System.Windows.Forms.Label lblRaw;
    }
}