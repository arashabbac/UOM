using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Questions;
using System;
using System.Collections.Generic;

namespace UOM.Specs.Screenplay
{
    public static class Factory
    {
        private static Dictionary<string, Type> _cachedTypes;

        //static Factory()
        //{
        //    _cachedTypes = Config.Current

        //}
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
