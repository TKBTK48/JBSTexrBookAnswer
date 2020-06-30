/*
* PTra15_02.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;

public class PTra15_02
{
    public static void Main(string[] args)
    {
        // TODO このプログラムを変更せずに「同じ金額です」を出力してください
        // ※SpecialIntegerクラスを修正してください

        string expected = "99999";
        SpecialInteger sInt = new SpecialInteger("\\99,999");

        if (sInt.Equals(expected))
        {
            Console.WriteLine("同じ金額です");
        }
        else
        {
            Console.WriteLine("金額が違います");
        }
    }
}