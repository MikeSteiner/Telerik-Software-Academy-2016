using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    We are given an integer number N(read from the console), a bit value v(read from the console as well) (v = 0 or 1) and a position P(read from the console). 
    Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. 
    Print the resulting number on the console.
*/
class ModifyBitsInt
{
    int _value;

    public ModifyBitsInt(int value)
    {
        _value = value;
    }

    public int Value
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
        int bitMask = (1 << pos);
        bool bitValue = false;
        if ((_value & bitMask) != 0)
        {
            bitValue = true;
        }

        return bitValue;
    }

    public void SetBitValue(int pos, bool setValue)
    {
        int bitMask = (1 << pos);

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

class ModifyBit
{
    static void Main(string[] args)
    {        
        int value = int.Parse(Console.ReadLine());        
        int bitPos = int.Parse(Console.ReadLine());
        int newBitValue = int.Parse(Console.ReadLine());

        ModifyBitsInt enteredValue = new ModifyBitsInt(value);

        bool bV = enteredValue.GetBitValue(bitPos);
        enteredValue.SetBitValue(bitPos, Convert.ToBoolean(newBitValue));
                
        Console.WriteLine("{0}", enteredValue.Value);
        

        /*
        int value = int.Parse(Console.ReadLine());
        int bitPos = int.Parse(Console.ReadLine());
        int newBitValue = int.Parse(Console.ReadLine());

        int bitMask = (1 << bitPos);
        
        //Console.WriteLine(Convert.ToString(value, 2).PadLeft(64,'0'));
        //Console.WriteLine(Convert.ToString(bitMaskRight, 2).PadLeft(32,'0'));
        //Console.WriteLine(Convert.ToString(bitMaskLeft, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(bitMask, 2).PadLeft(32,'0'));        

        int newValue = 0;

        if (newBitValue == 1)
        {
            newValue = value | bitMask;
        }
        else
        {
            bitMask = ~bitMask;
            newValue = value & bitMask;
        }
        //Console.WriteLine(Convert.ToString(bitMask, 2).PadLeft(32, '0'));

        Console.WriteLine("{0}", Convert.ToInt64(newValue));
        */
    }
}

