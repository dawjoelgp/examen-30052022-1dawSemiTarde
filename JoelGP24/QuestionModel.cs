using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoelGP24
{
    internal abstract class QuestionModel
    {
        protected string questions;
        protected string answers;
        protected int value;


        protected MainFrom(string questions, string answers, int value)
        {
            this.questions = questions;
            this.answers = answers;
            this.value = value;

        }

        public string Questions { get => questions; set => questions = value; }
        public string Answers { get => answers; set => answers = value; }
        public int Value { get => value; set => value = value; }
        public abstract string questions();
    }
}

