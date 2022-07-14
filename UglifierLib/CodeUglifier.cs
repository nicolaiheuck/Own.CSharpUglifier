using System.Collections.Generic;

namespace UglifierLib
{
    public class CodeUglifier
    {
        private readonly List<UglificationModule> _uglificationModules;
        public CodeUglifier()
        {
            _uglificationModules = new List<UglificationModule>()
            {
                new IndentationUglificationModule()
            };
        }
        public string UglifyCode(string code, params object[] args)
        {
            int c = 0;
            foreach (UglificationModule module in _uglificationModules)
            {
                code = module.Uglify(code, args[c]);
                c++;
            }

            return code;
        }
    }
}