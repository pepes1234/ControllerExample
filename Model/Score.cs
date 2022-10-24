using System;
using System.Collections.Generic;

namespace ControllerExample.Model
{
    public partial class Score
    {
        public int Id { get; set; }
        public string? Player1 { get; set; }
        public string? Player2 { get; set; }
        public string? ScorePlayer1 { get; set; }
        public string? ScorePlayer2 { get; set; }
    }
}
