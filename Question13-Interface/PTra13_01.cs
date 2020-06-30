/*
* PTra13_01.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using common;

class PTra13_01
{
	public static void Main(string[] args)
	{
		// TODO commonのCSharpBasicBookクラスをインスンタンス化してください
		CSharpBasicBook cBook = new CSharpBasicBook();

		// TODO インスタンスから本のタイトルを取得して出力してください
		Console.WriteLine(cBook.GetBookTitle());

		// TODO インスタンスから章立てのリストを取得して出力してください
		String[] epList = cBook.GetEpisodeList();

		foreach (string ep in epList)
		{
			Console.WriteLine(ep);
		}
	}
}