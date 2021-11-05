namespace Screenplay.Core
{
    public interface IQuestion<out TAnswer>
    {
        TAnswer AnsweredBy(Actor actor);
    }
}
