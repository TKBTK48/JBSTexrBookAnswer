/*
 * Check.cs
 *   作成	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;

namespace refactoring
{
    /**
     * 入力された値をカスタマイズ・入力チェックを行うクラスです。
     * 現状で単体テストが通りますので、テスト結果が変わらないようリファクタリングして下さい。
     * @author IT-College
     *
     */
    public class Check
    {
        public static void Main(string[] args)
        {
            // nothing
            //動作確認
            //string a;
            //Console.WriteLine("入力してください。");
            //a = Console.ReadLine();
            //ToReverseString(a);
        }
        /**
         * 文字列を、大文字に変換して逆順に並び替えるメソッド
         */
        public static string ToReverseString(string value)  //toReserveString → TOReserveStringに変更
        {
            try
            {
                char[] words_ary = value.ToCharArray();  //a → words_aryに変更
                string str = "";                         //b → strに変更
                int num;                                 //c → numに変更
                System.Collections.Generic.List<int> new_words_list = new System.Collections.Generic.List<int>(); //d → new_words_listに変更
                bool Flg = true;                         //e → Flgに変更
                while(Flg) 
                {
                    for (int f = 0; f < words_ary.Length; f++)
                    {
                        num = words_ary[f];
                        if (97 <= num && num < 122)
                            num = num - 32;
                        new_words_list.Add(num);
                    }
                    Flg = false;
                }
                num = 0;
                try
                {
                    while (true)
                    {
                        string str2 = str;                 // String → stringに変更, f → str2 に変更
                        str2 = str + Convert.ToString((char)((int)new_words_list[new_words_list.Count - 1 - num]));
                        if (num < new_words_list.Count)
                            str2 += ",";
                            num++;
                        str = str2.Substring(0, str2.Length - 1);
                    }
                } 
                catch (System.Exception g)
                {
                }
                return str;
            }
            catch (System.Exception e)
            {
                return "";
            }
        }
    }
}
