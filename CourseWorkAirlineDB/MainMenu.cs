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
    public partial class MainMenu : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int temporaryIndex;
        private Form activeForm;
        User user;


        public MainMenu(User user)
        {
            this.user = user;
            InitializeComponent();
            random = new Random();
        }
        private void OpenInfoForm(Form infoForm, object btnSender)
        {
            if (activeForm!= null)
            {
                activeForm.Close();
            }
            ActivateBtn(btnSender);
            activeForm = infoForm;
            infoForm.TopLevel = false;
            infoForm.FormBorderStyle = FormBorderStyle.None;
            infoForm.Dock = DockStyle.Fill;
            this.desk.Controls.Add(infoForm);
            this.desk.Tag = infoForm;
            infoForm.BringToFront();
            infoForm.Show();
            label1.Text = infoForm.Text;
        }
        private Color SelectColor()
        {
            int index  = random.Next(ThemeColor.colors.Count);
            while (temporaryIndex == index)
                index=random.Next(ThemeColor.colors.Count);
            temporaryIndex = index;
            string color = ThemeColor.colors[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateBtn(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    title.BackColor = color;
                }
            }
        }   
        private void DisableButton()
        {
            foreach(Control prevControl in panel1.Controls)
            {
                if (prevControl.GetType() == typeof(Button))
                {
                    prevControl.BackColor = Color.FromArgb(51, 51, 76);
                    prevControl.ForeColor = Color.Gainsboro;
                }
            }
        }
        string getPerson = "select * from Person";
        string getTicket = "select * from Ticket";
        string getFlight = "select * from Flight";
        string getAirprot = "select* from Airport";
        string getJet = "select * from Jet";
        private void passengersButton_Click(object sender, EventArgs e)
        {
            
            OpenInfoForm(new InfoForm(getPerson),sender);
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            OpenInfoForm(new InfoForm(getTicket), sender);
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            OpenInfoForm(new InfoForm(getFlight), sender);
        }

        private void airportButton_Click(object sender, EventArgs e)
        {
            OpenInfoForm(new InfoForm(getAirprot), sender);
        }

        private void jetsButton_Click(object sender, EventArgs e)
        {
            OpenInfoForm(new InfoForm(getJet), sender);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenInfoForm(new ProfileForm(user), sender);
        }
    }
}
