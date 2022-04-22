using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAirlineDB
{
    public partial class ProfileForm : Form
    {
        User user;
        public ProfileForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            systemID.Text += user.Id.ToString();
            systemName.Text += user.FirstName;
            systemSurname.Text += user.LastName;
            systemAge.Text += user.Age.ToString();
            systemUsername.Text += user.Username;
            systemPassword.Text += user.Password;
        }
    }
}
