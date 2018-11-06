using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code
{
    public class ThemeHelper
    {
        public enum Theme
        {
            BLUE,
            ORANGE,
            PURPLE,
            WHITE
        }
        public Theme active_theme;

        //singleton
        private static ThemeHelper instance = null;

        //singleton lazy initialization
        static ThemeHelper()
        {
            instance = new ThemeHelper();
        }

        /// <summary>
        /// Creates a new theme helper
        /// </summary>
        public ThemeHelper()
        {
            // default theme
            active_theme = Theme.WHITE;
        }

        /// <summary>
        /// Returns the singleton instance
        /// </summary>
        public static ThemeHelper GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// Clears the singleton instance
        /// </summary>
        public static void ClearInstance()
        {
            instance = null;
        }

        /// <summary>
        /// Update the current active theme
        /// </summary>
        public void SetTheme (Theme theme)
        {
            active_theme = theme;
        }

        /// <summary>
        /// Returns the current active theme
        /// </summary>
        public Theme GetTheme()
        {
            return active_theme;
        }

        /// <summary>
        /// Returns the current theme's card back resource name
        /// </summary>
        public String GetCardBack()
        {
            switch (active_theme)
            {
                case Theme.BLUE:
                    return "card_back_blue";
                case Theme.ORANGE:
                    return "card_back_orange";
                case Theme.PURPLE:
                    return "card_back_purple";
                case Theme.WHITE:
                    return "card_back_white";
                default:
                    return "card_back_blue";
            }
        }

        /// <summary>
        /// Returns the current theme's background color
        /// </summary>
        public Color GetBackgroundColor()
        {
            switch (active_theme)
            {
                case Theme.BLUE:
                    return Color.Aquamarine;
                case Theme.ORANGE:
                    return Color.Orange;
                case Theme.PURPLE:
                    return Color.Plum;
                case Theme.WHITE:
                    return Color.White;
                default:
                    return Color.Aquamarine;
            }
        }


    }
}
