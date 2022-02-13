
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.checkBoxProducts = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnUnitsDelete = new System.Windows.Forms.Button();
            this.btnUnitSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxId.Location = new System.Drawing.Point(12, 45);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(53, 27);
            this.textBoxId.TabIndex = 22;
            // 
            // checkBoxProducts
            // 
            this.checkBoxProducts.CheckOnClick = true;
            this.checkBoxProducts.FormattingEnabled = true;
            this.checkBoxProducts.Location = new System.Drawing.Point(618, 12);
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
            this.btnAbout.Location = new System.Drawing.Point(292, 188);
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
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnUnitsDelete);
            this.Controls.Add(this.btnUnitSend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckedListBox checkBoxProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnUnitsDelete;
        private System.Windows.Forms.Button btnUnitSend;
    }
}