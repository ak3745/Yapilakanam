using System.Collections.Generic;

namespace YapilakanamProcessor
{
    public class LexicalTable
    {
        public List<string> ComputeSmooth(IEnumerable<string> shak)
        {
            var result = new List<string>();
            foreach (var data in shak)
            {
                if (data.Equals("நேர்")) result.Add("நாள்");
                if (data.Equals("நிரை")) result.Add("மலர் ");
                if (data.Equals("நேர்நேர்")) result.Add("தேமா");
                if (data.Equals("நிரைநேர்")) result.Add("புளிமா");
                if (data.Equals("நிரைநிரை")) result.Add("கருவிளம்");
                if (data.Equals("நேர்நிரை")) result.Add("கூவிளம்");
                if (data.Equals("நேர்நேர்நேர்")) result.Add("தேமாங்காய்");
                if (data.Equals("நேர்நேர்நிரை")) result.Add("தேமாங்கனி");
                if (data.Equals("நிரைநேர்நேர்")) result.Add("புளிமாங்காய்");
                if (data.Equals("நிரைநேர்நிரை")) result.Add("புளிமாங்கனி");
                if (data.Equals("நிரைநிரைநேர்")) result.Add("கருவிளங்காய்");
                if (data.Equals("நிரைநிரைநிரை")) result.Add("கருவிளங்கனி");
                if (data.Equals("நேர்நிரைநேர்")) result.Add("கூவிளங்காய்");
                if (data.Equals("நேர்நிரைநிரை")) result.Add("கூவிளங்கனி");
                if (data.Equals("நேர்நேர்நேர்நேர்")) result.Add("தேமாந்தண்பூ");
                if (data.Equals("நேர்நேர்நேர்நிரை")) result.Add("தேமாந்தண்ணிழல்");
                if (data.Equals("நேர்நேர்நிரைநேர்")) result.Add("தேமாநறும்பூ");
                if (data.Equals("நேர்நேர்நிரைநிரை")) result.Add("தேமாநறுநிழல்");
                if (data.Equals("நிரைநேர்நேர்நேர்")) result.Add("புளிமாந்தண்பூ");
                if (data.Equals("நிரைநேர்நேர்நிரை")) result.Add("புளிமாந்தண்ணிழல்");
                if (data.Equals("நிரைநேர்நிரைநேர்")) result.Add("புளிமாநறும்பூ");
                if (data.Equals("நிரைநேர்நிரைநிரை")) result.Add("புளிமாநறுநிழல்");
                if (data.Equals("நேர்நிரைநேர்நேர்")) result.Add("கூவிளந்தண்பூ");
                if (data.Equals("நேர்நிரைநேர்நிரை")) result.Add("கூவிளந்தண்ணிழல்");
                if (data.Equals("நேர்நிரைநிரைநேர்")) result.Add("கூவிளநறும்பூ");
                if (data.Equals("நேர்நிரைநிரைநிரை")) result.Add("கூவிளநறுநிழல்");
                if (data.Equals("நிரைநிரைநேர்நேர்")) result.Add("கருவிளந்தண்பூ");
                if (data.Equals("நிரைநிரைநேர்நிரை")) result.Add("கருவிளந்தண்ணிழல்");
                if (data.Equals("நிரைநிரைநிரைநேர்")) result.Add("கருவிளநறும்பூ");
                if (data.Equals("நிரைநிரைநிரைநிரை")) result.Add("கருவிளநறுநிழல்");
            }

            return result;
        }
    }
}