using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Calculator.SorceFiles
{
    internal class Dec
    {
        public class Decimal
        {
            public List<int> number;

            public Decimal()
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

            public void string_to_decimal(string n)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < n.Length; i++)
                {
                    result.Add(Convert.ToInt32(n[i]) - 48);
                }
                number = result;
            }
            public int list_to_int()
            {
                int result = 0;
                int x = 1;
                for (int i = number.Count - 1; i >= 0; i--)    
                {
                    result += number[i] * x;
                    x *= 10;
                }
                return result;
            }
            public Bin.Binary decimal_to_binary()
            {
                int temp = list_to_int();
                Bin.Binary binary = new Bin.Binary();
                
                while (temp > 0)
                {
                    if (temp % 2 == 0)
                        binary.number.Add(false);
                    else if (temp % 2 == 1)
                        binary.number.Add(true);
                    temp = temp / 2;
                }

                binary.number.Reverse();
                return binary;
            }
        }
    }
}
