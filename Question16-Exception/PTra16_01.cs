/*
* PTra16_01.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;

public class PTra16_01
{
    public static void Main(string[] args)
    {
        string str = null;

        /*
    	 * TODO このプログラムを実行するとNullReferenceExceptionが発生します。
    	 * 例外処理を行なって、例外処理が発生しました と表示されるようにプログラムを変更してください
    	 */
        try
        {
            string[] list = str.Split(',');
        }
        catch (Exception e)
        {
            Console.WriteLine("例外処理が発生しました");
        }
    }
}