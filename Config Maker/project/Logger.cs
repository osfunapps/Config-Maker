using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.project
{
    internal class Logger
    {
        internal static string TITLE = "Log";

        internal static string GetTxt()
        {
            return "\nVersion 1.5" +
                   "\n- added shortcuts to all buttons" +
                   "\n- added focus when lost after click on a button" +
                   "\n- ctrl + T to go back to text area" +
                   "\n\nVersion 1.4" +
                   "\n- merged the ac config with the normal one" +
                   "\n- tab navigation enabled only for the text and the generation of the file" +
                   "\n- new shortcuts for generating text: numbers [alt + n] colors [alt + c] and volume [alt + v] " +
                   "\n- the path will be marked red until the user will choose to change it. On go click the red color will return" +
                   "\n\nVersion 1.2" +
                   "\n- addd mute btn" +
                   "\n- added volume button" +
                   "\n- window scaled" +
                   "\n\nVersion 1.1" +
                   "\n- added log btn" +
                   "\n- added numbers shortcut btn" +
                   "\n- added navigation shortcut btn" +
                   "\n- added colors shortct btn" +
                   "\n- added channels navigation btn" +
                   "\n- added vcr play stop and etc btns" +
                   "\n- now folders wont have to exists in path (the tool will create them programatically)";

        }
    }
}
