using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using WindowsFormsApp1.Dtos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server = LAPTOP-F051SPJ3\\SQLEXPRESS; initial Catalog = EgitimKampi501Db; integrated security = true ");
        


        

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "Insert into TblProduct (ProductName, ProductStock, ProductPrice, ProductCategory) values (@productName, @productStock, @productPrice, @productCategory)";
                var parameters = new DynamicParameters();

            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCategory", txtCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Yeni kitap ekleme işlemi başarılı!");


        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            string query = "Delete From TblProduct Where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap silme işlemi başarılı!");

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update TblProduct set ProductName=@productName, ProductPrice=@productPrice, ProductStock=@productStock, ProductCategory=@productCategory where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productCategory", txtCategory.Text);
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap güncelleme işlemi başarılı!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //private async void Form1_Load(object sender, EventArgs e)
        //{
        //    string query1 = "Select Count(*) From TblProduct";
        //    var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
        //    lblProductCount.Text = productTotalCount.ToString();
        //}

        private  void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            string query1 = "Select Count(*) From TblProduct";
             var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
                lblProductCount.Text = productTotalCount.ToString();

            string query2 = "Select ProductName From TblProduct Where ProductPrice=(Select Max(ProductPrice) From TblProduct)";
            var productMaxCount = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPricedProduct.Text = productMaxCount.ToString();

            string query3 = "Select Count(Distinct(ProductCategory)) From TblProduct";
            var categoryCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblCategoryCount.Text = categoryCount.ToString();

        }
    }
}

