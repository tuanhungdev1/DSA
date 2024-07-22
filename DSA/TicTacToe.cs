using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DSA {
    public class TicTacToe {
        public static readonly int X = 1, O = -1;
        public static readonly int EMPTY = 0;
        public int[,] board = new int[3, 3];
        public int player;

        /** Constructor */
        public TicTacToe() { ClearBoard(); }

        /** Xóa bảng */
        public void ClearBoard() {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = EMPTY; // mỗi ô nên trống
            player = X; // người chơi đầu tiên là 'X'
        }

        public void PutMark(int i, int j) {
            if (i < 0 || i > 2 || j < 0 || j > 2) {
                throw new ArgumentException("Vi tri bang khong hop le");
            }

            if(board[i, j] != EMPTY) {
                throw new ArgumentException("Vi tri da duoc dat");
            }

            board[i, j] = player;
            player = -player;
        }

        public bool IsWin(int mark) {
            return (board[0, 0] + board[0, 1] + board[0, 2]) == mark * 3
                || ((board[1, 0] + board[1, 1] + board[1, 2]) == mark * 3)
                || (board[2, 0] + board[2, 1] + board[2, 2]) == mark * 3
                || (board[0, 0] + board[1, 0] + board[2, 0]) == mark * 3
                || (board[0, 1] + board[1, 1] + board[2, 1]) == mark * 3
                || (board[0, 2] + board[1, 2] + board[2, 2]) == mark * 3
                || (board[0, 0] + board[1, 1] + board[2, 2]) == mark * 3
                || (board[0, 2] + board[1, 1] + board[2, 0]) == mark * 3;
        }

        public int Winner() {
            if (IsWin(X))
                return X;
            else if (IsWin(O))
                return O;
            else
                return 0;
        }

        /** Trả về chuỗi ký tự đơn giản hiển thị bảng hiện tại. */
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    switch (board[i, j]) {
                        case 1: sb.Append("X"); break;
                        case -1: sb.Append("O"); break;
                        case 0: sb.Append(" "); break;
                    }
                    if (j < 2) sb.Append("|"); // ranh giới cột
                }
                if (i < 2) sb.Append("\n-----\n"); // ranh giới hàng
            }
            return sb.ToString();
        }
    }
}
