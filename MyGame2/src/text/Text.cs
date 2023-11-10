using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesMy
{
    public static class Text
    {
        private static Language _language;
        public static Language Language
        {
            get
            {
                if (_language == null)
                    throw new Exception("Нет загруженого языка");
                return _language;
            }
        }
        public static void LoadLanguage(Language language) { _language = language; }
    }
}
