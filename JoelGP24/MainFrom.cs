using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoelGP24
{
    internal abstract class MainFrom
    {
        protected List<QuestionModel> questions;
        protected string player;
        protected int points;
        

        protected MainFrom(List<QuestionModel> questions, string player, int points)
        {
            this.questions = questions;
            this.player = player;
            this.points = points;
            
        }

        public List<QuestionModel> Questions { get => questions; set => questions = value; }
        public string Player { get => player; set => player = value; }
        public int Points { get => points; set => points = value; }
        public abstract List<QuestionModel>();
    }
}
