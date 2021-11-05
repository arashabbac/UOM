using System.Collections.Generic;
using System.Linq;

namespace Screenplay.Core
{
    public class Actor
    {
        private readonly Notepad _notepad = new();
        private IList<IAbility> _abilities = new List<IAbility>();
        private Actor(){ }

        public string Name { get; private set; }
        public static Actor Named(string name)
        {
            var actor = new Actor
            {
                Name = name
            };
            return actor;
        }

        public void AttemptsTo(IPerformable task)
        {
            task.Perform(this);
        }

        public void Remembers(string key, object value)
        {
            _notepad.WriteDown(key,value);
        }

        public T Recalls<T>(string key)
        {
            return _notepad.Read<T>(key);
        }

        public T AsksFor<T>(IQuestion<T> question)
        {
            return question.AnsweredBy(this);
        }

        public void WhoCan(IAbility ability)
        {
            _abilities.Add(ability);
        }

        public T FindAbility<T>() where T : IAbility
        {
            return _abilities.OfType<T>().FirstOrDefault();
        }
    }
}