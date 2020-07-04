using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace YapilakanamProcessor
{
    public class KutriyalUgaram
    {
        private const string Nextletter = "யா";
        private static readonly string[] Array1 = new Letter().Naedil;
        private static readonly string[] Array2 = new Letter().Kuril;

        private readonly string[] endwith = {"கு", "சு", "டு", "து", "பு", "று"};
        private readonly string[] startwith = new string[Array1.Length + Array2.Length];

        public KutriyalUgaram()
        {
            Array.Copy(Array1, startwith, Array1.Length);
            Array.Copy(Array2, 0, startwith, Array1.Length, Array2.Length);
        }

        public string[] RemoveKutriyalukaram(string[] inputs)
        {
            var outputs = new string[inputs.Length];
            for (var i = 0; i < inputs.Length - 1; i++)
                if (inputs[i].EndsWith(endwith[0]) ||
                    inputs[i].EndsWith(endwith[1]) ||
                    inputs[i].EndsWith(endwith[2]) ||
                    inputs[i].EndsWith(endwith[3]) ||
                    inputs[i].EndsWith(endwith[4]) ||
                    inputs[i].EndsWith(endwith[5]))
                {
                    string data = null;
                    var enumerator = StringInfo.GetTextElementEnumerator(inputs[i + 1]);
                    while (enumerator.MoveNext())
                    {
                        data = enumerator.Current.ToString();
                        break;
                    }

                    if (!string.IsNullOrEmpty(Array.Find(startwith, s => s == data)))
                        outputs[i] = inputs[i].Remove(inputs[i].Length - 2);
                    else outputs[i] = inputs[i];
                }
                else
                {
                    outputs[i] = inputs[i];
                }

            outputs[inputs.Length - 1] = inputs[inputs.Length - 1];
            return RemoveKutriyalukaram2(outputs);
        }

        private string[] RemoveInBetweenWords(string[] inputs)
        {
            var outputs = new string[inputs.Length];
            var rx = new Regex(string.Format("({0})({1})", string.Join("|", endwith), string.Join("|", startwith)));
            var matches = new List<Match>();
            for (var i = 0; i < inputs.Length - 1; i++)
                outputs[i] = rx.Replace(inputs[i], match =>
                {
                    matches.Add(match);
                    return match.Groups[2].Value;
                });
            outputs[inputs.Length - 1] = inputs[inputs.Length - 1];
            //return outputs;
            return inputs;
        }

        private string[] RemoveKutriyalukaram2(string[] inputs)
        {
            var outputs = new string[inputs.Length];
            for (var i = 0; i < inputs.Length - 1; i++)
                if (inputs[i].EndsWith(endwith[0]) ||
                    inputs[i].EndsWith(endwith[1]) ||
                    inputs[i].EndsWith(endwith[2]) ||
                    inputs[i].EndsWith(endwith[3]) ||
                    inputs[i].EndsWith(endwith[4]) ||
                    inputs[i].EndsWith(endwith[5]))
                {
                    string data = null;
                    var enumerator = StringInfo.GetTextElementEnumerator(inputs[i + 1]);
                    while (enumerator.MoveNext())
                    {
                        data = enumerator.Current.ToString();
                        break;
                    }

                    if (data != null && data.Equals(Nextletter))
                        outputs[i] = inputs[i].Remove(inputs[i].Length - 2);
                    else outputs[i] = inputs[i];
                }
                else
                {
                    outputs[i] = inputs[i];
                }

            outputs[inputs.Length - 1] = inputs[inputs.Length - 1];
            return RemoveInBetweenWords(outputs);
        }
    }
}