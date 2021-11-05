using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screenplay.Core.Tests.Unit.TestDoubles
{
    public class StubQuestion : IQuestion<int>
    {
        private int _answer;
        private StubQuestion(){}

        public static StubQuestion CreateNew()
        {
            return new StubQuestion();
        }

        public int AnsweredBy(Actor actor)
        {
            return _answer;
        }

        public StubQuestion WhichReturnsAnswer(int answer)
        {
            _answer = answer;
            return this;
        }
    }
}
