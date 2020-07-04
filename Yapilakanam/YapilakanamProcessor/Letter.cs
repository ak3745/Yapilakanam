namespace YapilakanamProcessor
{
    internal class Letter
    {
        internal readonly string[] Kuril;
        internal readonly string[] Naedil;
        internal readonly string[] Otru = new string[19];
        internal readonly string[] Uyirkuril = new string[90];
        internal readonly string[] Uyirnaedil = new string[126];

        public Letter()
        {
            string[] tamilvowel =
            {
                "  ", "\u0b85", "\u0b86", "\u0b87", "\u0b88", "\u0b89", "\u0b8A", "\u0b8E",
                "\u0b8F", "\u0b90", "\u0b92", "\u0b93", "\u0b94", "\u0b83"
            };
            string[] tamilvowelsound =
            {
                string.Empty, string.Empty, "\u0bbe", "\u0bbf", "\u0bc0", "\u0bc1", "\u0bc2",
                "\u0bc6", "\u0bc7", "\u0bc8", "\u0bca", "\u0bcb", "\u0bcc", "\u0bcd"
            };
            string[] tamilConsonant =
            {
                string.Empty,
                "\u0b95", "\u0b99", "\u0b9a", "\u0b9e", "\u0b9f", "\u0ba3",
                "\u0ba4", "\u0ba8", "\u0bAA", "\u0bAE", "\u0baf", "\u0bb0",
                "\u0bb2", "\u0bb5", "\u0bb4", "\u0bb3", "\u0bb1", "\u0ba9",
                "\u0bb7", "\u0bb8", "\u0bb9"
            };

            Kuril = new[] {tamilvowel[1], tamilvowel[3], tamilvowel[5], tamilvowel[7], tamilvowel[10]};
            Naedil = new[]
            {
                tamilvowel[2], tamilvowel[4], tamilvowel[6], tamilvowel[8], tamilvowel[9], tamilvowel[11],
                tamilvowel[12]
            };
            for (var i = 1; i <= 18; i++)
                Otru[i - 1] = tamilConsonant[i] + "\u0bcd";
            Otru[18] = tamilvowel[13];
            //
            var k = 0;
            for (var i = 1; i <= 18; i++)
            {
                Uyirkuril[k] = tamilConsonant[i];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirkuril[k] = tamilConsonant[i] + tamilvowelsound[3];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirkuril[k] = tamilConsonant[i] + tamilvowelsound[5];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirkuril[k] = tamilConsonant[i] + tamilvowelsound[7];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirkuril[k] = tamilConsonant[i] + tamilvowelsound[10];
                k++;
            }

            //
            k = 0;
            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[2];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[4];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[6];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[8];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[9];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[11];
                k++;
            }

            for (var i = 1; i <= 18; i++)
            {
                Uyirnaedil[k] = tamilConsonant[i] + tamilvowelsound[12];
                k++;
            }
        }
    }
}