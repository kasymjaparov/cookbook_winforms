
namespace lab1
{
    partial class Recipe
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
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.dishPriceLabel = new System.Windows.Forms.Label();
            this.dishTypeLabel = new System.Windows.Forms.Label();
            this.dishUnitName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameLabel.Location = new System.Drawing.Point(8, 9);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(137, 19);
            this.dishNameLabel.TabIndex = 0;
            this.dishNameLabel.Text = "Название блюда";
            // 
            // dishPriceLabel
            // 
            this.dishPriceLabel.AutoSize = true;
            this.dishPriceLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPriceLabel.Location = new System.Drawing.Point(8, 35);
            this.dishPriceLabel.Name = "dishPriceLabel";
            this.dishPriceLabel.Size = new System.Drawing.Size(104, 19);
            this.dishPriceLabel.TabIndex = 0;
            this.dishPriceLabel.Text = "Цена блюда";
            // 
            // dishTypeLabel
            // 
            this.dishTypeLabel.AutoSize = true;
            this.dishTypeLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishTypeLabel.Location = new System.Drawing.Point(8, 64);
            this.dishTypeLabel.Name = "dishTypeLabel";
            this.dishTypeLabel.Size = new System.Drawing.Size(90, 19);
            this.dishTypeLabel.TabIndex = 0;
            this.dishTypeLabel.Text = "Тип блюда";
            // 
            // dishUnitName
            // 
            this.dishUnitName.AutoSize = true;
            this.dishUnitName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishUnitName.Location = new System.Drawing.Point(8, 90);
            this.dishUnitName.Name = "dishUnitName";
            this.dishUnitName.Size = new System.Drawing.Size(68, 19);
            this.dishUnitName.TabIndex = 0;
            this.dishUnitName.Text = "Ед.изм.";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(312, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 371);
            this.panel1.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(12, 400);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 38);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Отправить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dishUnitName);
            this.Controls.Add(this.dishTypeLabel);
            this.Controls.Add(this.dishPriceLabel);
            this.Controls.Add(this.dishNameLabel);
            this.Name = "Recipe";
            this.Text = "Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.Label dishPriceLabel;
        private System.Windows.Forms.Label dishTypeLabel;
        private System.Windows.Forms.Label dishUnitName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
    }
}