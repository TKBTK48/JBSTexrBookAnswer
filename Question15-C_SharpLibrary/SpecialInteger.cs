using System;
using System.Collections.Generic;
using System.Text;

public class SpecialInteger
{
    private string[] pattern =
    {
        ",", "\\"
    };

    private int number;

    public SpecialInteger()
    {
        this.number = 0;
    }
    public SpecialInteger(string value)
    {
        try
        {
            this.number = int.Parse(value);
        }
        catch
        {
            foreach (var tmp in pattern)
            {
                value = value.Replace(tmp, "");
            }
            try
            {
                this.number = int.Parse(value.Trim());
            }
            catch
            {
                this.number = 0;
            }
        }
    }

    private int convertToNumber(string value)
    {
        int retNumber = 0;
        foreach (var tmp in pattern)
        {
            value = value.Replace(tmp, "");
        }
        try
        {
            retNumber = int.Parse(value.Trim());
        }
        catch
        {
            // Nothing
        }
        return retNumber;
    }
}
