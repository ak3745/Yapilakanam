using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace YapilakanamProcessor
{
    public class Syllable
    {
        private readonly List<string> kuril;
        private readonly List<string> naedil;
        private readonly List<string> otru;

        public Syllable()
        {
            var letter = new Letter();
            kuril = new List<string>();
            naedil = new List<string>();
            otru = new List<string>();
            foreach (var s in letter.Kuril)
                kuril.Add(s);
            foreach (var s in letter.Uyirkuril)
                kuril.Add(s);
            foreach (var s in letter.Naedil)
                naedil.Add(s);
            foreach (var s in letter.Uyirnaedil)
                naedil.Add(s);
            foreach (var s in letter.Otru)
                otru.Add(s);
        }

        public List<string> Syllabify(string unicodetext)
        {
            if (string.IsNullOrEmpty(unicodetext)) return null;
            var enumerator = StringInfo.GetTextElementEnumerator(unicodetext);
            var data = new List<string>();
            while (enumerator.MoveNext())
                data.Add(enumerator.Current.ToString());
            var result = new List<string>(4);
            for (var i = 0; i < data.Count; i++)
            {
                if (otru.Contains(data[i])) continue;
                if (naedil.Contains(data[i]))
                    result.Add("நேர்");
                if (kuril.Contains(data[i]))
                {
                    result.Add("நேர்");
                    try
                    {
                        if (kuril.Contains(data[i + 1]) || naedil.Contains(data[i + 1]))
                        {
                            result.Insert(result.Count - 1, "நிரை");
                            result.RemoveAt(result.Count - 1);
                            i++;
                        }
                    }
                    catch (Exception x)
                    {
                        Debug.Write(x.Message);
                    }
                }
            }

            return result;
        }
    }
}