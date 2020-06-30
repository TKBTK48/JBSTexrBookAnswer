/*
 * Food.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;

namespace common
{
    public class Food
    {
        // 名前
        internal string name;

        // 値段
        internal int price;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetPrice()
        {
            return price;
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }

        public Food(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
