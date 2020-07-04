using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using YapilakanamProcessor;

namespace TestConsole
{
    internal class Program
    {
        private static void Main()
        {
            const string unicodetxt1 = "ஊரவர் கெளவை";
            var output = Syllabify(unicodetxt1);
            Console.WriteLine(output.Count);
            const string unicodetxt2 = "கௌவை";
            output = Syllabify(unicodetxt2);
            Console.WriteLine(output.Count);
        }

       

        public static List<string> Syllabify(string unicodetext)
        {
            GlyphAnalyzer GlyphAnalyzer = new GlyphAnalyzer();
            var processdata = GlyphAnalyzer.CheckVisualGlyphPattern(unicodetext);
            if (string.IsNullOrEmpty(processdata)) return null;
            var enumerator = StringInfo.GetTextElementEnumerator(processdata);
            var data = new List<string>();
            while (enumerator.MoveNext())
                data.Add(enumerator.Current.ToString());
            return data;
        }
    }
}