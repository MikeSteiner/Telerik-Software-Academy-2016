using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

Write a program first reads 3 numbers n, p, q and k 
and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.
*/
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

class BitSwap
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        //bool[] newBitValues = new bool[27]; //bool(27);

        ModifyBitsU mBU = new ModifyBitsU(n);
        int qCoeficient = q - p;

        for (int i = p; i <= (p + k - 1); i++)
        {
            bool pBitValue = mBU.GetBitValue(i);
            bool qBitValue = mBU.GetBitValue(i+qCoeficient);
            mBU.SetBitValue(i, qBitValue);
            mBU.SetBitValue(i+qCoeficient, pBitValue);
        }

        Console.WriteLine("{0}", mBU.Value);
    }
}
