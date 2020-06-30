/*
 * Book.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
		public abstract class Book
		{
				/**
				 * 本のタイトルを取得する
				 * @return 本のタイトル
				 */
				public abstract String GetBookTitle();

				/**
				 * 本の章立てのリストを取得する
				 * @return 章立ての一覧
				 */
				public abstract String[] GetEpisodeList();
		}
}
