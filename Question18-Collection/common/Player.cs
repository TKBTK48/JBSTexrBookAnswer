/*
 * Player.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
    public class Player
    {
        /** ポジション */
        private string position;

        /** 名前 */
        private string name;

        /** 国 */
        private string country;

        /** 所属チーム */
        private string team;

        public Player()
        {

        }

        public Player(string position, string name, string country, string team)
        {
            this.position = position;
            this.name = name;
            this.country = country;
            this.team = team;
        }

        /**
         * ポジションを取得します
         * @return	ポジション
         */
        public string GetPosition()
        {
            return position;
        }
        /**
         * ポジションを設定します
         * @param position	設定したいポジション
         */
        public void SetPosition(string position)
        {
            this.position = position;
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
         * @param name
         */
        public void SetName(string name)
        {
            this.name = name;
        }

        /**
         * 国を取得します
         * @return
         */
        public string GetCountry()
        {
            return country;
        }

        /**
         * 国を設定します
         * @param country	設定したい国
         */
        public void SetCountry(string country)
        {
            this.country = country;
        }

        /**
         * 所属チームを取得します
         * @return	所属チーム
         */
        public string GetTeam()
        {
            return team;
        }

        /**
         * 所属チームを設定します
         * @param team	設定したい所属チーム
         */
        public void SetTeam(string team)
        {
            this.team = team;
        }

        public override string ToString()
        {
            const string SEP = ",";

            string str = "";
            str = this.position + SEP + this.name + SEP + this.country + SEP + this.team;

            return str;
        }
    }
}
