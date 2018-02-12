using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subtitle_Converter
{
    class TextTools
    {
        public string convertToPolishLetters(StreamReader file)
        {             
           return file.ReadToEnd().Replace("¹", "ą").Replace("ê", "ę").Replace("¿", "ż").Replace("æ", "ć").
                 Replace("œ", "ś").Replace("Ÿ", "ź").Replace("³", "ł").Replace("Œ", "ś");
        }
    }
}
