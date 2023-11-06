using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp12.classes
{
    internal class Methods
    {
        public int numOfUnicodeP(string str)
        {
            string strf = str.Substring(37);
            int count = 0;

            if (strf != null)
            {
                count = Regex.Matches(strf, @"\p{P}").Count;
            }

            return count;
        }
    }
}
