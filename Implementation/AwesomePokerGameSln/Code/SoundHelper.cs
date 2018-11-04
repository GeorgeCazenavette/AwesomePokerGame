using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code
{
  public class SoundHelper
  {
    private SoundPlayer bgSoundPlayer;
    private bool muted;
    //private SoundPlayer effectSoundPlayer;

    /// <summary>
    /// Creates a new sound helper and starts playing the background music
    /// </summary>
    public SoundHelper()
    {
      bgSoundPlayer = new SoundPlayer();
      //effectSoundPlayer = new SoundPlayer();
      initBgMusic();
      muted = false;

    }

    /// <summary>
    /// Creates a SoundPlayer for the Background Music then plays the background music
    /// </summary>
    public void initBgMusic()
    {
      System.IO.Stream str = Properties.Resources.background_music;
      bgSoundPlayer.Stream = str;
      playBgMusic();
    }


    /// <summary>
    /// Plays the background music on a loop if not currently muted.
    /// </summary>
    public void playBgMusic()
    {
      if (!muted)
      {
        bgSoundPlayer.PlayLooping();
      }

    }

    /// <summary>
    /// Stops the background music
    /// </summary>
    public void stopBgMusic()
    {
      bgSoundPlayer.Stop();
    }

    /// <summary>
    /// If muted, mutes all sounds dispatched through the sound helper. Otherwise, it unmutes and restarts the background music
    /// </summary>
    public void mute_unmute()
    {
      //flip the state
      muted = !muted;
      //if the music was unmuted we need to startup the bg music again
      if (muted)
      {
        stopBgMusic();
      }
      else
      {
        playBgMusic();
      }
    }

  }
}
