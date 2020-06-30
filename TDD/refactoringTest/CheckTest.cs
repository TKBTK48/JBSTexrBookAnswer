/*
 * CheckTest.cs
 *   作成	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using refactoring;

namespace refactoringTest
{
    [TestClass]
    /**
     * refactoring.checkクラスメソッドのテストクラスです。
     * 単体テストを実行して、テストをクリアするように実装して下さい
     * @author IT-College
     *
     */
    public class CheckTest
    {
        [TestMethod]
        public void 小文字が大文字になって返る()
        {
            var expected = "AVAJ";
            var actual = Check.ToReverseString("java");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 空文字を処理した場合は空文字が返る()
        {
            var expected = "";
            var actual = Check.ToReverseString("");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 文字列中のスペースが除去されずに返る()
        {
            var expected = "MARGORP EKIL I";
            var actual = Check.ToReverseString("I like program");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 大文字小文字混在の場合は大文字が返る()
        {
            var expected = "REMMARGORP";
            var actual = Check.ToReverseString("Programmer");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 半角スペースのみの場合はそのまま返る()
        {
            var expected = "   ";
            var actual = Check.ToReverseString("   ");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 全角スペースのみの場合はそのまま返る()
        {
            var expected = "　　　";
            var actual = Check.ToReverseString("　　　");
            Assert.AreEqual(expected, actual);
        }
    }
}
