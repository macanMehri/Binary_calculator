using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Calculator.SorceFiles
{
    internal class Bin
    {
        public class Binary
        {
            public List<bool> number;

            public Binary()
            {
                number = new List<bool>();
            }

            public void string_to_binary(string n)
            {
                List<bool> result = new List<bool>();
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == '0')
                        result.Add(false);
                    else if (n[i] == '1')
                        result.Add(true);
                    else
                        throw new Exception("Please enter valid values");
                }
                number = result;
            }
            public override string ToString()
            {
                string result = "";
                for (int i = 0; i < number.Count; i++)
                {
                    if (number[i] == true)
                        result += '1';
                    else if (number[i] == false)
                        result += '0';
                    else
                        throw new Exception("Please enter valid values");
                }
                return result;
            }
            public void bit_wise()
            {
                for (int i = 0; i < number.Count; i++)
                {
                    if (number[i] == true)
                        number[i] = false;
                    else if (number[i] == false)
                        number[i] = true;
                    else
                        throw new Exception("Please enter valid values");
                }
            }

            public Binary binary_adder(Binary x)
            {
                bool carry = false;
                Binary result = new Binary();


                if (number.Count > x.number.Count)
                    x.add_useless_bit(number.Count - x.number.Count);
                else if (number.Count < x.number.Count)
                    add_useless_bit(x.number.Count - number.Count);


                for (int i = number.Count - 1; i >= 0; i--)
                {
                    if (x.number[i] == true && number[i] == true && carry == true)
                    {
                        result.number.Add(true);
                        carry = true;
                    }
                    else if ((x.number[i] == true && number[i] == true && carry == false) || (x.number[i] == true && number[i] == false && carry == true) || (x.number[i] == false && number[i] == true && carry == true))
                    {
                        result.number.Add(false);
                        carry = true;
                    }
                    else if ((x.number[i] == true && number[i] == false && carry == false) || (x.number[i] == false && number[i] == true && carry == false) || (x.number[i] == false && number[i] == false && carry == true))
                    {
                        result.number.Add(true);
                        carry = false;
                    }
                    else if (x.number[i] == false && number[i] == false && carry == false)
                    {
                        result.number.Add(false);
                        carry = false;
                    }
                }
                if (carry == true)
                    result.number.Add(true);

                result.number.Reverse();
                return result;
            }
            public void add_useless_bit(int count)
            {
                for (int i = 0; i < count; i++)
                {
                    number.Insert(i, false);
                }
            }

            public Binary twos_complement()
            {
                Binary temp = new Binary();
                temp.number.Add(true);

                bit_wise();
                temp = binary_adder(temp);
                return temp;
            }
            // PROBLEM!!!
            public Binary sub(Binary x)
            {
                x.add_useless_bit(number.Count - x.number.Count);
                x = x.twos_complement();
                return binary_adder(x);
            }

            public Octals.Octal binary_to_octal()
            {
                Octals.Octal octal = new Octals.Octal();
                int result = 0;

                for (int i = number.Count - 1; i >= 0; i--)    
                {
                    if (number[i] == true)
                        result += tavan(2, number.Count - 1 - i);
                }
                while (result > 0)
                {
                    octal.Number.Add(result % 8);
                    result /= 8;
                }
                octal.Number.Reverse();
                return octal;
            }

            public Dec.Decimal binary_to_decimal()
            {
                Dec.Decimal _decimal = new Dec.Decimal();
                int result = 0;
                int num_count = 0;

                for (int i = number.Count - 1; i >= 0; i--)
                {
                    if (number[i] == true)
                    {
                        result += tavan(2, number.Count - 1 - i);
                        num_count++;
                    }
                }

                while (result > 0)
                {
                    _decimal.number.Add(result % 10);
                    result /= 10;
                }

                _decimal.number.Reverse();
                return _decimal;
            }


            public int tavan(int number, int tavan)
            {
                int result = 1;
                for (int i = 0; i < tavan; i++) 
                {
                    result *= number;
                }
                return result;
            }

        }

    }
}
