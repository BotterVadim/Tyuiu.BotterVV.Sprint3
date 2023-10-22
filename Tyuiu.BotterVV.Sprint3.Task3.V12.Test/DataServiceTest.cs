using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint3.Task3.V12.Lib;


namespace Tyuiu.BotterVV.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string str = "ssrdekrtvkk";
            char chr = 'k';

            double res = ds.GetMaxCharCount(str, chr);

            int wait = 3;

            Assert.AreEqual(wait, res);


        }
    }
}
