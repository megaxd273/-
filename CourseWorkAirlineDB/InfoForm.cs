using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CourseWorkAirlineDB
{
    public partial class InfoForm : Form
    {
        DataSet dataSet;
        
        string currentTable;
        public InfoForm(string getTable)
        {
            currentTable = getTable;
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(LogIn.Conn);
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(currentTable,conn);
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
