using RAM_Cleaner_2.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAM_Cleaner_2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "mailto:panchal.harsh18@gmail.com";
            linkLabel1.Links.Add(link);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (linkLabel1.Text == "<panchal.harsh18@gmail.com>")
            {
                label1.Text = "BOOTMGR";
                linkLabel1.Text = "github.com/BOOTMGR";
                linkLabel1.Links.Clear();
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = "http://www.github.com/BOOTMGR";
                linkLabel1.Links.Add(link);
                pictureBox1.Image = (Image) RAM_Cleaner_2.Properties.Resources.avatar;
            }
            else
            {
                label1.Text = "Harsh Panchal";
                linkLabel1.Text = "<panchal.harsh18@gmail.com>";
                linkLabel1.Links.Clear();
                LinkLabel.Link link = new LinkLabel.Link();
                link.LinkData = "mailto:panchal.harsh18@gmail.com";
                linkLabel1.Links.Add(link);
                pictureBox1.Image = (Image)RAM_Cleaner_2.Properties.Resources.free_ram1;
            }
        }
    }
}
