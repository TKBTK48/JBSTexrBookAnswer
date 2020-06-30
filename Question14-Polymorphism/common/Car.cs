/*
 * Car.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
    public class Car
    {

        private string name;
        private int speed;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        /**
         * 設定されたスピードで走る
         */
        public void Run()
        {
            Console.WriteLine(this.name + "は時速" + this.speed + "で走った");
        }

        /**
         * 名前を取得します
         * @return	名前
         */
        public string GetName()
        {
            return name;
        }

        /**
         * 名前を設定します
         * @param name	設定したい名前
         */
        public void SetName(string name)
        {
            this.name = name;
        }

        /**
         * 速度を取得します
         * @return	速度
         */
        public int GetSpeed()
        {
            return speed;
        }

        /**
         * 速度を設定します
         * @param speed	設定したい速度
         */
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
    }
}
