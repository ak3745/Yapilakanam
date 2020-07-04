using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace YapilakanamProcessor
{
    public class GlyphAnalyzer
    {
        public string CheckVisualGlyphPattern(string txt)
        {
            var data = txt.Split(new[] {' ', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var list = string.Empty;
            var rx = new Regex("^(.*?){1}(\u0bc6){1}(\u0bb3){1}");
            foreach (var s in data)
            {
                var matches = new List<Match>();
                if (rx.IsMatch(s))
                {
                    var enumerator = StringInfo.GetTextElementEnumerator(s);
                    var data1 = new List<string>();
                    while (enumerator.MoveNext())
                        data1.Add(enumerator.Current.ToString());
                    if (data1[1].Equals("ள"))
                    {
                        var outputs = rx.Replace(s, match =>
                        {
                            matches.Add(match);
                            return string.Format("{0}\u0bcc", match.Groups[1].Value);
                        });
                        list += string.Format("{0} ", outputs);
                    }
                    else
                    {
                        list += string.Format("{0} ", s);
                    }
                }
                else
                {
                    list += string.Format("{0} ", s);
                }
            }

            return list.Trim();
        }
    }
}