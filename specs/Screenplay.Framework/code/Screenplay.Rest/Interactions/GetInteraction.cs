using System.Net;
using Screenplay.Core;

namespace Screenplay.Rest.Interactions
{
    public static class GetResource
    {
        public static IInteraction At(string resource)
        {
            return new GetInteraction(resource);
        }
    }

    internal class GetInteraction : IInteraction
    {
        private readonly string _uri;

        public GetInteraction(string uri)
        {
            _uri = uri;
        }
        public void Perform(Actor actor)
        {
            var ability = actor.FindAbility<CallAnApi>();
            var request = HttpWebRequest.Create(_uri) as HttpWebRequest;
            request.Method = "GET";

            ability.SendRequest(request);
        }
    }
}
