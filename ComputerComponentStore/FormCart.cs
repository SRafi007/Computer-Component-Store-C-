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
using MetroFramework.Forms;

namespace ComputerComponentStore
{
    public partial class FormCart : MetroForm
    {
        private DataAccess Da { get; set; }
        private string IdSql;
        private byte count;
        private byte  comQuantity=0;
        private string comId;
        private int totalPrice;
        private string[] store= new string[100];
        private Salesman S1 { get; set; }
        public FormCart(Salesman sm1, string[] s, byte c)
        {
            InitializeComponent();
            Da = new DataAccess();
            store = s;
            count = c;
            lblPrice.Text = s[1];
            this.S1 = sm1;

            CartView();
        }
        private void CartView()
        {
            
            PopulateGridView("select * from Component Where Id IN(" + SelectedProductSql() + ");");
            TotalPrice();
        }


        private void FormCart_Load(object sender, EventArgs e)
        {

        }
        private string SelectedProductSql()
        {
            //lblTest.Text = count.ToString();
            IdSql = null;
            for (int j = 0; j < count; j++)
            {
                if (store[j] != null)
                {
                    IdSql += "'" + store[j] + "'" + ",";
                }
            }
            if (IdSql != null)
            {

                IdSql = IdSql.Remove(IdSql.Length - 1, 1);
            }
           // label1.Text = IdSql;
            
            return IdSql;
        }
        private void TotalPrice()
        {
            for (int i = 0; i < count; i++)
            {
                if (store[i] != null)
                {
                    string sql = "select * from Component WHERE Id='" + store[i] + "';";
                    var ds = this.Da.ExecuteQueryTable(sql);
                    string price = ds.Rows[0][5].ToString();
                    totalPrice += Int32.Parse(price);
                    lblPrice.Text = totalPrice.ToString();
                }
            }

            //var ds=this.Da.ExecuteQueryTable(sql)
        }
        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQueryTable(sql);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = ds;
        }
        private void FormCart_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();
        }
        private void dvgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    comQuantity = 0;
                    dgvCart.CurrentRow.Selected = true;
                    string comName = dgvCart.Rows[e.RowIndex].Cells[1].Value.ToString();
                    lblComponentName.Text = comName;
                    comId = dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //lblComponentQuantity.Text = comId;
                    for (int i = 0; i < store.Length; i++)
                    {
                        if (store[i] == comId)
                        {
                            comQuantity++;
                            lblComponentQuantity.Text = comQuantity.ToString();
                        }
                    }
                    lblComponentQuantity.Text = comQuantity.ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Select from the sell not from blank space");
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            for(int i=0;i<store.Length;i++)
                {
                      if(store[i]==comId)
                    {
                   
                    store[i] = null;
                    break;
                    }
               
            }        
            SelectedProductSql();
            if (IdSql != null)
            {
                S1.CountIteam--;
                totalPrice = 0;
                CartView();
                ResetValues();
               

            }
            else
            {
                MessageBox.Show("Youdont have anything in your cart now");
                this. S1.Show();
                this.Hide();

            }           
        }
        private void ResetValues()
        {
            lblComponentName.Text = "";
            lblComponentQuantity.Text = "";
            comId = "";
            comQuantity = 0;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            S1.TotalPrice = totalPrice;
            S1.Store = store;
            S1.Resetlabels();
            this.S1.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = "Confirm Order   : Total price:" + totalPrice.ToString();
                DialogResult result = MessageBox.Show(message, "Order", buttons);

                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (store[i] != null)
                        {
                            var query = "select * from Component where Id = '" + store[i] + "';";
                            var ds = this.Da.ExecuteQueryTable(query);
                            string sQ = ds.Rows[0][4].ToString();
                            int nQ = Int32.Parse(sQ) - 1;
                            var sql = "UPDATE Component SET Quantity =" + nQ + " WHERE Id='" + store[i] + "';";
                            int f = this.Da.ExecuteUpdateQuery(sql);
                            S1.ResetstringArr();
                        }


                    }
                    MessageBox.Show("Complete");
                    this.S1.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select from the sell not from blank space");
            }

        
        }
    }
}
