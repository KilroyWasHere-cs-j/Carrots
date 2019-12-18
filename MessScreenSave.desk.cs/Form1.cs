using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MessScreenSave.desk.cs
{
    public partial class Form1 : Form
    {
        public string text;
        public string[] lines = File.ReadAllLines("TextFile1.txt");
        public int count = 0;
        public int hold = 0;
        public int monthInteger;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //needs work 
            label2.Font = new Font("Arial", 48, FontStyle.Bold);
            label3.Font = new Font("Arial", 48, FontStyle.Bold);
            int length = 0;
            try
            {
                length = lines[count].Length;
            }
            catch
            {
                count = 1;
            }
            if(length > 30)
            {
                //over thrity handler
                string text = lines[count];
                if (text.Contains("|") == true)
                {
                    int index = text.IndexOf("|");
                    string lab2 = text.Substring(index);
                    lab2 = lab2.Replace("|", " ");
                    string lab1;
                    label3.Text = lab2;
                    lab1 = text.Substring(0, index);
                    lab1 = lab1.Replace(lab2, " ");
                    label2.Text = text.Substring(0, index);
                    label2.Text = lab1;
                    count++;
                }
                else
                {
                    try
                    {
                        label2.Text = lines[count];  //needs try catch to help when it excids the total number for set lines
                        label3.Text = null;
                        count++;
                    }
                    catch
                    {
                        count = 1;
                    }
                }
            }
            else
            {
                try
                {
                    label2.Text = lines[count];  //needs try catch to help when it excids the total number for set lines
                    label3.Text = null;
                    count++;
                }
                catch
                {
                    count = 1;
                }
            }
            /*if(length >= 30)
            {
                string text = lines[count];
                if(text.Contains("|") == true)
                {
                    int index = text.IndexOf("|");
                    string lab2 = text.Substring(index);
                    lab2 = lab2.Replace("|", " ");
                    string lab1;
                    label3.Text = lab2;
                    lab1 = text.Substring(0, index);
                    lab1 = lab1.Replace(lab2, " ");
                    label2.Text = text.Substring(0, index);
                    label2.Text = lab1;
                    count++;
                }
                else
                {
                    try
                    {
                        label2.Text = lines[count];  //needs try catch to help when it excids the total number for set lines
                        label3.Text = null;
                        count++;
                    }
                    catch
                    {
                        count = 1;
                    }
                }
            }
            else
            {
                try
                {
                    label2.Text = lines[count];  //needs try catch to help when it excids the total number for set lines
                    label3.Text = null;
                    count++;
                }
                catch
                {
                    count = 1;
                }
            }*/
        }

        void timer_Tick2(object sender, EventArgs e)
        {
            string dater = DateTime.Now.ToString("h:mm:ss tt");
            label1.Text = dater;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            switch (hold)
            {
                case 1:
                    label1.Text = "No!";
                    break;
                case 2:
                    label1.Text = "I said no!!";
                    break;
            }
        }

        private void month_Calc()
        {
            string month = DateTime.Now.ToString("MMMM");
            MessageBox.Show(month);
            switch (month)
            {
                case "January":
                    Image myimage1 = new Bitmap(@"C:\screen_saver_images\Januray.jpg");
                    this.BackgroundImage = myimage1;
                    break;
                case "Feburary":
                    Image myimage2 = new Bitmap(@"C:\screen_saver_images\Feburary.jpg");
                    this.BackgroundImage = myimage2;
                    break;
                case "March":
                    Image myimage4 = new Bitmap(@"C:\screen_saver_images\March.jpg");
                    this.BackgroundImage = myimage4;
                    break;
                case "April":
                    Image myimage5 = new Bitmap(@"C:\screen_saver_images\April.jpg");
                    this.BackgroundImage = myimage5;
                    break;
                case "May":
                    Image myimage6 = new Bitmap(@"C:\screen_saver_images\May.jpg");
                    this.BackgroundImage = myimage6;
                    break;
                case "June":
                    Image myimage7 = new Bitmap(@"C:\screen_saver_images\June.jpg");
                    this.BackgroundImage = myimage7;
                    break;
                case "July":
                    Image myimage8 = new Bitmap(@"C:\screen_saver_images\July.gif");
                    this.BackgroundImage = myimage8;
                    break;
                case "August":
                    Image myimage9 = new Bitmap(@"C:\screen_saver_images\August.jpg");
                    this.BackgroundImage = myimage9;
                    break;
                case "September":
                    Image myimage10 = new Bitmap(@"C:\screen_saver_images\September.jpg");
                    this.BackgroundImage = myimage10;
                    break;
                case "October":
                   Image myimage11 = new Bitmap(@"C:\screen_saver_images\Test.gif");
                   this.BackgroundImage = myimage11;
                    label1.ForeColor = Color.Orange;
                    label2.ForeColor = Color.Orange;
                    label3.ForeColor = Color.Orange;
                    break;
                case "November":
                    Image myimage12 = new Bitmap(@"C:\screen_saver_images\November.jpg");
                    this.BackgroundImage = myimage12;
                    break;
                case "December":
                    Image myimage13 = new Bitmap(@"C:\screen_saver_images\December.jpg");
                    this.BackgroundImage = myimage13;
                    break;
                default:
                    MessageBox.Show("Something is terribly wrong here.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 4000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
            System.Windows.Forms.Timer tim = new System.Windows.Forms.Timer();
            tim.Interval = 100;
            tim.Tick += new EventHandler(timer_Tick2);
            tim.Start();
            month_Calc();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            this.Controls.Add(this.label2);
            this.label2.Size = new System.Drawing.Size(10, 10);
            this.label2.AutoSize = true;
            TopMost = true;
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
