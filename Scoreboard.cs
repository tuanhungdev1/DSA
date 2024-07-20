using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA {
    public class Scoreboard {
        // Số lượng mục thực tế hiện có trên bảng điểm
        private int numEntries = 0;

        // Mảng các mục trò chơi (tên & điểm số)
        private GameEntry[] board;

        // Tạo một bảng điểm trống với dung lượng cho việc lưu trữ các mục.
        public Scoreboard(int capacity) {
            board = new GameEntry[capacity];
        }

        // Trả về số lượng mục thực tế
        public int NumEntries {
            get { return numEntries; }
        }

        // Thêm một mục trò chơi vào bảng điểm
        public void AddEntry(GameEntry entry) {
            int newScore = entry.Score;

            if (numEntries < board.Length || newScore > board[numEntries - 1].Score) {

                if (numEntries < board.Length) {
                      numEntries++;
                }

                int j = numEntries - 1;

                while (j > 0 && newScore > board[j - 1].Score) {
                    board[j] = board[j - 1];
                    j--;
                }

                board[j] = entry;
            }
        }

        public GameEntry RemoveEntry(int i) {
            if (i < 0 || i >= numEntries) {
                throw new IndexOutOfRangeException("Chi so khong hop le: " + i);
            }
            GameEntry entry = board[i];

            for (int j = i; j < numEntries - 1; j++) {
                board[j] = board[j + 1];
            }

            board[numEntries - 1] = null;

            numEntries--;

            return entry;

        }

        // Trả về một chuỗi đại diện cho bảng điểm
        public override string ToString() {
            var result = new StringBuilder();
            foreach (var entry in board) {
                if (entry != null)
                    result.AppendLine(entry.ToString());
            }
            return result.ToString();
        }
    }

}
