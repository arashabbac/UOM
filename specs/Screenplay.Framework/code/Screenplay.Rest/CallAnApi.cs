using System.Net;
using Screenplay.Core;

namespace Screenplay.Rest
{
    public class CallAnApi : IAbility
    {
        private readonly IHttpSender _httpSender;

        public CallAnApi(IHttpSender httpSender)
        {
            _httpSender = httpSender;
        }

        public void SendRequest(HttpWebRequest request)
        {
            _httpSender.SendRequest(request);
        }
    }
}
