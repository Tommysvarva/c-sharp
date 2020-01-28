using System;


namespace PlayerObjekter
{
    class Player
    {
        private readonly Random _random;
        private string _name;
        private int _points;
        public Player(string name, int points, Random random)
        {
            _random = random;
            _points = points;
            _name = name;

        }
        public void ShowNameAndPoints()
        {
            Console.WriteLine(_name.PadRight(12) + _points.ToString().PadLeft(3));
        }
        public void Play(Player player2)
        {
            var winner = _random.Next(2) == 0 ? this : player2;
            var looser = winner == this ? player2 : this;
            winner._points+= 1;
            looser._points-= 1;
            }
        }
   
}

