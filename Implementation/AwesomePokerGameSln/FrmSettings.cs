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

            switch (ThemeHelper.GetInstance().GetTheme())
            {
                case ThemeHelper.Theme.BLUE:
                    picBlueCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case ThemeHelper.Theme.ORANGE:
                    picOrangeCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case ThemeHelper.Theme.PURPLE:
                    picPurpleCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case ThemeHelper.Theme.WHITE:
                    picWhiteCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
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

        private void setTheme(ThemeHelper.Theme theme)
        {
            ThemeHelper.GetInstance().SetTheme(theme);
            this.BackColor = ThemeHelper.GetInstance().GetBackgroundColor();

            picBlueCard.BorderStyle = BorderStyle.None;
            picWhiteCard.BorderStyle = BorderStyle.None;
            picOrangeCard.BorderStyle = BorderStyle.None;
            picPurpleCard.BorderStyle = BorderStyle.None;

            switch (theme)
            {
                case ThemeHelper.Theme.BLUE:
                    picBlueCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case ThemeHelper.Theme.ORANGE:
                    picOrangeCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case ThemeHelper.Theme.PURPLE:
                    picPurpleCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case ThemeHelper.Theme.WHITE:
                    picWhiteCard.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }

        private void picBlueCard_Click(object sender, EventArgs e)
        {
            setTheme(ThemeHelper.Theme.BLUE);
        }

        private void picOrangeCard_Click(object sender, EventArgs e)
        {
            setTheme(ThemeHelper.Theme.ORANGE);
        }

        private void picPurpleCard_Click(object sender, EventArgs e)
        {
            setTheme(ThemeHelper.Theme.PURPLE);
        }

        private void picWhiteCard_Click(object sender, EventArgs e)
        {
            setTheme(ThemeHelper.Theme.WHITE);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Shift | Keys.R):
                    returnTitleForm.Show();
                    Hide();
                    return true;

                

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
