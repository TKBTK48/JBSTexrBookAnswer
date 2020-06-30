/*
* PTra18_01.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using System.Collections.Generic;

public class PTra18_01
{
    public static void Main(string[] args)
    {
        // TODO string型を格納するListを変数名 animals で作成してください。
        List<string> animals = new List<string>();

        /*
      	 * TODO animalsに以下の文字列を追加してください
      	 * ・いぬ
      	 * ・ねこ
      	 * ・うさぎ
      	 * ・たぬき
      	 */
        animals.Add("いぬ");
        animals.Add("ねこ");
        animals.Add("うさぎ");
        animals.Add("たぬき");

        // TODO animalsの中身を全て出力してください(foreach文を使用する事)
        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}