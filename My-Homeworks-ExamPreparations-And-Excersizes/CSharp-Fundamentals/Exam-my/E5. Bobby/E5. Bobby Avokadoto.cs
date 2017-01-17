using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5.Bobby_Avokadoto
{
    class ModifyBitsU
    {
        ulong _value;

        public ModifyBitsU(ulong value)
        {
            _value = value;
        }

        public ulong Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }


        public bool GetBitValue(int pos)
        {
            ulong bitMask = (1UL << pos);// (1 << pos);
            bool bitValue = false;
            if ((_value & bitMask) != 0)
            {
                bitValue = true;
            }

            return bitValue;
        }

        public void SetBitValue(int pos, bool setValue)
        {
            ulong bitMask = (1UL << pos);

            if (setValue)
            {
                _value = _value | bitMask;
            }
            else
            {
                bitMask = ~bitMask;
                _value = _value & bitMask;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int hair = int.Parse(Console.ReadLine());
            int combsCout = int.Parse(Console.ReadLine());
            if (hair < 0)
            {
                hair = hair * -1;
            }
            int maxxx = 0;
            string hStr = Convert.ToString(hair, 2);
            //ModifyBitsU mbuHair = new ModifyBitsU((ulong)hair);

            int maxComb = 0;

            for (int i = 0; i < combsCout; i++)
            {
                

                int currentComb = int.Parse(Console.ReadLine());                
                if (currentComb < 0)
                {
                    currentComb = currentComb * -1;
                }
                string ccStr = Convert.ToString(currentComb, 2);

                //Compare bits
                //ModifyBitsU mbuCurrentComb = new ModifyBitsU((ulong)currentComb);
                bool combCantBeUsed = false;

                int maxLenght = Math.Max(ccStr.Length, hStr.Length);
                int minLenght = Math.Min(ccStr.Length, hStr.Length);
                //if (hair / currentComb > 0.0d)
                //{
                int counter = 0;
                for (int bit = 0; bit < minLenght; bit++)
                    {
                        //combCantBeUsed = mbuHair.GetBitValue(bit) && mbuCurrentComb.GetBitValue(bit);
                        //bool isOne = ((1 << bit) & N) > 0;
                        combCantBeUsed = (((1 << bit) & hair) > 0) && (((1 << bit) & currentComb) > 0);
                    counter++;
                        if (combCantBeUsed)
                        {
                            break;
                        }
                    }
                //}
                

                //Get max comb                
                if (!combCantBeUsed)
                {
                    if(counter > maxComb)
                    {
                        maxComb = counter;
                        maxxx = currentComb;
                    }
                }
            }
            Console.WriteLine(maxxx);
        }
    }
}
