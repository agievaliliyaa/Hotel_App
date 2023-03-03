using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_App
{
    public partial class Main : Form
    {
        string conn_string = @"Data Source=DESKTOP-ERMV197\SQLEXPRESS;Initial Catalog=Clients;Integrated Security=True;Pooling=False";


        public Main()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationDataSet.View_Student' table. You can move, or remove it, as needed.
            
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            string cmd_text;
            Main f2 = new Main();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                cmd_text = $"INSERT INTO Table_1(ROOM, NAME, DATEIN, DATEOUT, STATUS) VALUES ({RoomTB}, '{NameTB}', {dateTimePicker1}, {dateTimePicker2}, {textBox1});";

                // создать соединение с базой данных
                SqlConnection sql_conn = new SqlConnection(conn_string);

                // создать команду на языке SQL
                SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);

                sql_conn.Open(); // открыть соединение
                sql_comm.ExecuteNonQuery(); // выполнить команду на языке SQL
                sql_conn.Close(); // закрыть соединение


            }
        }
    }
}
