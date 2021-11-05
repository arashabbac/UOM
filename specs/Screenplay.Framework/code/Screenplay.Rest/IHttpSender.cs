using System.Net;

namespace Screenplay.Rest
{
    public interface IHttpSender
    {
        void SendRequest(HttpWebRequest request);
    }
}