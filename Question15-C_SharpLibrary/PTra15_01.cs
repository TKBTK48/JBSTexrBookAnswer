/*
 * PTra15_01.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

public class PTra15_01
{
    public static void Main(string[] args)
    {

        /*
        * TODO 現在時刻を「YYYY年MM月DD日」形式で出力してください
        *  ※ DateTimeクラスのToStringメソッドを利用してください
        */
        DateTime date = DateTime.Now;
        Console.WriteLine(date.ToString("yyyy年MM月dd日"));
    }