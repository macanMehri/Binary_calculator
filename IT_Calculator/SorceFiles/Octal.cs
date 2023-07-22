using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Calculator.SorceFiles;

namespace IT_Calculator.SorceFiles
{
    internal class Octals
    {
        public class Octal
        {
            private List<int> number;
            public List<int> Number
            {
                get { return number; }
                set
                {
                    foreach (var item in value)
                    {
                        if (item < 0 || item > 7)
                            throw new Exception("Please enter valid values!");
                    }
                    number = value;
                }
            }

            public Octal()
            {
                number = new List<int>();
            }
            public override string ToString()
            {
                string result = "";
                foreach (var item in number)
                {
                    result += Convert.ToString(item);
                }
                return result;
            }
            public void string_to_octal(string n)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] - 48 < 0 || n[i] - 48 > 7)
                        throw new Exception("Please enter valid values!");
                    result.Add(Convert.ToInt32(n[i]) - 48);
                }
                number = result;
            }
            public Bin.Binary octal_to_binary()
            {
                int temp = 0;
                Bin.Binary binary = new Bin.Binary();
                for (int j = number.Count - 1; j >= 0; j--)  
                {
                    temp = number[j];
                    for (int i = 0; i < 3; i++)
                    {
                        if (temp % 2 == 0)
                            binary.number.Add(false);
                        else if (temp % 2 == 1)
                            binary.number.Add(true);
                        temp = temp / 2;
                    }
                }

                binary.number.Reverse();
                return binary;
            }
        }
    }
}
