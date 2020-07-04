using System.Collections.Generic;

namespace YapilakanamProcessor
{
    public class Osai
    {
        public List<string> ComputeOsai(List<string> shak)
        {
            var result = new List<string>();
            for (var index = 0; index < shak.Count; index++)
                if (shak[index].Contains("ஆசிரியத்தளை"))
                    result.Add("அகவலோசை");
                else if (shak[index].Contains("வெண்டளை"))
                    result.Add("செப்பலோசை");
                else if (shak[index].Contains("கலித்தளை"))
                    result.Add("துள்ளலோசை");
                else if (shak[index].Contains("வஞ்சித்தளை"))
                    result.Add("தூங்கலோசை");
            return result;
        }
    }
}