using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
namespace Tetris
{
    public partial class Music : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Music 1");
            comboBox1.Items.Add("Music 2");
            comboBox1.Items.Add("Music 3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Music 1")
            {
                player.URL = "music 1.mp3";
                player.controls.play();
            }
            else if ((string)comboBox1.SelectedItem == "Music 2")
            {
                player.URL = "music 2.mp3";
                player.controls.play();
            }
            else if ((string)comboBox1.SelectedItem == "Music 3")
            {
                player.URL = "music 3.mp3";
                player.controls.play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}
