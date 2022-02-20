
namespace lab1
{
    partial class Dish
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnUnitsDelete = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.checkBoxProducts = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(438, 184);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(116, 38);
            this.btnAbout.TabIndex = 26;
            this.btnAbout.Text = "Подробнее...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnUnitsDelete
            // 
            this.btnUnitsDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnUnitsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitsDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnUnitsDelete.Location = new System.Drawing.Point(273, 184);
            this.btnUnitsDelete.Name = "btnUnitsDelete";
            this.btnUnitsDelete.Size = new System.Drawing.Size(111, 38);
            this.btnUnitsDelete.TabIndex = 22;
            this.btnUnitsDelete.Text = "Удалить";
            this.btnUnitsDelete.UseVisualStyleBackColor = false;
            this.btnUnitsDelete.Click += new System.EventHandler(this.deleteDish_Click);
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.BackColor = System.Drawing.Color.Coral;
            this.btnUnitUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitUpdate.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUnitUpdate.Location = new System.Drawing.Point(142, 184);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUnitUpdate.TabIndex = 23;
            this.btnUnitUpdate.Text = "Изменить";
            this.btnUnitUpdate.UseVisualStyleBackColor = false;
            this.btnUnitUpdate.Click += new System.EventHandler(this.changeDish_Click);
            // 
            // btnUnitSend
            // 
            this.btnUnitSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUnitSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitSend.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUnitSend.Location = new System.Drawing.Point(12, 184);
            this.btnUnitSend.Name = "btnUnitSend";
            this.btnUnitSend.Size = new System.Drawing.Size(111, 38);
            this.btnUnitSend.TabIndex = 24;
            this.btnUnitSend.Text = "Далее";
            this.btnUnitSend.UseVisualStyleBackColor = false;
            this.btnUnitSend.Click += new System.EventHandler(this.addDish_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(437, 48);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(90, 27);
            this.textBoxPrice.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(19, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 27);
            this.textBoxName.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 195);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickRowEvent);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoubleClickRowEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(170, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ед.изм";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(174, 51);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(102, 24);
            this.comboBoxUnits.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Тип";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(308, 51);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(102, 24);
            this.comboBoxTypes.TabIndex = 25;
            // 
            // checkBoxProducts
            // 
            this.checkBoxProducts.CheckOnClick = true;
            this.checkBoxProducts.FormattingEnabled = true;
            this.checkBoxProducts.Location = new System.Drawing.Point(576, 12);
            this.checkBoxProducts.Name = "checkBoxProducts";
            this.checkBoxProducts.Size = new System.Drawing.Size(170, 174);
            this.checkBoxProducts.TabIndex = 27;
            // 
            // Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxProducts);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.comboBoxUnits);
            this.Controls.Add(this.btnUnitsDelete);
            this.Controls.Add(this.btnUnitUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUnitSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dish";
            this.Text = "Dish";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnUnitsDelete;
        private System.Windows.Forms.Button btnUnitUpdate;
        private System.Windows.Forms.Button btnUnitSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.CheckedListBox checkBoxProducts;
    }
}