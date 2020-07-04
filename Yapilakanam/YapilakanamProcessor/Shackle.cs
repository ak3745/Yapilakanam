using System.Collections.Generic;
using System.Globalization;

namespace YapilakanamProcessor
{
    public class Shackle
    {
        public List<string> ComputeShackle(List<string> shak)
        {
            var result = new List<string>();
            var fs = string.Empty;
            var ls = string.Empty;
            var lsb = string.Empty;
            var fscount = 0;
            var lscount = 0;

            var flag = false;
            for (var index = 0; index < shak.Count - 1; index++)
            {
                var enumerator = StringInfo.GetTextElementEnumerator(shak[index]);
                while (enumerator.MoveNext())
                {
                    fs = enumerator.Current.ToString();
                    fscount++;
                }

                var enumerator1 = StringInfo.GetTextElementEnumerator(shak[index + 1]);
                while (enumerator1.MoveNext())
                {
                    lsb = enumerator1.Current.ToString();
                    lscount++;
                    if (flag) continue;
                    ls = enumerator1.Current.ToString();
                    flag = true;
                }

                if (fscount == 4)
                    if (fs.Equals("ர்"))
                        result.Add(ls.Equals("நே") ? "நேரொன்றிய ஆசிரியத்தளை" : "சிறப்புடை இயற்சீர் வெண்டளை");
                    else
                        result.Add(ls.Equals("நி") ? "நிரையொன்றிய ஆசிரியத்தளை" : "சிறப்பில் இயற்சீர் வெண்டளை");
                else if (fs.Equals("ர்"))
                    if (lscount == 6 && lsb.Equals("ர்"))
                        result.Add(ls.Equals("நி") ? "சிறப்புடைக் கலித்தளை" : "சிறப்புடை வெண்சீர் வெண்டளை");
                    else
                        result.Add(ls.Equals("நி") ? "சிறப்பில் கலித்தளை" : "சிறப்பில் வெண்சீர் வெண்டளை");
                else if (lscount == 6 && lsb.Equals("ரை"))
                    result.Add(ls.Equals("நி") ? "சிறப்புடை ஒன்றிய வஞ்சித்தளை" : "சிறப்புடை ஒன்றாத வஞ்சித்தளை");
                else
                    result.Add(ls.Equals("நி") ? "சிறப்பில் ஒன்றிய வஞ்சித்தளை" : "சிறப்பில் ஒன்றாத வஞ்சித்தளை");
                fscount = 0;
                lscount = 0;
                flag = false;
            }

            return result;
        }
    }
}