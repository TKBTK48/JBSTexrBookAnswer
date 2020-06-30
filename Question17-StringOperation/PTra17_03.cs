/*
* PTra18_03.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;

public class PTra18_03
{
    public static void Main(string[] args)
    {
        string str = "りんご,みかん,いちご,ぶどう";

        // TODO strクラスの文字をカンマで区切って配列に変換してください
        string[] fruitList = str.Split(',');

        // TODO 配列の中の文字列を全て出力して下さい
        // ※ りんご
        //    みかん
        //    いちご
        //    ぶどう と出力されれば正解
        foreach (string f in fruitList)
        {
            Console.WriteLine(f);
        }
    }
}