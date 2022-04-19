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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabAss3_
{
    public partial class SetValues : Form
    {
        public SetValues()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";

            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (radioMarried.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "Married";
            else Status = "Unmarried";

            try
            {
                CustomerValidation objval = new CustomerValidation();
                objval.CheckCustomerName(txtName.Text);
                frmCustomerPreview objPreview = new frmCustomerPreview();
                objPreview.SetValues(txtName.Text, comboBox1.Text, Gender, Hobby, Status);
                objPreview.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SetValues_Load(object sender, EventArgs e)
        {

            LoadCustomer();
        }
        private void LoadCustomer()
        {
            //Open a Connection
            string strConnection = "Data Source=DESKTOP-7BMCV8F;Initial Catalog=CustomerZJY;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            //Fire a command
            string strCommand = "Select * From Customer";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            //bind data with ui
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);
            dtgCustomer.DataSource = objDataSet.Tables[0];



            //close the connection
            objConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, status = "";

            if (radioMale.Checked) Gender = "MaLe";
            else Gender = "Female";

            if (chkReading.Checked) Hobby = "Reading"; else Hobby = "Painting";

            if (radioMarried.Checked) status = "1";
            else status = "0";

            // Open a Connection

            string strConnection = "Data Source=DESKTOP-7BMCV8F;Initial Catalog=CustomerZJY;Persist Security Info=True;User ID=sa;Pooling=False";

            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            //FFire a Command

            string strCommand = "insert into Customer(customerName Country Gender , Hobby , Married) values('" + txtName.Text + "','"
                            + cmbCountry.Text + "','"
                            + Gender + "','"
                            + Hobby + "',"
                            + status + ")";

            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            objCommand.ExecuteNonQuery();

            // Close the Connection 
            objConnection.Close();
            LoadCustomer();

        }//end button2. click

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            string id = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            displayCustomer(id);
        }
        private void displayCustomer(string id)
        {
            string strConnection = "Data Source=DESKTOP-7BMCV8F;Initial Catalog=CustomerZJY;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            // Fire a Command
            string strCommand = "Select * From Customer where id =" + id;
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            //Bind Data with UI
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);
            objConnection.Close();
            lblID.Text = objDataSet.Tables[0].Rows[0][0].ToString().Trim(); ;
            txtName.Text = objDataSet.Tables[0].Rows[0][1].ToString().Trim();
            comboBox1.Text = objDataSet.Tables[0].Rows[0][2].ToString().Trim();
            string Gender = objDataSet.Tables[0].Rows[0][3].ToString().Trim();
            if (Gender.Equals("Male")) radioMale.Checked = true;
            else radioFemale.Checked = true;
            string Hobby = objDataSet.Tables[0].Rows[0][4].ToString().Trim();
            if (Hobby.Equals("Reading")) chkReading.Checked = true;
            else chkPainting.Checked = true;
            string Married = objDataSet.Tables[0].Rows[0][5].ToString().Trim();
            if (Married.Equals("True")) radioMarried.Checked = true;
            else radioUnmarried.Checked = true;

        }

        private void clearForm()
        {
            txtName.Text = "";
            comboBox1.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            chkPainting.Checked = false;
            chkReading.Checked = false;
            radioMarried.Checked = false;
            radioUnmarried.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //open a connection
            string strConnection = "Data Source = DESKTOP - 7BMCV8F; Initial Catalog = CustomerZJY; Persist Security Info = True; User ID = sa; Pooling = False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            //fire a command
            string strCommand = "Delete from Customer where id = '" + lblID.Text + "'";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.ExecuteNonQuery();
            //close the connection
            objConnection.Close();
            clearForm();
            LoadCustomer();
        }
    }
    }
