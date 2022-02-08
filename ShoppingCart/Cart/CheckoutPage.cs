using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cart
{
    public partial class CheckoutPage : Form
    {
        DataTable mydt = new DataTable();
        SqlConnection myconn;

        public CheckoutPage(double total)
        {
            InitializeComponent();
            ttllbl.Text = total.ToString();
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fNametxbx.Text == ""
                || lNametxbx.Text == ""
                || citytxbx.Text == ""
                || addresstxbx.Text == ""
                || statecbox.SelectedItem == null
                || zipcodetxbx.Text == ""
                || emailtxbx.Text == ""
                || cardcomboBox1.SelectedItem == null         
                )
            {
                MessageBox.Show("Please introduce the correct information!");
            }
            else
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=data4708;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                myconn.Open();
                SqlCommand insertcomand = new SqlCommand("Insert into  Checkout (name, lastname, address, city, state, zipcode, email, card, total) Values (@name, @lastname, @address, @city, @state, @zipcode, @email, @card, @total);", myconn);



                insertcomand.Parameters.Add("@name", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@name"].Value = fNametxbx.Text;

                insertcomand.Parameters.Add("@lastname", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@lastname"].Value = lNametxbx.Text;

                insertcomand.Parameters.Add("@address", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@address"].Value = addresstxbx.Text;

                insertcomand.Parameters.Add("@city", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@city"].Value = citytxbx.Text;

                insertcomand.Parameters.Add("@state", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@state"].Value = statecbox.SelectedItem.ToString();

                insertcomand.Parameters.Add("@zipcode", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@zipcode"].Value = zipcodetxbx.Text;

                insertcomand.Parameters.Add("@email", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@email"].Value = emailtxbx.Text;

                insertcomand.Parameters.Add("@card", SqlDbType.VarChar, 50);
                insertcomand.Parameters["@card"].Value = cardcomboBox1.SelectedItem.ToString();

                insertcomand.Parameters.Add("@total", SqlDbType.Float, 50);
                insertcomand.Parameters["@total"].Value = ttllbl.Text;

                insertcomand.ExecuteNonQuery();

                SqlCommand delcommand = new SqlCommand("Delete From Cart", myconn);
                delcommand.ExecuteNonQuery();
                String message = "-------------------------------------------\n" +
                                   "Thank you for your purchase!\n" +
                                   "_____________________________________________\n" +
                                  "Name: " + fNametxbx.Text + " " + lNametxbx.Text + "\n" +
                                 "Address: " + addresstxbx.Text + "\n" +
                                 "City: " + citytxbx.Text + "\n" +
                                 "State: " + statecbox.SelectedItem.ToString() + "\t Zip Code: " + zipcodetxbx.Text + "\n" +
                                 "Email: " + emailtxbx.Text + "\n" +
                                 "Payed with card: " + cardcomboBox1.SelectedItem.ToString() + "\n" +
                                 "_____________________________________________\n" +
                                 "Total: " + ttllbl.Text + "\n" +
                                 "-------------------------------------------";
                MessageBox.Show(message);
                this.Close();
                
            }
        }
    }
}
