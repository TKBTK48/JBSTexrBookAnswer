/*
 * MayoiRoad.cs
 *   作成	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using System;
using System.Collections.Generic;
using System.Numerics;

namespace testFirst
{
    /**
     * テスト技法・設計手法演習問題です。
     * このクラスを対象としたテストクラス：MayoiRoadTestのテストメソッドを実行した時に、
     * 全てのテストメソッドがグリーンで完了するよう実装して下さい
     *
     * ※もちろん、テストケース以外のパターンでも正常動作するようにしてください
     * @author IT-College
     *
     */
    public class MayoiRoad
    {
        public static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
				Console.WriteLine("N（反転回数の上限）を入力して下さい。上限はintの上限値及び、正の数とします");

                var input = Console.ReadLine();
				if (!(int.TryParse(input, out n)))
                {
					Console.WriteLine("数値を入力してください");
					continue;
                }

                if (n < 0)
                {
					Console.WriteLine("範囲外の入力です");
                    continue;
                }
                break;
            }

            String p = Check(n);

			Console.WriteLine("[N:" + n + "] の場合、[P:" + p + "]");

            // nothing
        }

        /**
         * N が与えられたとき、P を出力するプログラムです。
         * @param 試行回数
         * @return Bにたどり着ける回数
         */
        public static string Check(int n)
        {
			/*
			 * N を「反転回数の上限」とします。言い換えるなら N は「その回数までは反転してかまわないという数」です。
			 * P を「A から入って B から出るルートの種類の数」とします
			 */

			/* ex)
			 * もしも N が 1 の場合、B から出るルートは、
			 * • A → イ → ウ → イ → ア → B
			 * • A → イ → ア → B
			 * という 2 種類があるので、P は 2 になります。
			 */

			/* ex)
			 * もしも N が 4 の場合、B から出るルートは、
			 * • X → イ → ウ → イ → ア → B
			 * • X → イ → ウ → イ → ア → イ → ウ → イ → ア → B
			 * • X → イ → ウ → イ → ア → イ → ア → B
			 * • X → イ → ウ → イ → ウ → イ → ア → B
			 * • X → イ → ア → B
			 * • X → イ → ア → イ → ウ → イ → ア → B
			 * • X → イ → ア → イ → ア → B
			 * という 7 種類があるので、P は 7 になります。
			 */

			// 1 -> 2
			// 3(4) -> 7 (2 + 5)
			// 5(6) -> 20 (2 + 5 + 13)
			// 7(8) -> 54 (2 + 5 + 13 + 34)
			// 9(10)-> 143(2 + 5 + 13 + 34 + (68+21))
			//
			// 法則を考えると、(1つ前のパターン * 2） + （2つ前と1つ前の差）で算出できる（？）
			// これ以上の数値は手計算では厳しいので、ここまでのパターンを仮定して進める

			// 計算開始
			// の前にN=0以下だとそもそもNG
			if (n <= 0)
			{
				return "0";
			}

			// 奇数は+1と同じようだ
			if (n % 2 == 1)
			{
				n++;
			}

			// N=1(2)の時はちょっと例外パターン
			if (n == 2)
			{
				return "2";
			}

			// 計算開始
			List<BigInteger> list = new List<BigInteger>();
			list.Add(new BigInteger(2));  // N=1(2)
			list.Add(new BigInteger(5));  // N=3(4)

			// ↓↓↓↓それ以降からスタート
			for (int i = 6; i <= n; i += 2)
			{
				// 前の数値の倍
				int count = list.Count;
				BigInteger x = list[count - 1];
				BigInteger baseNum = BigInteger.Multiply(x, new BigInteger(2));
				BigInteger dif = BigInteger.Subtract(x, list[count - 2]);
				list.Add(BigInteger.Add(baseNum, dif));
			}

			// 最後に計算
			// これ、結局↑のforで回しながら計算した方が良いが、パフォーマンスを捨てて可読性を選択
			BigInteger p = new BigInteger(0);
			foreach (BigInteger number in list)
			{
				p = BigInteger.Add(p, number);
			}
			return p.ToString();

		}
	}
}
