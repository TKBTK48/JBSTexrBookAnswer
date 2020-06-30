/*
* PTra13_02.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using common;

//※ この問題はcommonのSportsCarクラスを完成させてから実施してください。

class PTra13_02
{
	public static void Main(string[] args)
	{
		// TODO commonのSportsCarクラスをインスンタンス化してください
		SportsCar sCar = new SportsCar();

		// TODO スポーツカーにハイオクを100リットル補充してください
		// ※ ハイオクを100リットル補充した と表示されれば正解
		sCar.Charge(100);

		// TODO スポーツカー時速100キロで走ってください。
		// ※ スポーツカーは時速100キロで走った と表示されれば正解
		sCar.Run(100);

		// TODO スポーツカー時速301キロで走ってください。
		// ※ 速度オーバーです と表示されれば正解
		sCar.Run(301);
	}
}