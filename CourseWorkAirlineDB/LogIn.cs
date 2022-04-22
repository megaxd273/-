using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CourseWorkAirlineDB
{
    public partial class LogIn : Form
    {
        //border props
        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;

        //sql fields
        

        public static string Conn
        {
            get { return connectionStr; }
            
        }

        static string connectionStr = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Airline;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionStr);
        SqlCommand cmd;
        string personTable = "select * from Person";

        //models
        MainMenu form2;
        User user;
        


        public LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            


        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void PanelRegionAndBorder(Control form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias​​;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rectangle = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rectangle.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rectangle.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PanelRegionAndBorder(panel1,borderRadius,e.Graphics,borderColor,borderSize);
        }

        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if (UsernameBox.Text.Equals("Username"))
            {
                UsernameBox.Text = "";
            }
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (UsernameBox.Text.Equals(""))
            {
                UsernameBox.Text = "Username";

            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Equals("Password"))
            {
                PasswordBox.Text = "";

            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Equals(""))
            {
                PasswordBox.Text = "Password";

            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(personTable, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if(UsernameBox.Text.Equals(reader["Username"].ToString())&& PasswordBox.Text.Equals(reader["UserPassword"].ToString()))
                {
                    user = new User((int)reader["PersonId"], reader["FirstName"].ToString(), reader["LastName"].ToString(),
                        (int)reader["PersonAge"], reader["Username"].ToString(), reader["UserPassword"].ToString());
                    if (Application.OpenForms["Form2"]==null)
                    {
                        form2 =new MainMenu(user);
                        form2.ShowDialog();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error occured",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            PasswordBox.UseSystemPasswordChar = false;
            pictureBox4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
            PasswordBox.UseSystemPasswordChar = true;
            pictureBox3.Show();
        }
    }
}
