using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuilNumberExtractor
{
    public class BuilNumberExtractor
    {
        public static bool isFeatureBuild(string build)
        {
            if (!Regex.IsMatch(build, "\\D\\d{1}\\.\\d{2}\\.\\d{4}"))
                throw new ArgumentException("String does not contain correct build number!");
            return Regex.IsMatch(build, "\\d{1}\\.\\d{2}\\.\\d{4}\\.\\d{4}");
        }

        public static KeyValuePair<int, int> INcr()
        {
            int i = 3;
            int R = ++i;
            return new KeyValuePair<int, int>(i, R);
        }

        public static int[] Extract(string build) //Test5.10.0161-Cluster123.xml asd
        {
            var r = Regex.Match(build, "(?'version'\\d{1})\\.(?'subversion'\\d{2})\\.(?'build'\\d{4})\\.(?'subbuild'\\d{4})|(?'version'\\d{1})\\.(?'subversion'\\d{2})\\.(?'build'\\d{4})");

            int version = int.Parse(r.Groups[1].Value);//5
            int subversion = int.Parse(r.Groups[2].Value);//10
            int buildN = int.Parse(r.Groups[3].Value);//161
            var FBuild = r.Groups[4].Value;

            if (string.IsNullOrEmpty(FBuild)) return new int[] { version, subversion, buildN };
            else return new int[] { version, subversion, buildN, int.Parse(FBuild) };
        }

    }
}
