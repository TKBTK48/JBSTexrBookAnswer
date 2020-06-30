/*
* PTra16_04.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using common;

public class PTra16_04
{
    public static void Main(string[] args)
    {
        Console.WriteLine("整数を入力してください");

        // キーボードから入力した数値を変数 num に代入します
        int num = int.Parse(Console.ReadLine());

        /* このプログラムは入力した整数によって以下のような表示をします。
         * プラスの数を入力時　：割り算の結果はxxです
         * 　　　　　　　　　　　後処理を行います
         * ゼロを入力時　　　　：ハンドルされていない例外～　という例外メッセージ
         * マイナスの数を入力時：入力内容が誤りです
         * 　　　　　　　　　　　後処理を行います
         * 
         * TODO このプログラムを以下のように修正してください。
         * プラスの数やマイナスの数の場合は最後に「後処理を行います」が表示されますが、
         * ゼロを入力した場合は「後処理を行います」が表示されません。
         * ゼロを入力した場合も例外メッセージの後に「後処理を行います」を表示するようにしてください。
         * プラスやマイナスの数を入力した場合は修正前と修正後は同じになるようにしてください。
    	 */
        try
        {
            if (num < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Console.WriteLine("割り算の結果は" + 100 / num + "です");
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("入力内容が誤りです");
        }
        finally
        {
            Console.WriteLine("後処理を行います");
        }
    }
}