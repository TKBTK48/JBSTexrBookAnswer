/*
 * ThrowExceptionUtil.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
    /**
     * 例外を発生させるようなメソッドを集めたクラスです
     * @author rhizome
     */
    public class ThrowExceptionUtil
    {
        /**
         * メッセージを表示後、例外を発生させる
         * @param count
         */
        public static void ExceptioinMethod()
        {
            // メッセージ表示
            Console.Write("メソッドが呼び出されました。");

            // 例外発生させる
            throw new Exception();
        }
    }
}
