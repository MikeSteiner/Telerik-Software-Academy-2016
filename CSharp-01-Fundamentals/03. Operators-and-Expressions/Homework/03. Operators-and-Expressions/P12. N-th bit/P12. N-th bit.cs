using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
*/
class ModifyBitsInt64
{
    long _value;

    public ModifyBitsInt64(long value)
    {
        _value = value;
    }

    public long Value
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

    private static long GenerateBitMask(int pos)
    {
        int bitMaskLeft = 0;
        int bitMaskRight = 0;

        if (pos < 32)
        {
            bitMaskRight = (1 << (int)pos);
        }
        else
        {
            bitMaskLeft = (1 << (int)(pos - 32L));
        }

        string bitMaskStr = Convert.ToString(bitMaskLeft, 2).PadLeft(32, '0') + Convert.ToString(bitMaskRight, 2).PadLeft(32, '0');

        return Convert.ToInt64(bitMaskStr, 2);
    }

    public bool GetBitValue(int pos)
    {
        long bitMask = GenerateBitMask(pos);
        bool bitValue = false;
        if ((_value & bitMask) != 0)
        {
            bitValue = true;
        }

        return bitValue;
    }

    public void SetBitValue(int pos, bool setValue)
    {
        long bitMask = GenerateBitMask(pos);

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

class NthBit
{
    static void Main(string[] args)
    {
        long value = long.Parse(Console.ReadLine());
        long bitPos = long.Parse(Console.ReadLine());
        ModifyBitsInt64 N = new ModifyBitsInt64(value);

        bool bitVal = N.GetBitValue(Convert.ToInt32(bitPos));
        Console.WriteLine("{0}", Convert.ToInt32(bitVal));
        /*
        int bitMaskLeft = 0;
        int bitMaskRight = 0;

        if (bitPos < 32) {
            bitMaskRight = (1 << (int)bitPos);
        }
        else
        {
            bitMaskLeft = (1 << (int)(bitPos-32L));
        }

        string bitMaskStr = Convert.ToString(bitMaskLeft, 2).PadLeft(32, '0') + Convert.ToString(bitMaskRight, 2).PadLeft(32, '0');
        long bitMask = Convert.ToInt64(bitMaskStr,2);
        //(1 << bitPos);
        //Console.WriteLine(Convert.ToString(value, 2).PadLeft(64,'0'));
        //Console.WriteLine(Convert.ToString(bitMaskRight, 2).PadLeft(32,'0'));
        //Console.WriteLine(Convert.ToString(bitMaskLeft, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(bitMask, 2).PadLeft(64,'0'));
        //Console.WriteLine(value & bitMask);

        bool bitValue = false;
        if ((value & bitMask) != 0)
        {
            bitValue = true;
        }
        
        Console.WriteLine("{0}", Convert.ToInt64(bitValue));
        */
    }
}

