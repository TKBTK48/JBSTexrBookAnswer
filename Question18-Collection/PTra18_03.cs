/*
* PTra18_03.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using System.Collections.Generic;
using common;

public class PTra18_03
{
    public static void Main(string[] args)
    {
        // TODO PlayerUtillクラスのgetPlayerListメソッドを使用して選手のリストを取得してください
        List<Player> playerList = PlayerUtill.GetPlayerList();

        // TODO 選手のリストから、ポジションが FW の選手のみ出力してください
        foreach (Player player in playerList)
        {
            if (player.GetPosition() == "FW")
            {
                Console.WriteLine(player.ToString());
            }
        }
    }
}