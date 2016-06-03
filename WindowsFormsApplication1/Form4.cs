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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Check If file is selected.
            {
                string file = openFileDialog1.FileName;
                MySqlConnection cnn;
                string connetionString = "server=localhost;database=Clubs;uid=A;pwd=123456;";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                try
                {
                    string[] text = File.ReadAllLines(file); //Saves into array
                    foreach (string line in text)
                    {
                        char[] delimiterChars = { ','};
                        string[] data = line.Split(delimiterChars);
                        string q = "INSERT INTO " + comboBox1.Text + " () VALUES ('" + data[0] + "','" + textBox1.Text + "','" + data[1] + "','" + data[2] + "','" + data[3] + "','" + data[4] + "','" + "0')";
                        MySqlCommand cmd1 = new MySqlCommand(q, cnn);
                        cmd1.ExecuteNonQuery();
                        }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not make change! ");
                }
            }
        }
    }
}
