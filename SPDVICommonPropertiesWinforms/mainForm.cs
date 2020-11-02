using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVICommonPropertiesWinforms
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var formHeight = this.Height;
            var formWidth = this.Width;
            formSizeLabel.Text = "Form Size: " + formHeight + ", " + formWidth;
        }

        private void mainForm_LocationChanged(object sender, EventArgs e)
        {
            var x = this.Location.X.ToString();
            var y = this.Location.Y.ToString();

            this.Text = "("+x+", "+y+") Winforms Components - Common Controls";
        }

        private void formSizeLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void mainForm_MaximumSizeChanged(object sender, EventArgs e)
        {
            var formHeight = this.Height;
            var formWidth = this.Width;

            formSizeLabel.Text = "Form Size: " + formHeight + ", " + formWidth;
        }

        private void mainForm_MinimumSizeChanged(object sender, EventArgs e)
        {
            var formHeight = this.Height;
            
            var formWidth = this.Width;

            formSizeLabel.Text = "Form Size: " + formHeight + ", " + formWidth;
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            var formHeight = this.Height;
            var formWidth = this.Width;

            formSizeLabel.Text = "Form Size: " + formWidth + ", " + formHeight;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x - 5, y);
        }

        private void comboBoxBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxBorderStyle.SelectedIndex;

            switch(choice)
            {
                case 0:
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;

                case 1:
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;

                case 2:
                    this.FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;

                case 3:
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;

                case 5:
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;

                case 6:
                    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;

                default:
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (targetButton.Visible == true)
            {
                visibleButton.Text = "Visible = False";
                targetButton.Visible = false;
            }
            else if(targetButton.Visible == false)
            {
                visibleButton.Text = "Visible = True";
                targetButton.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (targetButton.Enabled == true)
            {
                enabledButton.Text = "Enabled = False";
                targetButton.Enabled = false;
            }
            else if (targetButton.Enabled == false)
            {
                enabledButton.Text = "Enabled = True";
                targetButton.Enabled = true;
            }
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            int x = (this.Width / 2) - 50;
            int y = (this.Height / 2) - 50;

            targetButton.Location = new Point(x, y);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x, y - 5);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x + 5, y);
        }

        private void botButton_Click(object sender, EventArgs e)
        {
            int x = this.targetButton.Location.X;
            int y = this.targetButton.Location.Y;

            targetButton.Location = new Point(x, y + 5);
        }

        private void targetButton_LocationChanged(object sender, EventArgs e)
        {
            var x = targetButton.Location.X.ToString();
            var y = targetButton.Location.Y.ToString();

            targetButton.Text = "    Target           X = "+x+"       Y = "+y;
        }
    }
}
