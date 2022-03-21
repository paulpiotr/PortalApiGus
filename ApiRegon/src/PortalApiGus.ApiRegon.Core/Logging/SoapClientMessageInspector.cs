#region using

using System;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using log4net;
using NetAppCommon.Logging;
using NetAppCommon.Logging.ClientMessageInspector.Repositories;
using NetAppCommon.Logging.ClientMessageInspector.Repositories.Interface;
using PortalApiGus.ApiRegon.Core.Models.Logging;

#endregion

namespace PortalApiGus.ApiRegon.Core.Logging
{
    #region public class SoapClientMessageInspector : NetAppCommon.Logging.SoapClientMessageInspector

    /// <summary>
    ///     Inspektor wiadomości klienta SOAP
    ///     Soap Client Message Inspector
    /// </summary>
    public class SoapClientMessageInspector : NetAppCommon.Logging.ClientMessageInspector.SoapClientMessageInspector
    {
        #region private readonly ILog _log4Net

        /// <summary>
        ///     private readonly ILog _log4Net
        /// </summary>
        private readonly ILog _log4Net = Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        #region private readonly IDistributedCacheRepository _repository

        /// <summary>
        /// Interfejs repozytorium rozproszonej pamięci podręcznej
        /// Distributed cache repository interface
        /// </summary>
        private readonly IDistributedCacheRepository _repository;

        #endregion

        public SoapClientMessageInspector()
        {
            _repository = new DistributedCacheRepository();
        }

        public SoapClientMessageInspector(Guid guid)
        {
            _repository = new DistributedCacheRepository(guid);
        }

        #region public override void AfterReceiveReply...

        /// <summary>
        ///     Po otrzymaniu odpowiedzi
        ///     After Receive Reply
        /// </summary>
        /// <param name="reply">
        ///     Referencja do wiadomości odpowiedzi jako Message
        ///     A reference to the reply message as Message
        /// </param>
        /// <param name="correlationState">
        ///     Stan korelacji jako obiekt
        ///     Correlation state as an object
        /// </param>
        public override void AfterReceiveReply(ref Message reply, object correlationState)
        {
            try
            {
//#if DEBUG
//                _log4Net.Debug("Override AfterReceiveReply");
//#endif
                using MessageBuffer messageBuffer = reply.CreateBufferedCopy(int.MaxValue);
                var model = new MessageInspectorModel(messageBuffer.CreateMessage(), correlationState);
                _repository.Set(Math.Abs(model.GetHashCode()).ToString(), model);
                reply = messageBuffer.CreateMessage();
                //base.AfterReceiveReply(ref reply, correlationState);
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }
            }
        }

        #endregion

        #region public override object BeforeSendRequest...

        /// <summary>
        ///     Przed wysłaniem żądania
        ///     Before sending the request
        /// </summary>
        /// <param name="message">
        ///     Referencja do wiadomości w żądaniu
        ///     Reference to the message in the request
        /// </param>
        /// <param name="clientChannel">
        ///     Kanał wymiany
        ///     Exchange channel
        /// </param>
        /// <returns>
        ///     null
        ///     mull
        /// </returns>
        public override object BeforeSendRequest(ref Message message, IClientChannel clientChannel)
        {
            try
            {
//#if DEBUG
//                _log4Net.Debug("Override BeforeSendRequest");
//#endif
                using MessageBuffer messageBuffer = message.CreateBufferedCopy(int.MaxValue);
                var model = new MessageInspectorModel(messageBuffer.CreateMessage(), clientChannel);
                _repository.Set(Math.Abs(model.GetHashCode()).ToString(), model);
                message = messageBuffer.CreateMessage();
                //base.BeforeSendRequest(ref message, clientChannel);
            }
            catch (Exception e)
            {
                _log4Net.Error(e.Message, e);
                if (null != e.InnerException)
                {
                    _log4Net.Error(e.InnerException.Message, e.InnerException);
                }
            }

            return null;
        }

        #endregion
    }

    #endregion
}
