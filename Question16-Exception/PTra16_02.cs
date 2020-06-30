
/*
 * PTra16_02.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;
using common;

public class PTra16_02
{
    public static void Main(string[] args)
    {
        /*
    	 * TODO
    	 * commonのThrowExceptionUtilクラスのメソッドを呼び出した後、
    	 * 後続の処理も行うように修正してください。
    	 * ThrowExceptionUtilクラスは変更せずに下の処理を修正することで完成してください。
    	 */
        // ※メソッドが呼び出されました。例外が発生し、後続の処理を行いました。 と表示されれば正解
        try
        {
            ThrowExceptionUtil.ExceptioinMethod();
        }
        catch (Exception e)
        {
            Console.Write("例外が発生し、");
        }

        Console.WriteLine("後続の処理を行いました。");

    }
}