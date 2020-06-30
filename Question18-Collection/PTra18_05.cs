
/*
 * PTra18_05.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using common;

public class PTra18_05
{
    public static void Main(string[] args)
    {
        // TODO FoodUtillクラスのGetFoodListメソッドを使用して料理一覧を取得してください
        List<Food> foodList = FoodUtill.GetFoodList();

        /*
      	 * TODO 料理一覧の中からランダムに3品選んで、
      	 * 選んだ料理名3つと合計の値段を出力してください。
      	 * ※ 同じ料理が2回以上表示されてはいけません
      	 * ※ 合計金額は 消費税は8%を加算して出力してください。(小数点以下切り捨て)
      	 */

        // 料理の一覧をシャッフルする
        Random rnd = new Random();
        foodList = foodList.OrderBy(a => rnd.Next(foodList.Count)).ToList();

        int totalPrice = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(foodList[i].GetName());
            totalPrice += foodList[i].GetPrice();
        }

        Console.WriteLine("合計金額は" + (int)((totalPrice * 1.08)) + "円です。");
    }
}