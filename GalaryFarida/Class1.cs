using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace GalaryFarida
{
    class Class1
    {

        public void Insert(string t, string c, string values,string connstring)
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            String query = "insert into " + t + "(" + c + ") values" + values;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الاضافة بنجاح");
            con.Close();
        }
        public DataSet dsreturn(string t,string connstring)
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "select * from "+t;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            return ds;
            con.Close();
        }
        public void Insert2(string t, string c,string st,string sc,string scon, string connstring)
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            String query = "insert into " + t + "(" + c + ") select " + sc + " from " + st + " where " + scon;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الاضافة بنجاح");
            con.Close();
        }
        public void delete(string t,string ConditionCol ,string id, string connstring)
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            String query = "delete from " + t + " where " + ConditionCol + " = " + id  ;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم الحذف بنجاح");
            con.Close();
        }
        public void update(string t, string set, string id, string ConditionCol, string connstring)
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            String query = "update " + t +" set " +set +" where " + ConditionCol + " = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم التعديل بنجاح");
            con.Close();
            //Product", "ProdName='" + ProductNameTextBox.Text + "',ProdQuantity=" + ProductQuantityTextBox.Text + ",CatId=" + CategoryTextBox.Text + ",SuppId=" + SupplierIdTextBox.Text + ",BuyPrice=" + BuyPriceTextBox.Text + ",SellPrice=" + SellPriceTextBox.Text + ""
        }
    }
}
