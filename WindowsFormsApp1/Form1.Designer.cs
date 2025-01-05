namespace WindowsFormsApp1
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.lblMaxPricedProduct = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(81, 204);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(256, 47);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(81, 310);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(256, 47);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(81, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 47);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Id:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(98, 46);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(224, 22);
            this.txtProductId.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(98, 74);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 22);
            this.txtProductName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(98, 102);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(224, 22);
            this.txtProductPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fiyat:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(98, 130);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(224, 22);
            this.txtProductStock.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stok:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(98, 158);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(224, 22);
            this.txtCategory.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kategori:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 363);
            this.dataGridView1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toplam Kitap Sayısı:";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(375, 464);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(28, 24);
            this.lblProductCount.TabIndex = 16;
            this.lblProductCount.Text = "...";
            // 
            // lblMaxPricedProduct
            // 
            this.lblMaxPricedProduct.AutoSize = true;
            this.lblMaxPricedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPricedProduct.Location = new System.Drawing.Point(375, 503);
            this.lblMaxPricedProduct.Name = "lblMaxPricedProduct";
            this.lblMaxPricedProduct.Size = new System.Drawing.Size(28, 24);
            this.lblMaxPricedProduct.TabIndex = 18;
            this.lblMaxPricedProduct.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(76, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "En Pahalı Kitap:";
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(375, 543);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(28, 24);
            this.lblCategoryCount.TabIndex = 20;
            this.lblCategoryCount.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(76, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kategori Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1246, 607);
            this.Controls.Add(this.lblCategoryCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMaxPricedProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label lblMaxPricedProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label label9;
    }
}

