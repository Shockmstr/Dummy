using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DummyCSharp
{
    public partial class Form1 : Form
    {
        private const string PNG = ".png";
        private const string JPG = ".jpg";

        IDictionary<string, string> impactList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            impactList = Property.impactListInit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string carModel = cbCarModel.SelectedItem.ToString();
                string velocity = cbVelocity.SelectedItem.ToString();
                string dummyPos = cbDummyPos.SelectedItem.ToString();

                string folderData = "D:\\VisualStudio\\C#\\Dummy\\video\\data";
                string data = Path.Combine(folderData, carModel + "1" + PNG);
                string data2 = Path.Combine(folderData, carModel + "2" + PNG);

                PictureBox1.Image = Image.FromFile(data);
                PictureBox2.Image = Image.FromFile(data2);

                string key = carModel + velocity + dummyPos;
                if (rbFirstImp.Checked || rbGroundImp.Checked || rbBoth.Checked)
                {
                    string value = impactList[key];
                    string[] values = value.Split('-');
                    resultNum1.Text = values[0];
                    resultNum2.Text = values[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input");
            }
            
        }

        private void btnAnnotation_Click(object sender, EventArgs e)
        {
            PictureBox3.Image = Properties.Resources.hic_to_ais;
        }

        private void btnAcceleration_Click(object sender, EventArgs e)
        {
            PictureBox3.Image = Properties.Resources.acceleration_blank;          
            try
            {
                string carModel = cbCarModel.SelectedItem.ToString();
                string velocity = cbVelocity.SelectedItem.ToString();
                string dummyPos = cbDummyPos.SelectedItem.ToString();
                string o = "1";
                if (rbFirstImp.Checked) o = "1";
                else if (rbGroundImp.Checked) o = "2";
                else if (rbBoth.Checked) o = "3";

                string tmp = carModel + velocity + dummyPos + o;
                string folderAccel = "D:\\VisualStudio\\C#\\Dummy\\video\\accel";
                string accel = Path.Combine(folderAccel, tmp + JPG);

                PictureBox3.Image = Image.FromFile(accel);
            }
            catch (Exception)
            {
            }
        }

        private void rbFirstImp_CheckedChanged(object sender, EventArgs e)
        {           
            try
            {
                string carModel = cbCarModel.SelectedItem.ToString();
                string velocity = cbVelocity.SelectedItem.ToString();
                string dummyPos = cbDummyPos.SelectedItem.ToString();
                string o = "1";

                string tmp = carModel + velocity + dummyPos + o;
                string folder = "D:\\VisualStudio\\C#\\Dummy\\video";
                string filename = Path.Combine(folder, tmp + PNG);

                PictureBox3.Image = Properties.Resources.accel_1st_impact;
                pbDemo.Image = Image.FromFile(filename);
            }
            catch (Exception)
            {

            }
        }

        private void rbGroundImp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string carModel = cbCarModel.SelectedItem.ToString();
                string velocity = cbVelocity.SelectedItem.ToString();
                string dummyPos = cbDummyPos.SelectedItem.ToString();
                string o = "2";

                string tmp = carModel + velocity + dummyPos + o;
                string folder = "D:\\VisualStudio\\C#\\Dummy\\video";
                string filename = Path.Combine(folder, tmp + PNG);

                PictureBox3.Image = Properties.Resources.accel_ground_impact;
                pbDemo.Image = Image.FromFile(filename);
            }
            catch (Exception)
            {

            }
        }

        private void rbBoth_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PictureBox3.Image = Properties.Resources.accel_ground_impact;
            }
            catch (Exception)
            {

            }
        }

        private int i = 1;
        private void Timer1_Tick(object sender, EventArgs e)
        {           
            i++;
            try
            {
                string carModel = cbCarModel.SelectedItem.ToString();
                string velocity = cbVelocity.SelectedItem.ToString();
                string dummyPos = cbDummyPos.SelectedItem.ToString();

                string tmp = carModel + velocity + dummyPos + "Vid";
                string tmp2 = "0" + i;
                string folder = "D:\\VisualStudio\\C#\\Dummy\\video";
                string videos = Path.Combine(folder, tmp, tmp2 + JPG);

                Console.WriteLine(videos);
                Console.WriteLine(i);
                pbVideo.Image = Image.FromFile(videos);
            }
            catch (Exception)
            {
                i = 0;
                Timer1.Start();
            }
        }

        private void trackSpeed_Scroll(object sender, EventArgs e)
        {
            inc.Text = trackSpeed.Value.ToString();
            Timer1.Interval = trackSpeed.Value * 20;
        }

        private void trackState_Scroll(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Timer1.Start();
            }
            catch (Exception)
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                Timer1.Stop();
                i = 0;
            }
            catch (Exception)
            {    
            }
        }
   
    }
}
