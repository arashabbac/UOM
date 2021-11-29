using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Questions;

namespace UOM.Specs.Screenplay
{
    public static class Factory
    {
        public static T CreateTask<T>(params object[] parameters) where T : ITask
        {
            return default(T);
        }

        public static T CreateQuestion<T,TAnswer>(params object[] parameters) where T : IQuestion<TAnswer>
        {
            return default(T);
        }
    }
}
