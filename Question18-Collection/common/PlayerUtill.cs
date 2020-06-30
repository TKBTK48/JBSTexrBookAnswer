/*
 * PlayerUtill.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace common
{
    public class PlayerUtill
    {
        /**
         * fileの中のBestElevenCandidate.csvを読み込んで、
         * ArrayList<Player>の形に変換して返す
         * @return サッカー選手一覧
         */
        public static List<Player> GetPlayerList()
        {
            List<Player> playerList = null;
            try
            {
                playerList = new List<Player>();
                StreamReader sr = new StreamReader(@"../../../file/BestElevenCandidate.csv");
                //末尾まで繰り返す
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    //読み込んだ行をカンマで分割
                    string[] input = line.Split(',');
                    Player player = new Player(input[0], input[1], input[2], input[3]);
                    playerList.Add(player);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return playerList;
        }
    }
}
