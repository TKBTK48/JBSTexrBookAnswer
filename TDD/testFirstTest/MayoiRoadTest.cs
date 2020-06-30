/*
 * MayoiRoadTest.cs
 *   �쐬	IT-College	2019
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testFirst;

namespace testFirstTest
{
    /**
     * testFirst.MayoiRoad�N���X���\�b�h�̃e�X�g�N���X�ł��B
     * �P�̃e�X�g�����s���āA�e�X�g���N���A����悤�Ɏ������ĉ�����
     * @author IT-College
     *
     */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void N��0�̏ꍇ()
        {
            var expected = "0";
            var actual = MayoiRoad.Check(0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��1�̏ꍇ()
        {
            var expected = "2";
            var actual = MayoiRoad.Check(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��3�̏ꍇ()
        {
            var expected = "7";
            var actual = MayoiRoad.Check(3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��4�̏ꍇ()
        {
            var expected = "7";
            var actual = MayoiRoad.Check(4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��5�̏ꍇ()
        {
            var expected = "20";
            var actual = MayoiRoad.Check(5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��10�̏ꍇ()
        {
            var expected = "143";
            var actual = MayoiRoad.Check(10);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��100�̏ꍇ()
        {
            var expected = "927372692193078999175";
            var actual = MayoiRoad.Check(100);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��1000�̏ꍇ()
        {
            var expected = "113796925398360272257523782552224175572745930353730513145086634176691092536145985470146129334641866902783673042322088625863396052888690096969577173696370562180400527049497109023054114771394568040040412172632375";
            var actual = MayoiRoad.Check(1000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void N��2015�̏ꍇ()
        {
            var expected = "24410294683171395267259945469996127000411199333760853190535535281681195871429510314079442068798555059453792431772087225245168879580469159794544170936403149540819320510882801573596907938222922817134288725100817648047405608500267748766714030468003650259685406411646787207097050545802045736020993909154298598218721111963426993884619351338577630868510716463423585020972878819198991971234596733617320373133963970742975210614208";
            var actual = MayoiRoad.Check(2015);
            Assert.AreEqual(expected, actual);
        }

    }
}
