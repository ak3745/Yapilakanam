using System.Globalization;

namespace YapilakanamProcessor
{
    public class KutriyalEgaram
    {
        private const string Nextletter = "யா";
        private const string Startwith = "தி";

        public string[] RemoveKutriyalikaram(string[] inputs)
        {
            var outputs = new string[inputs.Length];
            for (var i = 0; i < inputs.Length - 1; i++)
                if (inputs[i].StartsWith(Startwith))
                {
                    string data = null;
                    var enumerator = StringInfo.GetTextElementEnumerator(inputs[i]);
                    var j = 0;
                    while (enumerator.MoveNext())
                    {
                        data = enumerator.Current.ToString();
                        j++;
                        if (j != 2) continue;
                        break;
                    }

                    if (!string.IsNullOrEmpty(data) && data == Nextletter)
                        outputs[i] = inputs[i].Replace(Startwith, string.Empty);
                    else outputs[i] = inputs[i];
                }
                else
                {
                    outputs[i] = inputs[i];
                }

            outputs[inputs.Length - 1] = inputs[inputs.Length - 1];
            return outputs;
        }
    }
}