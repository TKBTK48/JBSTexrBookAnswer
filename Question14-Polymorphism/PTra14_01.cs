/*
* PTra14_01.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using common;
//※ この問題はcommonのクラスを利用して実行します
public class PTra14_01
{
    public static void Main(string[] args)
    {
        // TODO SportsCar型のインスタンスをCar型の変数に代入してください
        Car sCar = new SportsCar();

        // TODO 作成したインスタンスのRunメソッドを実行してください。
        // ※ スポーツカーは時速100で走った と表示されれば正解
        sCar.Run();

        // TODO Truck型のインスタンスをCar型の変数に代入してください
        Car truck = new Truck();

        // TODO 作成したインスタンスのRunメソッドを実行してください。
        // ※ トラックは時速30で走った
        truck.Run();

    }
}