using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilNumberExtractor
{
    public class BuilNumberExtractor
    {
        public static bool isFeatureBuild(string build)
            {
            if (!System.Text.RegularExpressions.Regex.IsMatch(build, "\\d{1}.\\d{2}.\\d{4}"))
                throw new ArgumentException("String does not contain correct build number!");
            return System.Text.RegularExpressions.Regex.IsMatch(build, "\\d{1}.\\d{2}.\\d{4}.\\d{4}");
            }

        public static KeyValuePair<int,int> INcr()
            {
            int i = 3;
            int R =++i;
            return new KeyValuePair<int, int>(i, R);
            }
    }
}
