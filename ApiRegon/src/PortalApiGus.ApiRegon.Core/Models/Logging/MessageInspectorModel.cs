#region using

using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using NetAppCommon.Helpers.Xmls;
using Newtonsoft.Json;

#endregion

#nullable enable annotations

namespace PortalApiGus.ApiRegon.Core.Models.Logging
{
    public class MessageInspectorModel : NetAppCommon.Logging.ClientMessageInspector.Models.Base.MessageInspectorModel
    {
        public MessageInspectorModel()
        {
        }

        public MessageInspectorModel(Message message, object correlationState)
        {
            try
            {
                base.AfterReceiveReplyMessage = JsonConvert.SerializeObject(message);
                base.AfterReceiveReplyMessageAsStringXml =
                    HttpUtility.HtmlDecode(XmlHelper.GetDocument(message).OuterXml);
                base.AfterReceiveReplyCorrelationState = JsonConvert.SerializeObject(correlationState);
            }
#if DEBUG
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
#else
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
#endif
        }

        public MessageInspectorModel(Message message, IClientChannel clientChannel)
        {
            try
            {
                base.BeforeSendRequestMessage = JsonConvert.SerializeObject(message);
                base.BeforeSendRequestMessageAsStringXml =
                    HttpUtility.HtmlDecode(XmlHelper.GetDocument(message).OuterXml);
                base.BeforeSendRequestClientChannel = JsonConvert.SerializeObject(clientChannel);
            }
#if DEBUG
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
#else
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
#endif
        }
    }
}
