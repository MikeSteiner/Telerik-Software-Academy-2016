using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5.Bits_to_Bits
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

    class BitsToBits
    {
        static void Main(string[] args)
        {
            //const int mostRightNbits = 30;
            int N = int.Parse(Console.ReadLine());

            //fill out input array
            int[] nums = new int[N];
            //fill out input array
            for (int i = 0; i < N; i++)
            {
                string inLine = Console.ReadLine();
                nums[i] = int.Parse(inLine);
            }

            ModifyBitsU modBits;// = new ModifyBitsU();
            int[] longestSeqOfOnes = new int[N];
            int[] longestSeqOfZeroes = new int[N];
            int currentLongestSeqOfOnes = 0;
            int currentLongestSeqOfZeroes = 0;
            bool? prevBitValue = null;
            // 0 to N value

            for (int J = 0; J < N; J++)
            {
                //int currentNum = 0;
                //if (J == 0)
                //{
                //    currentNum = nums[J];
                //}
                //else
                //{

                //}  
                int currentNum = nums[J];
                modBits = new ModifyBitsU((ulong)currentNum);                
                //0 to 30 bits                
                for (int i = 29; i >= 0; i--)
                {
                    
                    bool currentBitValue = modBits.GetBitValue(i);
                    //Check previous value
                    if (!prevBitValue.HasValue)
                    {
                        if (currentBitValue)
                        {
                            currentLongestSeqOfOnes++;
                            currentLongestSeqOfZeroes = 0;
                        }
                        else
                        {
                            currentLongestSeqOfOnes = 0;
                            currentLongestSeqOfZeroes++;
                        }
                    }
                    else
                    {
                        //Once sequence continues
                        if ((currentBitValue == true) && prevBitValue == true)
                        {
                            currentLongestSeqOfOnes++;
                        }
                        //Zeroes sequence continues
                        else if ((currentBitValue == false) && prevBitValue == false)
                        {
                            currentLongestSeqOfZeroes++;
                        }
                        //End of Zero sequence
                        else if (currentBitValue == true && prevBitValue == false)
                        {
                            //longestSeqOfZeroes[0] = currentLongestSeqOfZeroes;
                            currentLongestSeqOfZeroes = 0;
                            currentLongestSeqOfOnes++;
                        }
                        //End of Once sequence
                        else if (currentBitValue == false && prevBitValue == true)
                        {
                            //longestSeqOfOnes[0] = currentLongestSeqOfOnes;
                            currentLongestSeqOfOnes = 0;
                            currentLongestSeqOfZeroes++;
                        }
                    
                    }
                    //Assign current longest once nad zeroes to the memory
                    if (currentLongestSeqOfOnes > longestSeqOfOnes[0])
                    {
                        longestSeqOfOnes[0] = currentLongestSeqOfOnes;
                    }
                    if (currentLongestSeqOfZeroes > longestSeqOfZeroes[0])
                    {
                        longestSeqOfZeroes[0] = currentLongestSeqOfZeroes;
                    }
                    //Get previous value
                    prevBitValue = currentBitValue;
                }
            }
            //Console.WriteLine("Longes Zeroes: {0}", string.Join(", ", longestSeqOfZeroes));
            //Console.WriteLine("Longes Once: {0}", string.Join(", ", longestSeqOfOnes));
            Console.WriteLine("{0}", longestSeqOfZeroes[0].ToString());
            Console.WriteLine("{0}", longestSeqOfOnes[0].ToString());

        }
    }
}
