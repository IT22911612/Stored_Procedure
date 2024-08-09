using System.Data;
using System.Data.SqlClient;

namespace Stored_Procedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetEmpList();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Test_SP;User ID=sa;Password=tstc123");

        private void insert_btn_Click(object sender, EventArgs e)
        {

            int EmpID = int.Parse(textBox1.Text);
            String EmpName = textBox2.Text, City = comboBox1.Text, Contact = textBox7.Text, Sex = "";
            double Age = double.Parse(textBox4.Text);
            DateTime JoiningDate = DateTime.Parse(dateTimePicker1.Text);
            if (radioButton1.Checked == true) { Sex = "Male"; } else { Sex = "Female"; }
            con.Open();

            SqlCommand cm = new SqlCommand("EXEC InsertEmp_SP '" + EmpID + "','" + EmpName + "','" + City + "','" + Age + "','" + Sex + "','" + JoiningDate + "','" + Contact + "'", con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted...");
            GetEmpList();
            ClearFields();

        }

        void GetEmpList()
        {
            SqlCommand cm = new SqlCommand("EXEC ListEmp_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmpList();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            //update
            int empid = int.Parse(textBox1.Text);
            String empname = textBox2.Text, city = comboBox1.Text, contact = textBox7.Text, sex = "";
            double age = double.Parse(textBox4.Text);
            DateTime joindate = DateTime.Parse(dateTimePicker1.Text);
            if (radioButton1.Checked == true) { sex = "Male"; } else { sex = "Female"; }
            con.Open();

            SqlCommand cm = new SqlCommand("EXEC UpdateEmp_SP '" + empid + "','" + empname + "','" + city + "','" + age + "','" + sex + "','" + joindate + "','" + contact + "'", con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated...");
            GetEmpList();
            ClearFields();


        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //delete
            int empid = int.Parse(textBox1.Text);

            con.Open();

            SqlCommand cm = new SqlCommand("EXEC DeleteEmp_SP '" + empid + "'", con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted...");
            GetEmpList();
            ClearFields();

            con.Close();

        }

        private void ClearFields()
        {
            textBox1.Clear(); // Clears the EmpID text box
            textBox2.Clear(); // Clears the EmpName text box
            comboBox1.SelectedIndex = -1; // Resets the ComboBox to its default state
            textBox4.Clear(); // Clears the Age text box
            textBox7.Clear(); // Clears the Contact text box
            dateTimePicker1.Value = DateTime.Now; // Resets DateTimePicker to current date/time

            // Reset the radio buttons
            radioButton1.Checked = false; // Male
            radioButton2.Checked = false; // Female
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row index
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the form controls with the data from the selected row
                textBox1.Text = row.Cells["Emp_ID"].Value.ToString();
                textBox2.Text = row.Cells["Emp_Name"].Value.ToString();
                comboBox1.Text = row.Cells["City"].Value.ToString();
                textBox4.Text = row.Cells["Age"].Value.ToString();
                textBox7.Text = row.Cells["Contact"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["JoiningDate"].Value);

                // Set the sex radio buttons
                string sex = row.Cells["Sex"].Value.ToString();
                if (sex == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true; // Assuming radioButton2 is for Female
                }
            }
        }
    }
}
