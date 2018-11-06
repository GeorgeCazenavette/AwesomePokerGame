using AwesomePokerGameSln.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomePokerGameSln
{
    public partial class FrmSettings : Form
    {
        FrmTitle returnTitleForm;
        SoundHelper soundHelper;

        /// <summary>
        /// Form to adjust settings
        /// </summary>
        /// <param name="returnTitleForm">Title form to return to</param>
        public FrmSettings(FrmTitle returnTitleForm)
        {
            this.returnTitleForm = returnTitleForm;
            this.BackColor = ThemeHelper.GetInstance().GetBackgroundColor();
            soundHelper = SoundHelper.GetInstance();
            InitializeComponent();
            setMuteImage();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            returnTitleForm.Show();
            Hide();
        }

        private void lblMuteText_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles KeyDown Events within FrmSettings
        /// </summary>
        private void FrmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            //M stands for mute
            if (e.KeyCode == Keys.M)
            {
                SoundHelper.GetInstance().mute_unmute();
                setMuteImage();
            }
        }

        private void setMuteImage()
        {
            if (soundHelper.isMuted())
            {
                picMute.Visible = true;
                picUnmute.Visible = false;
            }
            else
            { 
                picMute.Visible = false;
                picUnmute.Visible = true;
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
