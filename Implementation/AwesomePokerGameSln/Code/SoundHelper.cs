using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code
{
  class SoundHelper
  {
    private SoundPlayer bgSoundPlayer;
    //private SoundPlayer effectSoundPlayer;

    public SoundHelper()
    {
       bgSoundPlayer = new SoundPlayer();
      //effectSoundPlayer = new SoundPlayer();
      initBgMusic();

    }
    public void initBgMusic()
    {
      System.IO.Stream str = Properties.Resources.background_music;
      bgSoundPlayer.Stream = str;
      bgSoundPlayer.PlayLooping();
    }

  }
}
