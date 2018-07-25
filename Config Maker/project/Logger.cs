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
            return "Version 1.4" +
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
