using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace OPLManagerService
{
    public class HttpUserAgentMessageInspector : IClientMessageInspector
    {
        private const string USER_AGENT_HTTP_HEADER = "user-agent";
        private readonly string UserAgent;

        public HttpUserAgentMessageInspector(string userAgent)
        {
            UserAgent = userAgent;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            if (request.Properties.TryGetValue(HttpRequestMessageProperty.Name, out object obj))
            {
                var httpRequestMessageProperty = obj as HttpRequestMessageProperty;
                if (string.IsNullOrEmpty(httpRequestMessageProperty.Headers[USER_AGENT_HTTP_HEADER]))
                {
                    httpRequestMessageProperty.Headers[USER_AGENT_HTTP_HEADER] = UserAgent;
                }
            }
            else
            {
                var httpRequestMessageProperty = new HttpRequestMessageProperty();
                httpRequestMessageProperty.Headers.Add(USER_AGENT_HTTP_HEADER, UserAgent);
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessageProperty);
            }

            return null;
        }
    }
}