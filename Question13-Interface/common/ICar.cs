/*
 * ICar.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

/**
 * 車についてのインターフェース
 */

namespace common
{
		interface ICar
		{
				/**
				 * ガソリンを補充する
				 * @param gasoline
				 */
				void Charge(int x);

				/**
				 * 走る
				 */
				void Run(int x);
		}
}
