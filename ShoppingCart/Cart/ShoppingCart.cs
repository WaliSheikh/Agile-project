using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cart
{
    public partial class ShoppingCart : Form
    {
        DataTable mydt = new DataTable();
        SqlConnection myconn;

        public ShoppingCart()
        {
            InitializeComponent();
        }

        double  finaltotal=0;
        double grandtotal = 0;
        int i = 1;
        double tax = 0.0887;
        double totaltaxes = 0;
        
        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            myconn.Open();
            SqlCommand mycommand = new SqlCommand();  
            mycommand.CommandText = "Select * From Cart";
            mycommand.Connection = myconn;
            SqlDataAdapter myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycommand;    
            myadapter.Fill(mydt);
            mydt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            
            foreach(DataRow drow in mydt.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["image"].ToString());

                double ttl = double.Parse(drow["price"].ToString());
                double itms = double.Parse(drow["quantity"].ToString());
                double tt = ttl * itms;
                grandtotal += tt;
                
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mydt;
            label1.Text = "";
            totaltaxes = Math.Round(grandtotal * tax,2);
            taxlbl.Text = "Tax(8.87%): $ "+ totaltaxes.ToString();
            finaltotal =Math.Round (grandtotal + totaltaxes,2);
            label1.Text = "Your Total is $ " + finaltotal.ToString();

            //increase button 
            DataGridViewButtonColumn increase = new DataGridViewButtonColumn();
            increase.FlatStyle = FlatStyle.Standard;

            increase.HeaderText = "Increase";
            increase.Name = "Increase";
            increase.Text = "+";
            increase.UseColumnTextForButtonValue = true;

            increase.Width = 20;
            if (dataGridView1.Columns.Contains(increase.Name = "Increase"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(increase);
            }

            //decrease button 
            DataGridViewButtonColumn decrease = new DataGridViewButtonColumn();
            decrease.FlatStyle = FlatStyle.Standard;

            decrease.HeaderText = "Decrease";
            decrease.Name = "Decrease";
            decrease.Text = "-";
            decrease.UseColumnTextForButtonValue = true;

            decrease.Width = 20;
            if (dataGridView1.Columns.Contains(decrease.Name = "Decrease"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(decrease);
            }



            //delete button
            DataGridViewButtonColumn deletebtn = new DataGridViewButtonColumn();
            deletebtn.FlatStyle = FlatStyle.Popup;
            deletebtn.HeaderText = "Delete";
            deletebtn.Name = "Delete";
            deletebtn.Text = "X";

            
            deletebtn.UseColumnTextForButtonValue = true;

            deletebtn.Width = 20;
            
           
            if (dataGridView1.Columns.Contains(deletebtn.Name = "Delete"))
            {

            }
            else
            {
                dataGridView1.Columns.Add(deletebtn);
            }
            
            myconn.Close();
            


        }

        long id;
        int increment = 1;
        long value;
        string a;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                myconn.Open();
                id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                value = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                value = value + increment;
                
                double r = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                grandtotal += r;

                totaltaxes = Math.Round(grandtotal * tax,2);
                taxlbl.Text = "";
                taxlbl.Text = "Tax(8.87%): $ " + totaltaxes.ToString();
                finaltotal = Math.Round(grandtotal + totaltaxes,2);
                label1.Text = "";
                label1.Text = "Your Total is $ " + finaltotal.ToString();

                SqlCommand updatecommand = new SqlCommand("Update Cart SET quantity='" + value + "' where id=" + id, myconn);
                updatecommand.ExecuteNonQuery();
                RefreshDT();
                myconn.Close();

            }else if (e.ColumnIndex == 6) 
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                myconn.Open();
                id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                value = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                value = value - increment;
                double r = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (value != 0)
                {
                    grandtotal -= r;

                    totaltaxes = Math.Round(grandtotal * tax,2);
                    taxlbl.Text = "";
                    taxlbl.Text = "Tax(8.87%): $ " + totaltaxes.ToString();
                    finaltotal = Math.Round(grandtotal + totaltaxes,2);
                    label1.Text = "";
                    label1.Text = "Your Total is $ " + finaltotal.ToString();

                    SqlCommand updatecommand = new SqlCommand("Update Cart SET quantity='" + value + "' where id=" + id, myconn);
                    updatecommand.ExecuteNonQuery();
                    RefreshDT();

                    


                    myconn.Close();
                }else
                {
                    MessageBox.Show("Minimun Amount Reached");
                }
                
            }
            else if(e.ColumnIndex == 7)
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                myconn.Open();
                id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                value = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                
                double r = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                DialogResult result = MessageBox.Show("Do you want to delete this item?", "Warning",MessageBoxButtons.YesNo);
                if(result  == DialogResult.Yes)
                {

                    
                    SqlCommand delcommand = new SqlCommand("Delete From Cart where id="+id,myconn);                                   
                    delcommand.ExecuteNonQuery();
                    r = r * value;
                    grandtotal -= r;

                    totaltaxes = Math.Round(grandtotal * tax,2);
                    taxlbl.Text = "";
                    taxlbl.Text = "Tax(8.87%): $ " + totaltaxes.ToString();
                    finaltotal = Math.Round(grandtotal + totaltaxes, 2);
                    label1.Text = "";
                    label1.Text = "Your Total is $ " + finaltotal.ToString();

                    RefreshDT();
    
                    
                    
                }
                else if(result == DialogResult.No)
                {
                    return;
                }
                myconn.Close();
            }
        }
        private void RefreshDT()
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            myconn.Open();
            SqlCommand mycommand = new SqlCommand();
            mycommand.CommandText = "Select * From Cart";
            mycommand.Connection = myconn;
            SqlDataAdapter myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycommand;
            mydt = new DataTable();
            myadapter.Fill(mydt);
            mydt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in mydt.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["image"].ToString());
                
            }
            dataGridView1.AutoGenerateColumns = false;
            
            dataGridView1.DataSource = mydt;
           
            myconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            myconn.Open();
            SqlCommand delcommand = new SqlCommand("Delete From Cart", myconn);
            delcommand.ExecuteNonQuery();
            RefreshDT();
            grandtotal = 0;
            totaltaxes = 0;
            taxlbl.Text = "Tax(8.87%): $ 0";
            label1.Text = "Your Total is $ "+ grandtotal.ToString();
             myconn.Close();
           
                MessageBox.Show("Cart Cleared");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (finaltotal == 0)
            {
                MessageBox.Show("Please add items to you cart first!");
            }
            else
            {
                CheckoutPage frm = new CheckoutPage(finaltotal);
                frm.ShowDialog();
                this.Close();
            }
        }

   

    }
}
