
namespace lab1
{
    partial class Orders
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
            this.checkBoxProducts = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnUnitsDelete = new System.Windows.Forms.Button();
            this.btnUnitSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxProducts
            // 
            this.checkBoxProducts.CheckOnClick = true;
            this.checkBoxProducts.FormattingEnabled = true;
            this.checkBoxProducts.Location = new System.Drawing.Point(13, 8);
            this.checkBoxProducts.Name = "checkBoxProducts";
            this.checkBoxProducts.Size = new System.Drawing.Size(170, 174);
            this.checkBoxProducts.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 195);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_click);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_doubleClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(427, 188);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(116, 38);
            this.btnAbout.TabIndex = 33;
            this.btnAbout.Text = "Подробнее...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.desc_Click);
            // 
            // btnUnitsDelete
            // 
            this.btnUnitsDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnUnitsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitsDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnUnitsDelete.Location = new System.Drawing.Point(152, 188);
            this.btnUnitsDelete.Name = "btnUnitsDelete";
            this.btnUnitsDelete.Size = new System.Drawing.Size(111, 38);
            this.btnUnitsDelete.TabIndex = 30;
            this.btnUnitsDelete.Text = "Удалить";
            this.btnUnitsDelete.UseVisualStyleBackColor = false;
            this.btnUnitsDelete.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // btnUnitSend
            // 
            this.btnUnitSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUnitSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitSend.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUnitSend.Location = new System.Drawing.Point(13, 188);
            this.btnUnitSend.Name = "btnUnitSend";
            this.btnUnitSend.Size = new System.Drawing.Size(111, 38);
            this.btnUnitSend.TabIndex = 32;
            this.btnUnitSend.Text = "Добавить";
            this.btnUnitSend.UseVisualStyleBackColor = false;
            this.btnUnitSend.Click += new System.EventHandler(this.addBtn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(278, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUnitsDelete);
            this.Controls.Add(this.btnUnitSend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxProducts);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkBoxProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnUnitsDelete;
        private System.Windows.Forms.Button btnUnitSend;
        private System.Windows.Forms.Button button1;
    }
}