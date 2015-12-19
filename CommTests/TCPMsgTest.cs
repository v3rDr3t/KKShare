using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using KKShare.ConnectionAndTransfers;

namespace CommTests
{
    [TestClass]
    public class SharesMsgTest
    {
        [TestMethod]
        public void ConvertSharesMsgTest()
        {
            // create expected data
            string filePath0 = "topFolder1/subFolder1/file1.txt";
            string filePath1 = "topFolder1/subFolder1/file2.txt";
            string filePath2 = "topFolder1/subFolder1/file3.txt";
            string filePath3 = "topFolder1/subFolder2/file1.txt";
            string filePath4 = "topFolder1/file1.txt";
            string filePath5 = "topFolder2/subFolder1/file1.txt";
            string filePath6 = "topFolder2/subFolder2/file1.txt";
            string filePath7 = "topFolder2/subFolder2/file2.txt";
            string filePath8 = "topFolder2/subFolder1/file1.txt";
            string filePath9 = "topFolder3/file1";
            List<string> expectedShares = new List<string> { filePath0, filePath1, filePath2, filePath3, filePath4,
                filePath5, filePath6, filePath7, filePath8, filePath9 };
            TCPMessage expectedMsg = new SharesMsg(expectedShares);

            // convert
            byte[] bytes = expectedMsg.ToBytes();

            // interpret
            TCPInterpreter interpreter = new TCPInterpreter();
            TCPMessage actualMsg = interpreter.Parse(bytes);

            // assert type
            Assert.AreEqual(expectedMsg.Type.ToString(), actualMsg.Type.ToString(), false,
                "Types did not convert properly!");

            // assert shares
            List<string> actualShares = ((SharesMsg)actualMsg).Shares;
            for (int i = 0; i < actualShares.Count; i++)
            {
                Assert.AreEqual(expectedShares[i], actualShares[i], false,
                "Shares did not convert properly!");
            }
        }

        [TestMethod]
        public void ConvertSharesRequestMsgTest()
        {
            // create expected data
            SharesRequestMsg expectedMsg = new SharesRequestMsg();

            // convert
            byte[] bytes = expectedMsg.ToBytes();

            // interpret
            TCPInterpreter interpreter = new TCPInterpreter();
            TCPMessage actualMsg = interpreter.Parse(bytes);

            // assert type
            Assert.AreEqual(expectedMsg.Type.ToString(), actualMsg.Type.ToString(), false,
                "Types did not convert properly!");
        }
    }
}
