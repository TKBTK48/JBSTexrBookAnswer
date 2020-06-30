/*
* PTra16_03.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;

public class PTra16_03
{
    public static void Main(string[] args)
    {
        try
        {
            /*
      		 * TODO
      		 * FormatExceptionが発生 が表示されるように、
      		 * 以下の処理を書き換えてください
      		 */
            throw new FormatException();
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("NullReferenceExceptionが発生");
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatExceptionが発生");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exceptionが発生");
        }
    }
}