using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GalaryFarida
{

    public partial class AdminForm : Form
        
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        const string sqlconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\GalaryFarida.mdf;Integrated Security=True;Connect Timeout=30";
        Class1 cls = new Class1();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\GalaryFarida.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddProductTab_Click(object sender, EventArgs e)
        {
            //PopulateProduct();
            ProductDataGrid.DataSource = cls.dsreturn("Product", sqlconn).Tables[0];
        }

        private void SuppliersTab_Click(object sender, EventArgs e)
        {
            //PopulateSupplier();
            SupplierDataGrid.DataSource = cls.dsreturn("Supplier", sqlconn).Tables[0];
        }

        private void UnavailableTab_Click(object sender, EventArgs e)
        {
            cls.Insert2("Unavailable", "Catid,UnavilableName,BuyPrice", "Product", "Catid,ProdName,BuyPrice", "ProdQuantity=0", sqlconn);
            UnavailableDataGrid.DataSource = cls.dsreturn("Unavailable", sqlconn).Tables[0];
        }
        private void CategoryTab_Click(object sender, EventArgs e)
        {
           CategoryDataGrid.DataSource = cls.dsreturn("Category", sqlconn).Tables[0];
        }

        private void BillIdLable_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.Insert("Product", "ProdName,ProdQuantity,CatId,SuppId,BuyPrice,SellPrice", "('" + ProductNameTextBox.Text + "'," + ProductQuantityTextBox.Text + "," + CategoryTextBox.Text + "," + SupplierIdTextBox.Text + "," + BuyPriceTextBox.Text + "," + SellPriceTextBox.Text + ")", sqlconn);
                ProductDataGrid.DataSource = cls.dsreturn("Product", sqlconn).Tables[0];
                /*con.Open();
                String query = "insert into Product(ProdName,ProdQuantity,CatId,SuppId,BuyPrice,SellPrice) values('" +ProductNameTextBox.Text+ "'," + ProductQuantityTextBox.Text + "," + CategoryTextBox.Text + "," + SupplierIdTextBox.Text + "," + BuyPriceTextBox.Text + "," + SellPriceTextBox.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت الاضافة بنجاح");
                con.Close();
                PopulateProduct();*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.delete("Product", "ProdId", ProductIdTextBox.Text, sqlconn);
                ProductDataGrid.DataSource = cls.dsreturn("Product", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIdTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantityTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            CategoryTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            SupplierIdTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            BuyPriceTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            SellPriceTextBox.Text = ProductDataGrid.SelectedRows[0].Cells[6].Value.ToString();
        }

       
        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.update("Product", "ProdName='" + ProductNameTextBox.Text + "',ProdQuantity=" + ProductQuantityTextBox.Text + ",CatId=" + CategoryTextBox.Text + ",SuppId=" + SupplierIdTextBox.Text + ",BuyPrice=" + BuyPriceTextBox.Text + ",SellPrice=" + SellPriceTextBox.Text + "", ProductIdTextBox.Text, "ProdId", sqlconn);
                ProductDataGrid.DataSource = cls.dsreturn("Product", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.Insert("Supplier", "SuppName,SuppAddres,SuppPhone,Crediator,Debit", "('" + SupplierNameTextBox.Text + "','" + SupplierAddTextBox.Text + "','" + SupplierPhoneTextBox.Text + "'," + CreditorTextBox.Text + "," + DebitTextBox.Text + ")", sqlconn);
                SupplierDataGrid.DataSource = cls.dsreturn("Supplier", sqlconn).Tables[0];
                /*con.Open();
                String query = "insert into Supplier(SuppName,SuppAddres,SuppPhone,Crediator,Debit) values('" + SupplierNameTextBox.Text + "','" + SupplierAddTextBox.Text + "','" + SupplierPhoneTextBox.Text + "'," + CreditorTextBox.Text + "," + DebitTextBox.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت الاضافة بنجاح");
                con.Close();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                //cls.delete("Supplier", "SuppId", SupplierIdTextBox1.Text, sqlconn);
                cls.delete("Supplier", "SuppId", SupplierIdTextBox1.Text, sqlconn);
                SupplierDataGrid.DataSource = cls.dsreturn("Supplier", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* private void PopulateProduct()
         {
             con.Open();
             string query = "select * from Product";
             SqlDataAdapter sda = new SqlDataAdapter(query, con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             ProductDataGrid.DataSource = ds.Tables[0];

             con.Close();
         }

         private void PopulateSupplier()
         {
             con.Open();
             string query = "select * from Supplier";
             SqlDataAdapter sda = new SqlDataAdapter(query, con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             SupplierDataGrid.DataSource = ds.Tables[0];

             con.Close();
         }*/

        private void SupplierDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierIdTextBox1.Text = SupplierDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            SupplierNameTextBox.Text = SupplierDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            SupplierAddTextBox.Text = SupplierDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            SupplierPhoneTextBox.Text = SupplierDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            CreditorTextBox.Text = SupplierDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            DebitTextBox.Text = SupplierDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.Insert("Category", "CatName", "('" + CategoryNameTextBox.Text + "' )", sqlconn);
                CategoryDataGrid.DataSource = cls.dsreturn("Category", sqlconn).Tables[0];
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryIdTextBox.Text = CategoryDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            CategoryNameTextBox.Text = CategoryDataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void UnavilableDateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnavailableIdTextBox.Text = UnavailableDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void UnavilableButton_Click(object sender, EventArgs e)
        {
            cls.Insert2("Unavailable", "Catid,UnavilableName,BuyPrice", "Product", "Catid,ProdName,BuyPrice", "ProdQuantity=0", sqlconn);
            cls.delete("Product", "ProdQuantity", "0" , sqlconn);
            UnavailableDataGrid.DataSource = cls.dsreturn("Unavailable", sqlconn).Tables[0];
        }

        private void AdminTabs_Selected(object sender, TabControlEventArgs e)
        {
            ProductDataGrid.DataSource = cls.dsreturn("Product", sqlconn).Tables[0];
            SupplierDataGrid.DataSource = cls.dsreturn("Supplier", sqlconn).Tables[0];
            //cls.Insert2("Unavailable", "Catid,UnavilableName,BuyPrice", "Product", "Catid,ProdName,BuyPrice", "ProdQuantity=0", sqlconn);
            UnavailableDataGrid.DataSource = cls.dsreturn("Unavailable", sqlconn).Tables[0];
            CategoryDataGrid.DataSource = cls.dsreturn("Category", sqlconn).Tables[0];



        }

        private void UpdateSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.update("Supplier", "SuppName='" + SupplierNameTextBox.Text + "',SuppAddres='" + SupplierAddTextBox.Text + "',SuppPhone='" + SupplierPhoneTextBox.Text + "',Crediator=" + CreditorTextBox.Text + ",Debit=" + DebitTextBox.Text + "",SupplierIdTextBox1.Text, "SuppId", sqlconn);
                SupplierDataGrid.DataSource = cls.dsreturn("Supplier", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.update("Category", "CatName='" + CategoryNameTextBox.Text + "'", CategoryIdTextBox.Text, "CatId", sqlconn);
                CategoryDataGrid.DataSource = cls.dsreturn("Category", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.delete("Category", "CatId", CategoryIdTextBox.Text, sqlconn);
                CategoryDataGrid.DataSource = cls.dsreturn("Category", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void UnavailableDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                cls.delete("Unavailable", "Id", UnavailableIdTextBox.Text, sqlconn);
                UnavailableDataGrid.DataSource = cls.dsreturn("Unavailable", sqlconn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
        /* private void AdminForm_Load(object sender ,EventArgs e )
{
Populate();
}*/
    
}
