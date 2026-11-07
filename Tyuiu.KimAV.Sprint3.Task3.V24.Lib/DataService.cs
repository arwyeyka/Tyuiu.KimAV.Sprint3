using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KimAV.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string str = value;
            foreach (char c in str)
            {
                if (c == replaceable)
                {
                    str = str.Replace(replaceable, replacement);
                }
            }
            return str;
        }
    }
}

