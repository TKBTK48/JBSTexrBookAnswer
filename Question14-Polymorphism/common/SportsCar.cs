/*
 * SportsCar.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
    public class SportsCar : Car
    {

        public SportsCar():base("スポーツカー", 100)
        {
        }
        /**
         * 設定されたスピードの3倍の速度で走る
         */
        public void Turbo()
        {
            Console.WriteLine(base.GetName() + "は時速" + (base.GetSpeed() * 3) + "で走った");
        }
    }
}
