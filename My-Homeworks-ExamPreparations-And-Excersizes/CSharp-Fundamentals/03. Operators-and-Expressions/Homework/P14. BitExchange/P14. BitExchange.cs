using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Description

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).
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

class BitExchange
{
    static void Main(string[] args)
    {       
        ulong value = ulong.Parse(Console.ReadLine());
        bool[] newBitValues = new bool[27]; //bool(27);

        ModifyBitsU mBU = new ModifyBitsU(value);

        newBitValues[24] = mBU.GetBitValue(3);
        newBitValues[25] = mBU.GetBitValue(4);
        newBitValues[26] = mBU.GetBitValue(5);

        newBitValues[3] = mBU.GetBitValue(24);
        newBitValues[4] = mBU.GetBitValue(25);
        newBitValues[5] = mBU.GetBitValue(26);

        for (int i = 3; i<=5; i++)
        {
            mBU.SetBitValue(i, newBitValues[i]);
            mBU.SetBitValue(i+21, newBitValues[i+21]);
        }

        Console.WriteLine(mBU.Value);
        
    }
}

