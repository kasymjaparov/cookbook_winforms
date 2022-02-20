
namespace lab1
{
    partial class DishType
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnUnitsDelete = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitSend = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(15, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(648, 97);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(116, 40);
            this.btnAbout.TabIndex = 19;
            this.btnAbout.Text = "Подробнее...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.moreInfoBtn_Click);
            // 
            // btnUnitsDelete
            // 
            this.btnUnitsDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnUnitsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitsDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnUnitsDelete.Location = new System.Drawing.Point(275, 97);
            this.btnUnitsDelete.Name = "btnUnitsDelete";
            this.btnUnitsDelete.Size = new System.Drawing.Size(111, 38);
            this.btnUnitsDelete.TabIndex = 16;
            this.btnUnitsDelete.Text = "Удалить";
            this.btnUnitsDelete.UseVisualStyleBackColor = false;
            this.btnUnitsDelete.Click += new System.EventHandler(this.btnUnitsDelete_Click);
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.BackColor = System.Drawing.Color.Coral;
            this.btnUnitUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitUpdate.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUnitUpdate.Location = new System.Drawing.Point(144, 97);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUnitUpdate.TabIndex = 17;
            this.btnUnitUpdate.Text = "Изменить";
            this.btnUnitUpdate.UseVisualStyleBackColor = false;
            this.btnUnitUpdate.Click += new System.EventHandler(this.btnUnitUpdate_Click);
            // 
            // btnUnitSend
            // 
            this.btnUnitSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUnitSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitSend.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUnitSend.Location = new System.Drawing.Point(14, 97);
            this.btnUnitSend.Name = "btnUnitSend";
            this.btnUnitSend.Size = new System.Drawing.Size(111, 38);
            this.btnUnitSend.TabIndex = 18;
            this.btnUnitSend.Text = "Добавить";
            this.btnUnitSend.UseVisualStyleBackColor = false;
            this.btnUnitSend.Click += new System.EventHandler(this.addBtnClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 286);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellBtn_Click);
            // 
            // DishType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnUnitsDelete);
            this.Controls.Add(this.btnUnitUpdate);
            this.Controls.Add(this.btnUnitSend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Name = "DishType";
            this.Text = "DishType";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnUnitsDelete;
        private System.Windows.Forms.Button btnUnitUpdate;
        private System.Windows.Forms.Button btnUnitSend;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}