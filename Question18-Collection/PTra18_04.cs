/*
* PTra18_04.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using System.Collections.Generic;
using common;

public class PTra18_04
{
    public static void Main(string[] args)
    {
        // TODO PlayerUtillクラスのGetPlayerListメソッドを使用して選手のリストを取得してください
        List<Player> playerList = PlayerUtill.GetPlayerList();

        // TODO 選手のリストから、レアル・マドリード と バルセロナの選手を除外してください
        for (int i = playerList.Count - 1; i >= 0; i--)
        {

            if (
                playerList[i].GetTeam() == "レアル・マドリード" ||
                playerList[i].GetTeam() == "バルセロナ")
            {

                // 配列の先頭から削除を行うとiの数値がずれるため、一番後ろから繰り返し行う
                playerList.RemoveAt(i);
            }
        }

        // TODO 選手のリストをすべて出力してください
        foreach (Player player in playerList)
        {
            Console.WriteLine(player.ToString());
        }
    }
}