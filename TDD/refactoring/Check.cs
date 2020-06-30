/*
 * Check.cs
 *   作成	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;
using System.Linq;

namespace refactoring
{
    /**
     * 入力された値をカスタマイズ・入力チェックを行うクラスです。
     * 現状で単体テストが通りますので、テスト結果が変わらないようリファクタリングして下さい。
     * @author IT-College
     *
     */
    public static class Check
    {

        public static void Main(string[] args)
        {
            // nothing
        }
        /**
         * 文字列を、大文字に変換して逆順に並び替えるメソッド
         */
        public static string ToReverseString(string value)
        {
            return string.Join("", value.Reverse()).ToUpper();
        }
    }
}
