/*
 * FoodUtill.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace common
{
    public class FoodUtill
    {
        /**
         * fileの中のFoodMenu.csvを読み込んで、
         * ArrayList<Food>の形に変換して返す
         * @return 料理一覧
         */
        public static List<Food> GetFoodList()
        {
            List<Food> foodList = null;
            try
            {
                foodList = new List<Food>();
                StreamReader sr = new StreamReader(@"../../../file/FoodMenu.csv");
                //末尾まで繰り返す
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    //読み込んだ行をカンマで分割
                    string[] input = line.Split(',');
                    Food food = new Food(input[0], int.Parse(input[1]));
                    foodList.Add(food);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return foodList;
        }
    }
}
