/*
* PTra14_03.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using common;

//※ この問題はcommonのクラスを利用して実行します
public class PTra14_03
{
    public static void Main(string[] args)
    {
        Car car = new SportsCar();

        // TODO キャストを利用してSportsCarクラスに car 変数を代入してください。
        SportsCar sCar = (SportsCar)car;

        // TODO Turboメソッドを実行してください。
        // ※ スポーツカーは時速300で走った と表示されれば正解
        sCar.Turbo();
    }
}