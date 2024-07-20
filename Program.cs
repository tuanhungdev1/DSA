namespace DSA {
    internal class Program {
        static void Main(string[] args) {
            GameEntry e0 = new GameEntry("Joe", 500);
            GameEntry e1 = new GameEntry("Doe", 400);
            GameEntry e2 = new GameEntry("Andrew", 300);
            GameEntry e3 = new GameEntry("Mark", 200);

            Scoreboard board = new Scoreboard(3);

            
            board.AddEntry(e1);
            board.AddEntry(e2);
            board.AddEntry(e3);
            board.AddEntry(e0);

            board.RemoveEntry(2);

            Console.WriteLine(board.ToString());

        }
    }
}
