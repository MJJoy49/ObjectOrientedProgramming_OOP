using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using p2.All_Form;

namespace p2
{
    public partial class Form1 : Form
    {

        // Define your label controls (not just names)
        Label[] labelName;

        public Form1()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);
            forDraggingForm();
            RoundForm.roundedForm(this, 30);
            RoundPanel.roundedPanel(MenuPanel, 40);
            RoundPanel.roundedPanel(UpperPanel, 20);

            // Initialize the label controls array
            labelName = new Label[]
            {
                deshboardBtn, notificationsBtn, roomsBtn, membersBtn,
                mealsBtn, expensesBtn, marketsBtn, settingsBtn
            };

            ResetAndHighlightLabel("deshboardBtn");
        }

        //-----------------------------------------------------------------------------------








        // application display position change------------------------------------------------

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void forDraggingForm()
        {
            MouseDown += new MouseEventHandler(UpperPanel_MouseDown);
            MouseUp += new MouseEventHandler(UpperPanel_MouseUp);
            MouseMove += new MouseEventHandler(UpperPanel_MouseMove);
        }

        private void UpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void UpperPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void UpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = Control.MousePosition;
                Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        //-------------------------------------------------------------------------------------












        // Button click event handlers that highlight the label and add respective user controls---------------------------


        // Function to reset and highlight labels-------------------
        private void ResetAndHighlightLabel(string BtnName)
        {
            foreach (var label in labelName)
            {
                if (label.Name != BtnName)
                {
                    label.ForeColor = Color.FromArgb(150, 150, 150); // Default color
                }
                else
                {
                    label.ForeColor = Color.FromArgb(254, 254, 254); // Highlight color
                }
            }
        }

        //------------------------------------------------------------


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void deshboardBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("deshboardBtn");
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);
        }

        private void notificationsBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("notificationsBtn");
            Notifiacations notifications = new Notifiacations();
            addUserControl(notifications);
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("roomsBtn");
            Rooms rooms = new Rooms();
            addUserControl(rooms);
        }

        private void membersBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("membersBtn");
            Members members = new Members();
            addUserControl(members);
        }

        private void mealsBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("mealsBtn");
            Meals meals = new Meals();
            addUserControl(meals);
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("expensesBtn");
            Expenses expenses = new Expenses();
            addUserControl(expenses);
        }

        private void marketsBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("marketsBtn");
            Markets markets = new Markets();
            addUserControl(markets);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ResetAndHighlightLabel("settingsBtn");
            Settings settings = new Settings();
            addUserControl(settings);
        }

        //-----------------------------------------------------------------------------------------------------------











        //Logout-logo-btn, logout-btn, minimized btn, close btn----------------------------
        private void logoutLogoBtn_Click(object sender, EventArgs e)
        {
            // Display confirmation message box
            DialogResult dialogResult = MessageBox.Show
                                                        (
                                                            "Are you sure you want to exit?", 
                                                            "Exit Confirmation",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question
                                                        );

            // If the user clicks 'Yes', close the application
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            // Display confirmation message box
            DialogResult dialogResult = MessageBox.Show
                                                        (
                                                            "Are you sure you want to exit?", 
                                                            "Exit Confirmation", 
                                                            MessageBoxButtons.YesNo, 
                                                            MessageBoxIcon.Question
                                                        );

            // If the user clicks 'Yes', close the application
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-----------------------------------------------------------------------------
    }
}
