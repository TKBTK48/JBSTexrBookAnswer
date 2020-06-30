/*
* PTra18_02.cs
*   作成	Rhizome
*------------------------------------------------------------
* Copyright(c) Rhizome Inc. All Rights Reserved.
*/

using System;
using System.Collections.Generic;
using common;

public class PTra18_02
{
    public static void Main(string[] args)
    {
        // TODO Player型を格納するListを変数名 playerList で作成してください。
        List<Player> playerList = new List<Player>();

        /*
      	 * TODO 以下の情報を持つインスンタンスを3つ作成してください
      	 *
      	 * -------1人目---------
      	 * ポジション：MF
      	 * 名前		：佐川真司
      	 * 国		：日本
      	 * 所属チーム：ドルトムント
      	 *
      	 * -------2人目---------
      	 * ポジション：DF
      	 * 名前		：永元佑都
      	 * 国		：日本
      	 * 所属チーム：インテル
      	 *
      	 * -------3人目---------
      	 * ポジション：MF
      	 * 名前		：本田健佑
      	 * 国		：日本
      	 * 所属チーム：ACミラン
      	 */
        Player player1 = new Player("MF", "佐川真司", "日本", "ドルトムント");
        Player player2 = new Player("DF", "永元佑都", "日本", "インテル");
        Player player3 = new Player("MF", "本田健佑", "日本", "ACミラン");

        // TODO 作成したインスタンスを全てplayerListに追加してください
        playerList.Add(player1);
        playerList.Add(player2);
        playerList.Add(player3);

        /*
      	 * TODO playerListの情報を全て出力してください。(foreach文を使用する事)
      	 *
      	 * ※ 以下のように標示されれば正解
      	 * MF,佐川真司,日本,ドルトムント
    	 * DF,永元佑都,日本,インテル
         * MF,本田健佑,日本,ACミラン
      	 */
        foreach (Player player in playerList)
        {
            Console.WriteLine(player.ToString());
        }
    }
}