using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeGuiMVP;

namespace UnitTestTicTacToe
{
    [TestClass]
    public class UnitTest1
    {
        public class TestUIInterface : MainWindowInterface
        {
            public bool resetBoardCalled = false;
            public string updataStatusString = "";

            public void DrawTicTacToeSymbol(int player, int row, int col)
            {

            }

            public void ResetBoard()
            {
                resetBoardCalled = true;
            }

            public void ShowError(string v)
            {

            }

            public void ShowNextPlayer(int nextPlayer)
            {

            }

            public void UpdateGameFinished(string v)
            {

            }

            public void UpdateStatus(string v)
            {
                updataStatusString = v;
            }
        }


        [TestMethod]
        public void Test_StartGame()
        {
            //Arrange
            TestUIInterface theTestedUI = new TestUIInterface();
            Presenter thePresenter = new Presenter(theTestedUI);

            //Act
            thePresenter.StartGame();

            //Assert
            Assert.IsTrue(theTestedUI.resetBoardCalled);
            Assert.AreEqual("status: ready", theTestedUI.updataStatusString);
        }

    }
}