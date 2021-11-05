using System.Collections.Generic;
using System.Net;

namespace Screenplay.Rest.Tests.Unit.TestDoubles
{
    public class SpyHttpSender : IHttpSender
    {
        private List<HttpWebRequest> _requests = new();
        public void SendRequest(HttpWebRequest request)
        {
            _requests.Add(request);
        }

        public List<HttpWebRequest> GetAllRequests()
        {
            return _requests;
        }
    }
}
