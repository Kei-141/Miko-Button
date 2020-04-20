using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Miko_Button
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string current_dir = System.Environment.CurrentDirectory + "\\data\\";

        private System.Media.SoundPlayer player = null;
        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }

        private void PlaySound(string sound_file)
        {
            try
            {
                player = new System.Media.SoundPlayer(sound_file);
                player.Play();
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("ファイルが見つかりませんでした。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hello_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + hello.Text + ".wav");
        }

        private void nyahello_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + nyahello.Text + ".wav");
        }

        private void faq_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + faq.Text + ".wav");
        }

        private void shiketennile_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + shiketennile.Text + ".wav");
        }

        private void orala_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + orala.Text + ".wav");
        }

        private void nile_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + nile.Text + ".wav");
        }

        private void mikohawarukunai_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + mikohawarukunai.Text + ".wav");
        }

        private void shike_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + shike.Text + ".wav");
        }

        private void tennile_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + tennile.Text + ".wav");
        }

        private void unchi_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + unchi.Text + ".wav");
        }

        private void oioioi_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + oioioi.Text + ".wav");
        }

        private void kusa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + kusa.Text + ".wav");
        }

        private void nainatta_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + nainatta.Text + ".wav");
        }

        private void hajimaruyo_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + hajimaruyo.Text + ".wav");
        }

        private void oitan_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + oitan.Text + ".wav");
        }

        private void ababababa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + ababababa.Text + ".wav");
        }

        private void twuttwu_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + twuttwu.Text + ".wav");
        }

        private void altutyu_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + altutyu.Text + ".wav");
        }

        private void wauwau_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + wauwau.Text + ".wav");
        }

        private void dwunchi_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + dwunchi.Text + ".wav");
        }

        private void dondonpa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + dondonpa.Text + ".wav");
        }

        private void faaaaa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + faaaaa.Text + ".wav");
        }

        private void da_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + da.Text + ".wav");
        }

        private void konnanottenaiyo_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + konnanottenaiyo.Text + ".wav");
        }

        private void tuntun_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + tuntun.Text + ".wav");
        }

        private void bababababa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + bababababa.Text + ".wav");
        }

        private void babababa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + babababa.Text + ".wav");
        }

        private void hohyabupa_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + hohyabupa.Text + ".wav");
        }

        private void ahin_Click(object sender, EventArgs e)
        {
            PlaySound(current_dir + ahin.Text + ".wav");
        }
    }
}
