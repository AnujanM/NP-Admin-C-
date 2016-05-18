using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=Student;uid=A;pwd=123456;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                string query = "SELECT * From students WHERE studentNumber='33'";
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Open!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=Student;uid=A;pwd=123456;";
            cnn = new MySqlConnection(connetionString);
            string query = "SELECT * From students WHERE studentNumber='" + textBox1.Text +"'";
            try
            {
                cnn.Open();
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                //Execute command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MessageBox.Show("Connection Open ! ");
                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader["fName"] + " " + dataReader["lName"] + "");
                    Name.Text = dataReader["fName"] + " " + dataReader["lName"] + "";
                    Citizen.Text = dataReader["citizenshipPoints"] + "";
                    Arts.Text = dataReader["artsPoints"] + "";
                    Athletic.Text = dataReader["athleticPoints"] + "";
                    Academic.Text = dataReader["academicPoints"] + "";
                }
                dataReader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=Student;uid=A;pwd=123456;";
            cnn = new MySqlConnection(connetionString);
            string query = "UPDATE students SET academicPoints='" + Academic.Text + "', artsPoints='" + Arts.Text + "', athleticPoints='" + Athletic.Text + "', citizenshipPoints='" + Citizen.Text + "' WHERE studentNumber='" + textBox1.Text + "'";
            try
            {
                cnn.Open();
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Change Made!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not make change! ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Check If file is selected.
            {
                string file = openFileDialog1.FileName;
                MySqlConnection cnn;
                string connetionString = "server=localhost;database=Student;uid=A;pwd=123456;";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                Dictionary<string, int> info = new Dictionary<string, int>();
                string query = "SELECT * From students"; //Grab pre-existing data to find students and points
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MessageBox.Show("Connection Open ! ");
                while (dataReader.Read())
                {
                    info.Add(dataReader["studentNumber"] + "", Int32.Parse(dataReader["academicPoints"]+""));
                }
                dataReader.Close();
                try
                {
                    string[] text = File.ReadAllLines(file); //Saves into array
                    foreach(string line in text)
                    {
                        if (info.ContainsKey(line))
                        {
                            int points = info[line] + 10;
                            string q = "UPDATE students SET academicPoints='"+ points + "' WHERE studentNumber='" + line + "'";
                            MySqlCommand cmd1 = new MySqlCommand(q, cnn);
                            cmd1.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show(line + " Does Not Exist");
                        }
                    }
                    cnn.Close();
                    MessageBox.Show("Done Import");
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
