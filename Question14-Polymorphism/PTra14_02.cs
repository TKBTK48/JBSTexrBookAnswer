/*
* PTra14_02.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using common;
//※ この問題はcommonのクラスを利用して実行します
public class PTra14_02
{
    public static void Main(string[] args)
    {
        // TODO SportsCar型のインスタンスをCar型の変数に代入してください
        Car sCar = new SportsCar();

        // TODO Truck型のインスタンスをCar型の変数に代入してください
        Car truck = new Truck();

        // TODO Car型の配列を作成して、上記2つのインスタンスを追加してください
        Car[] carList = { sCar, truck };

        /* TODO carListの中身を順番に取り出して、Runメソッドを実行してください。
    	 *
    	 * 以下が表示されれば正解
    	 *
    	 * スポーツカーは時速100で走った
    	 * トラックは時速30で走った
    	 */
        foreach (Car car in carList)
        {
            car.Run();
        }
    }
}