/*
 * CheckTest.cs
 *   �쐬	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using refactoring;

namespace refactoringTest
{
    [TestClass]
    /**
     * refactoring.check�N���X���\�b�h�̃e�X�g�N���X�ł��B
     * �P�̃e�X�g�����s���āA�e�X�g���N���A����悤�Ɏ������ĉ�����
     * @author IT-College
     *
     */
    public class CheckTest
    {
        [TestMethod]
        public void ���������啶���ɂȂ��ĕԂ�()
        {
            var expected = "AVAJ";
            var actual = Check.ToReverseString("java");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void �󕶎������������ꍇ�͋󕶎����Ԃ�()
        {
            var expected = "";
            var actual = Check.ToReverseString("");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void �����񒆂̃X�y�[�X���������ꂸ�ɕԂ�()
        {
            var expected = "MARGORP EKIL I";
            var actual = Check.ToReverseString("I like program");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void �啶�����������݂̏ꍇ�͑啶�����Ԃ�()
        {
            var expected = "REMMARGORP";
            var actual = Check.ToReverseString("Programmer");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ���p�X�y�[�X�݂̂̏ꍇ�͂��̂܂ܕԂ�()
        {
            var expected = "   ";
            var actual = Check.ToReverseString("   ");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void �S�p�X�y�[�X�݂̂̏ꍇ�͂��̂܂ܕԂ�()
        {
            var expected = "�@�@�@";
            var actual = Check.ToReverseString("�@�@�@");
            Assert.AreEqual(expected, actual);
        }
    }
}
