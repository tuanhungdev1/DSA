using DSA.DSA;

namespace DSA
{
    internal class Program {
        public static void Main(string[] args) {

            TicTacToe game = new TicTacToe();
            /** Các lượt đi của X: */ /** Các lượt đi của O: */
            game.PutMark(1, 1); game.PutMark(0, 2);
            game.PutMark(2, 2); game.PutMark(1, 0);
            game.PutMark(0, 0); 
            Console.WriteLine(game);
            int winningPlayer = game.Winner();
            string[] outcome = { "O thắng", "Hòa", "X thắng" }; // dựa vào thứ tự
            Console.WriteLine(outcome[1 + winningPlayer]);

        }

        
    }
}
