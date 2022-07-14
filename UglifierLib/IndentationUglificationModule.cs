using System;
using System.Collections.Generic;
using System.Linq;

namespace UglifierLib
{
    public class IndentationUglificationModule : UglificationModule
    {
        private static readonly Random _random = new Random();
        public override string Uglify(string code, object arg1)
        {
            IndentationUglificationMode mode = (IndentationUglificationMode)arg1;
            List<string> output = new List<string>();
            
            string[] lines = code.Split('\n')
                                 .Select(l => l.Replace("\r", "").TrimStart())
                                 .ToArray();

            if (mode == IndentationUglificationMode.NoIndentation) return string.Join("\r\n", lines);
            
            int index = 0;
            int max = lines.Max(l => l.Length);
            foreach (string line in lines)
            {
                switch (mode)
                {
                    case IndentationUglificationMode.LineNumberAmountOfSpace:
                        output.Add(new string(' ', index + 1) + line);
                        break;
                    case IndentationUglificationMode.LineNumberAmountOfSpaceInverted:
                        output.Add(new string(' ', lines.Length - 1 - index) + line);
                        break;
                    case IndentationUglificationMode.RandomIndentation:
                        int randomNumber = _random.Next(1, max);
                        output.Add(new string(' ', randomNumber) + line);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
                }

                index++;
            }

            return string.Join("\r\n", output);
        }
    }
}