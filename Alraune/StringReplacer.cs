using System;
using System.Collections.Generic;
using System.Linq;


namespace Alraune
{
    class StringReplacer
    {
        private Dictionary<string, string> FontChara { get; }

        public StringReplacer()
        {
            FontChara = new Dictionary<string, string>();
        }

        public string GetModified(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            if (FontChara.Count == 0)
                return text.Replace(Environment.NewLine, "<CR>");

            return FontChara.Aggregate(text, (current, replace) => current.Replace(replace.Value, replace.Key))
                .Replace(Environment.NewLine, "<CR>");
        }

        public string GetOriginal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            if (FontChara.Count == 0)
                return text.Replace("<CR>", Environment.NewLine);

            return FontChara.Aggregate(text, (current, replace) => current.Replace(replace.Key, replace.Value))
                .Replace("<CR>", Environment.NewLine);
        }

        public (bool, string) GenerateFontMap(string file)
        {
            FontChara.Clear();
            if (System.IO.File.Exists(file))
            {
                try
                {
                    var dictionary = System.IO.File.ReadAllLines(file);
                    foreach (string line in dictionary)
                    {
                        var lineFields = line.Split('=');
                        FontChara.Add(lineFields[0], lineFields[1]);
                    }

                    return (true, string.Empty);
                }
                catch (Exception e)
                {
                    return (false, $"The dictionary is wrong, please, check the readme and fix it.\n{e.Message}");
                }
            }
            else
            {
                return (false, "File not found");
            }
        }
    }
}
