using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGuiMVP
{
    public interface MainWindowInterface
    {
        void DrawTicTacToeSymbol(int player, int row, int col);
        void UpdateGameFinished(string text);
        void ShowNextPlayer(int player);
        void ShowError(string text);
        void UpdateStatus(string text);
        void ResetBoard();
    }
}
