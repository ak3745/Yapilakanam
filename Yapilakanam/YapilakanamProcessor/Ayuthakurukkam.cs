namespace YapilakanamProcessor
{
    public class Ayuthakurukkam
    {
        public string[] RemoveAyuthakurukkam(string[] inputs)
        {
            var outputs = new string[inputs.Length];
            for (var i = 0; i < inputs.Length - 1; i++)
                if (inputs[i].Contains("அஃ"))
                    outputs[i] = inputs[i].Replace("அஃது", "அது");
                else
                    outputs[i] = inputs[i];
            outputs[inputs.Length - 1] = inputs[inputs.Length - 1];
            return outputs;
        }
    }
}