using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace bms_01
{
    public partial class billing : UserControl
    {
        public billing()
        {
            InitializeComponent();
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into ADD_ITEM_TBL values (@item, @price , @quantity, @total)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@item", cmb_items.SelectedItem);
            cmd.Parameters.AddWithValue("@price", txt_price.Text);
            cmd.Parameters.AddWithValue("@quantity", txt_qty.Text);
            cmd.Parameters.AddWithValue("@total", txt_total.Text);

            con.Open();

            cmd.ExecuteNonQuery(); //for insertion,deletion,updation 

            con.Close();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for cakes
            if (cmb_items.SelectedItem.ToString() == "Caramel Crunch Cake")
            { txt_price.Text = "500"; }
            else if (cmb_items.SelectedItem.ToString() == "Chocolate heaven")
            { txt_price.Text = "1000"; }
            else if (cmb_items.SelectedItem.ToString() == "Kitkat Cake")
            { txt_price.Text = "1500"; }
            else if (cmb_items.SelectedItem.ToString() == "rafaello Cake")
            { txt_price.Text = "2000"; }
            //for savory
            else if (cmb_items.SelectedItem.ToString() == "Aaloo Samosa")
            { txt_price.Text = "50"; }
            else if (cmb_items.SelectedItem.ToString() == "Chicken D Samosa")
            { txt_price.Text = "60"; }
            else if (cmb_items.SelectedItem.ToString() == "Chicken Stick")
            { txt_price.Text = "70"; }
            else if (cmb_items.SelectedItem.ToString() == "Qeema Samosa")
            { txt_price.Text = "100"; }
            //for brownies
            else if (cmb_items.SelectedItem.ToString() == "Belgiun Brownie")
            { txt_price.Text = "100"; }
            else if (cmb_items.SelectedItem.ToString() == "Mars Chocolate Brownie")
            { txt_price.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "Nutella Brownie")
            { txt_price.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "Peanut Butter stack Brownie")
            { txt_price.Text = "250"; }
            //for sweats
            else if (cmb_items.SelectedItem.ToString() == "Barfi")
            { txt_price.Text = "100"; }
            else if (cmb_items.SelectedItem.ToString() == "Gulaab Jamun")
            { txt_price.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "Chum Chum")
            { txt_price.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "Rasgulla")
            { txt_price.Text = "250"; }
            //for cupcake
            else if (cmb_items.SelectedItem.ToString() == "Cofee Cupcake")
            { txt_price.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "Plain Chocolate Cupcake")
            { txt_price.Text = "250"; }
            else if (cmb_items.SelectedItem.ToString() == "Red Velvet Cupcake")
            { txt_price.Text = "300"; }
            else if (cmb_items.SelectedItem.ToString() == "Swiss dark Choco cupcake")
            { txt_price.Text = "350"; }
            //for cookies
            else if (cmb_items.SelectedItem.ToString() == "Choco and Walnut Biscuits")
            { txt_price.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "Chocolate Crisp Biscuits")
            { txt_price.Text = "250"; }
            else if (cmb_items.SelectedItem.ToString() == "Chocolate Dot Biscuits")
            { txt_price.Text = "300"; }
            else if (cmb_items.SelectedItem.ToString() == "Marble Biscuits")
            { txt_price.Text = "350"; }
            else
            { txt_price.Text = "0"; }


            txt_total.Text = "";
            txt_qty.Text = "";
        }

        private void rd_cookies_CheckedChanged(object sender, EventArgs e)
        {
            rd_cake.ForeColor = Color.Red;
            rd_savory.ForeColor = Color.Red;
            rd_brownies.ForeColor = Color.Red;
            rd_sweats.ForeColor = Color.Red;
            rd_cupcakes.ForeColor = Color.Red;
            rd_cookies.ForeColor = Color.Green;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Choco and Walnut Biscuits");
            cmb_items.Items.Add("Chocolate Crisp Biscuits");
            cmb_items.Items.Add("Chocolate Dot Biscuits");
            cmb_items.Items.Add("Marble Biscuits");
        }

        private void rd_cake_CheckedChanged(object sender, EventArgs e)
        {
            rd_cake.ForeColor = Color.Green;
            rd_savory.ForeColor = Color.Red;
            rd_brownies.ForeColor = Color.Red;
            rd_sweats.ForeColor = Color.Red;
            rd_cupcakes.ForeColor = Color.Red;
            rd_cookies.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Caramel Crunch Cake");
            cmb_items.Items.Add("Chocolate heaven");
            cmb_items.Items.Add("Kitkat Cake");
            cmb_items.Items.Add("rafaello Cake");
        }

        private void rd_brownies_CheckedChanged(object sender, EventArgs e)
        {
            rd_cake.ForeColor = Color.Red;
            rd_savory.ForeColor = Color.Red;
            rd_brownies.ForeColor = Color.Green;
            rd_sweats.ForeColor = Color.Red;
            rd_cupcakes.ForeColor = Color.Red;
            rd_cookies.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Belgiun Brownie");
            cmb_items.Items.Add("Mars Chocolate Brownie");
            cmb_items.Items.Add("Nutella Brownie");
            cmb_items.Items.Add("Peanut Butter stack Brownie");
        }

        private void rd_cupcakes_CheckedChanged(object sender, EventArgs e)
        {
            rd_cake.ForeColor = Color.Red;
            rd_savory.ForeColor = Color.Red;
            rd_brownies.ForeColor = Color.Red;
            rd_sweats.ForeColor = Color.Red;
            rd_cupcakes.ForeColor = Color.Green;
            rd_cookies.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Cofee Cupcake");
            cmb_items.Items.Add("Plain Chocolate Cupcake");
            cmb_items.Items.Add("Red Velvet Cupcake");
            cmb_items.Items.Add("Swiss dark Choco cupcake");
        }

        private void rd_savory_CheckedChanged(object sender, EventArgs e)
        {
            rd_cake.ForeColor = Color.Red;
            rd_savory.ForeColor = Color.Green;
            rd_brownies.ForeColor = Color.Red;
            rd_sweats.ForeColor = Color.Red;
            rd_cupcakes.ForeColor = Color.Red;
            rd_cookies.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Aaloo Samosa");
            cmb_items.Items.Add("Chicken D Samosa");
            cmb_items.Items.Add("Chicken Stick");
            cmb_items.Items.Add("Qeema Samosa");
        }

        private void rd_sweats_CheckedChanged(object sender, EventArgs e)
        {
            rd_cake.ForeColor = Color.Red;
            rd_savory.ForeColor = Color.Red;
            rd_brownies.ForeColor = Color.Red;
            rd_sweats.ForeColor = Color.Green;
            rd_cupcakes.ForeColor = Color.Red;
            rd_cookies.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Barfi");
            cmb_items.Items.Add("Gulaab Jamun");
            cmb_items.Items.Add("Chum Chum");
            cmb_items.Items.Add("Rasgulla");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach(ListViewItem st_item in listView1.Items)
            //{
            //    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            //    SqlConnection con = new SqlConnection(cs);
            //    string query = "insert into ADD_ITEM_TBL values (@item, @price , @quantity, @total)";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@item", st_item.arr[0].cmb_items.SelectedItem);
            //    cmd.Parameters.AddWithValue("@price", st_item.SubItems[1].txt_price.Text);
            //    cmd.Parameters.AddWithValue("@quantity", st_item.SubItems[2].txt_qty.Text);
            //    cmd.Parameters.AddWithValue("@total", st_item.SubItems[3].txt_total.Text);

            //    con.Open();

            //    cmd.ExecuteNonQuery(); //for insertion,deletion,updation

            //    con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = (listView1.SelectedItems.Count > 0);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Retrieve the primary key or unique identifier of the item being deleted
                    //int id = (int)listView1.SelectedItems[0].Index; // Assuming you have stored the identifier in the Tag property of the ListViewItem
                    string id = txt_id.Text;
                    // Delete the item from the database
                    DeleteItemFromDatabase(id);

                    // Delete the item from the ListView
                    listView1.SelectedItems[0].Remove();
                }
                //for (int i = 0; i < listView1.Items.Count; i++)
                //{
                //    if (listView1.Items[i].Selected)
                //    {
                //        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                //        listView1.Items[i].Remove();
                //    }
                //}
            }
            void DeleteItemFromDatabase(string id)
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string query = "DELETE FROM ADD_ITEM_TBL WHERE p_id = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_qty_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_qty.Text) == true)
            //{
            //    txt_qty.Focus();
            //    errorProvider1.SetError(this.txt_qty, "Please Fill The Quantity !");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }

        private void txt_qty_TextChanged_1(object sender, EventArgs e)
        {

        }
    }


    //private void txt_sub_TextChanged(object sender, EventArgs e)
    //{

    //}

    //private void txt_price_TextChanged(object sender, EventArgs e)
    //{

    //}

    //private void label2_Click(object sender, EventArgs e)
    //{

    //}

    //private void billing_Load(object sender, EventArgs e)
    //{

    //}

    //private void label3_Click(object sender, EventArgs e)
    //{

    //}
}
