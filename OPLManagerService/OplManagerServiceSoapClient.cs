using OPLManagerService.Services;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

namespace OPLManagerService
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class OPLManagerServiceSoapClient : ClientBase<OPLManagerServiceSoap>, OPLManagerServiceSoap
    {
        public event EventHandler<GetDesktopAppVersionCompletedEventArgs> GetDesktopAppVersionCompleted;

        public event EventHandler<ServiceStatusCompletedEventArgs> ServiceStatusCompleted;

        public event EventHandler<ArtSearchSingleCompletedEventArgs> ArtSearchSingleCompleted;

        public event EventHandler<ArtSearchBatchCompletedEventArgs> ArtSearchBatchCompleted;

        public event EventHandler<BatchArtShareCheckCompletedEventArgs> BatchArtShareCheckCompleted;

        public event EventHandler<ArtUploadCompletedEventArgs> ArtUploadCompleted;

        public event EventHandler<ReportArtCompletedEventArgs> ReportArtCompleted;

        public event EventHandler<GetGameNameByIdCompletedEventArgs> GetGameNameByIdCompleted;

        public static OPLManagerServiceSoapClient GetApiInterfaceInstance()
        {
            var basicHttpBinding = new BasicHttpBinding
            {
                MaxBufferPoolSize = 2097152L,
                MaxReceivedMessageSize = 2097152L
            };
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;

            var remoteAddress = new EndpointAddress("https://oplmanager.com/API/V5/OPLManagerService.asmx");
            var serviceSoapClient = new OPLManagerServiceSoapClient(basicHttpBinding, remoteAddress);
            serviceSoapClient.Endpoint.EndpointBehaviors.Add(new HttpUserAgentEndpointBehavior("OPL-Manager/21.7"));

            return serviceSoapClient;
        }

        internal OPLManagerServiceSoapClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GetDesktopAppVersionResponse GetDesktopAppVersion(GetDesktopAppVersionRequest request)
        {
            return Channel.GetDesktopAppVersion(request);
        }

        public VersionDesktopInfo GetDesktopAppVersion(int current)
        {
            return GetDesktopAppVersion(new GetDesktopAppVersionRequest
            {
                Body = new GetDesktopAppVersionRequestBody()
                {
                    current = current
                }
            }).Body.GetDesktopAppVersionResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginGetDesktopAppVersion(GetDesktopAppVersionRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetDesktopAppVersion(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginGetDesktopAppVersion(int current, AsyncCallback callback, object asyncState)
        {
            return BeginGetDesktopAppVersion(new GetDesktopAppVersionRequest
            {
                Body = new GetDesktopAppVersionRequestBody()
                {
                    current = current
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GetDesktopAppVersionResponse EndGetDesktopAppVersion(IAsyncResult result)
        {
            return Channel.EndGetDesktopAppVersion(result);
        }

        private IAsyncResult OnBeginGetDesktopAppVersion(object[] inValues, AsyncCallback callback, object asyncState)
        {
            int current = Convert.ToInt32(inValues[0]);
            return BeginGetDesktopAppVersion(current, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndGetDesktopAppVersion(IAsyncResult result)
        {
            return new object[]
            {
                EndGetDesktopAppVersion(result).Body.GetDesktopAppVersionResult
            };
        }

        private void OnGetDesktopAppVersionCompleted(object state)
        {
            if (GetDesktopAppVersionCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                GetDesktopAppVersionCompleted(this, new GetDesktopAppVersionCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void GetDesktopAppVersionAsync(int current)
        {
            GetDesktopAppVersionAsync(current, null);
        }

        public void GetDesktopAppVersionAsync(int current, object userState)
        {
            onBeginGetDesktopAppVersionDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginGetDesktopAppVersion);
            onEndGetDesktopAppVersionDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndGetDesktopAppVersion);
            onGetDesktopAppVersionCompletedDelegate ??= new SendOrPostCallback(OnGetDesktopAppVersionCompleted);

            InvokeAsync(onBeginGetDesktopAppVersionDelegate,
                new object[] { current },
                onEndGetDesktopAppVersionDelegate,
                onGetDesktopAppVersionCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ServiceStatusResponse ServiceStatus(ServiceStatusRequest request)
        {
            return Channel.ServiceStatus(request);
        }

        public ServerStatus ServiceStatus(string userID, int versionid)
        {
            return ServiceStatus(new ServiceStatusRequest
            {
                Body = new ServiceStatusRequestBody()
                {
                    userID = userID,
                    versionid = versionid
                }
            }).Body.ServiceStatusResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginServiceStatus(ServiceStatusRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginServiceStatus(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginServiceStatus(string userID, int versionid, AsyncCallback callback, object asyncState)
        {
            return BeginServiceStatus(new ServiceStatusRequest
            {
                Body = new ServiceStatusRequestBody()
                {
                    userID = userID,
                    versionid = versionid
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ServiceStatusResponse EndServiceStatus(IAsyncResult result)
        {
            return Channel.EndServiceStatus(result);
        }

        private IAsyncResult OnBeginServiceStatus(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var userID = Convert.ToString(inValues[0]);
            var versionid = Convert.ToInt32(inValues[1]);
            return BeginServiceStatus(userID, versionid, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndServiceStatus(IAsyncResult result)
        {
            return new object[]
            {
                EndServiceStatus(result).Body.ServiceStatusResult
            };
        }

        private void OnServiceStatusCompleted(object state)
        {
            if (ServiceStatusCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                ServiceStatusCompleted(this, new ServiceStatusCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void ServiceStatusAsync(string userID, int versionid)
        {
            ServiceStatusAsync(userID, versionid, null);
        }

        public void ServiceStatusAsync(string userID, int versionid, object userState)
        {
            onBeginServiceStatusDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginServiceStatus);
            onEndServiceStatusDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndServiceStatus);
            onServiceStatusCompletedDelegate ??= new SendOrPostCallback(OnServiceStatusCompleted);

            InvokeAsync(onBeginServiceStatusDelegate,
                new object[] { userID, versionid },
                onEndServiceStatusDelegate,
                onServiceStatusCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ArtSearchSingleResponse ArtSearchSingle(ArtSearchSingleRequest request)
        {
            return Channel.ArtSearchSingle(request);
        }

        public GameART ArtSearchSingle(GameType type, string userID, string gameId)
        {
            return ArtSearchSingle(new ArtSearchSingleRequest
            {
                Body = new ArtSearchSingleRequestBody()
                {
                    type = type,
                    userID = userID,
                    gameId = gameId
                }
            }).Body.ArtSearchSingleResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginArtSearchSingle(ArtSearchSingleRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginArtSearchSingle(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginArtSearchSingle(GameType type, string userID, string gameId, AsyncCallback callback, object asyncState)
        {
            return BeginArtSearchSingle(new ArtSearchSingleRequest
            {
                Body = new ArtSearchSingleRequestBody()
                {
                    type = type,
                    userID = userID,
                    gameId = gameId
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ArtSearchSingleResponse EndArtSearchSingle(IAsyncResult result)
        {
            return Channel.EndArtSearchSingle(result);
        }

        private IAsyncResult OnBeginArtSearchSingle(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var type = (GameType)Convert.ToInt32(inValues[0]);
            var userID = Convert.ToString(inValues[1]);
            var gameId = Convert.ToString(inValues[2]);
            return BeginArtSearchSingle(type, userID, gameId, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndArtSearchSingle(IAsyncResult result)
        {
            return new object[]
            {
                EndArtSearchSingle(result).Body.ArtSearchSingleResult
            };
        }

        private void OnArtSearchSingleCompleted(object state)
        {
            if (ArtSearchSingleCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                ArtSearchSingleCompleted(this, new ArtSearchSingleCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void ArtSearchSingleAsync(GameType type, string userID, string gameId)
        {
            ArtSearchSingleAsync(type, userID, gameId, null);
        }

        public void ArtSearchSingleAsync(GameType type, string userID, string gameId, object userState)
        {
            onBeginArtSearchSingleDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginArtSearchSingle);
            onEndArtSearchSingleDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndArtSearchSingle);
            onArtSearchSingleCompletedDelegate ??= new SendOrPostCallback(OnArtSearchSingleCompleted);

            InvokeAsync(onBeginArtSearchSingleDelegate,
                new object[] { type, userID, gameId },
                onEndArtSearchSingleDelegate,
                onArtSearchSingleCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ArtSearchBatchResponse ArtSearchBatch(ArtSearchBatchRequest request)
        {
            return Channel.ArtSearchBatch(request);
        }

        public GameART[] ArtSearchBatch(string userID, ArtSearchBatchRequestClass[] games)
        {
            return ArtSearchBatch(new ArtSearchBatchRequest
            {
                Body = new ArtSearchBatchRequestBody()
                {
                    userID = userID,
                    games = games
                }
            }).Body.ArtSearchBatchResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginArtSearchBatch(ArtSearchBatchRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginArtSearchBatch(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginArtSearchBatch(string userID, ArtSearchBatchRequestClass[] games, AsyncCallback callback, object asyncState)
        {
            return BeginArtSearchBatch(new ArtSearchBatchRequest
            {
                Body = new ArtSearchBatchRequestBody()
                {
                    userID = userID,
                    games = games
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ArtSearchBatchResponse EndArtSearchBatch(IAsyncResult result)
        {
            return Channel.EndArtSearchBatch(result);
        }

        private IAsyncResult OnBeginArtSearchBatch(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var userID = Convert.ToString(inValues[0]);
            var games = (ArtSearchBatchRequestClass[])inValues[1];
            return BeginArtSearchBatch(userID, games, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndArtSearchBatch(IAsyncResult result)
        {
            return new object[]
            {
                EndArtSearchBatch(result).Body.ArtSearchBatchResult
            };
        }

        private void OnArtSearchBatchCompleted(object state)
        {
            if (ArtSearchBatchCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                ArtSearchBatchCompleted(this, new ArtSearchBatchCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void ArtSearchBatchAsync(string userID, ArtSearchBatchRequestClass[] games)
        {
            ArtSearchBatchAsync(userID, games, null);
        }

        public void ArtSearchBatchAsync(string userID, ArtSearchBatchRequestClass[] games, object userState)
        {
            onBeginArtSearchBatchDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginArtSearchBatch);
            onEndArtSearchBatchDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndArtSearchBatch);
            onArtSearchBatchCompletedDelegate ??= new SendOrPostCallback(OnArtSearchBatchCompleted);

            InvokeAsync(onBeginArtSearchBatchDelegate,
                new object[] { userID, games },
                onEndArtSearchBatchDelegate,
                onArtSearchBatchCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public BatchArtShareCheckResponse BatchArtShareCheck(BatchArtShareCheckRequest request)
        {
            return Channel.BatchArtShareCheck(request);
        }

        public BatchArtShareResponseClass[] BatchArtShareCheck(string userID, BatchArtShareRequestClass[] games)
        {
            return BatchArtShareCheck(new BatchArtShareCheckRequest
            {
                Body = new BatchArtShareCheckRequestBody()
                {
                    userID = userID,
                    games = games
                }
            }).Body.BatchArtShareCheckResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginBatchArtShareCheck(BatchArtShareCheckRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginBatchArtShareCheck(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginBatchArtShareCheck(string userID, BatchArtShareRequestClass[] games, AsyncCallback callback, object asyncState)
        {
            return BeginBatchArtShareCheck(new BatchArtShareCheckRequest
            {
                Body = new BatchArtShareCheckRequestBody()
                {
                    userID = userID,
                    games = games
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public BatchArtShareCheckResponse EndBatchArtShareCheck(IAsyncResult result)
        {
            return Channel.EndBatchArtShareCheck(result);
        }

        private IAsyncResult OnBeginBatchArtShareCheck(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var userID = Convert.ToString(inValues[0]);
            var games = (BatchArtShareRequestClass[])inValues[1];
            return BeginBatchArtShareCheck(userID, games, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndBatchArtShareCheck(IAsyncResult result)
        {
            return new object[]
            {
                EndBatchArtShareCheck(result).Body.BatchArtShareCheckResult
            };
        }

        private void OnBatchArtShareCheckCompleted(object state)
        {
            if (BatchArtShareCheckCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                BatchArtShareCheckCompleted(this, new BatchArtShareCheckCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void BatchArtShareCheckAsync(string userID, BatchArtShareRequestClass[] games)
        {
            BatchArtShareCheckAsync(userID, games, null);
        }

        public void BatchArtShareCheckAsync(string userID, BatchArtShareRequestClass[] games, object userState)
        {
            onBeginBatchArtShareCheckDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginBatchArtShareCheck);
            onEndBatchArtShareCheckDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndBatchArtShareCheck);
            onBatchArtShareCheckCompletedDelegate ??= new SendOrPostCallback(OnBatchArtShareCheckCompleted);

            InvokeAsync(onBeginBatchArtShareCheckDelegate,
                new object[] { userID, games },
                onEndBatchArtShareCheckDelegate,
                onBatchArtShareCheckCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ArtUploadResponse ArtUpload(ArtUploadRequest request)
        {
            return Channel.ArtUpload(request);
        }

        public bool ArtUpload(string userID, ArtUploadRequestClass uploaded)
        {
            return ArtUpload(new ArtUploadRequest
            {
                Body = new ArtUploadRequestBody()
                {
                    userID = userID,
                    uploaded = uploaded
                }
            }).Body.ArtUploadResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginArtUpload(ArtUploadRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginArtUpload(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginArtUpload(string userID, ArtUploadRequestClass uploaded, AsyncCallback callback, object asyncState)
        {
            return BeginArtUpload(new ArtUploadRequest
            {
                Body = new ArtUploadRequestBody()
                {
                    userID = userID,
                    uploaded = uploaded
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ArtUploadResponse EndArtUpload(IAsyncResult result)
        {
            return Channel.EndArtUpload(result);
        }

        private IAsyncResult OnBeginArtUpload(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var userID = Convert.ToString(inValues[0]);
            var uploaded = (ArtUploadRequestClass)inValues[1];
            return BeginArtUpload(userID, uploaded, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndArtUpload(IAsyncResult result)
        {
            return new object[]
            {
                EndArtUpload(result).Body.ArtUploadResult
            };
        }

        private void OnArtUploadCompleted(object state)
        {
            if (ArtUploadCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                ArtUploadCompleted(this, new ArtUploadCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void ArtUploadAsync(string userID, ArtUploadRequestClass uploaded)
        {
            ArtUploadAsync(userID, uploaded, null);
        }

        public void ArtUploadAsync(string userID, ArtUploadRequestClass uploaded, object userState)
        {
            onBeginArtUploadDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginArtUpload);
            onEndArtUploadDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndArtUpload);
            onArtUploadCompletedDelegate ??= new SendOrPostCallback(OnArtUploadCompleted);

            InvokeAsync(onBeginArtUploadDelegate,
                new object[] { userID, uploaded },
                onEndArtUploadDelegate,
                onArtUploadCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ReportArtResponse ReportArt(ReportArtRequest request)
        {
            return Channel.ReportArt(request);
        }

        public bool ReportArt(string userID, GameType GameType, ArtType ArtType, string ArtGameID, string ArtFile, string ArtComments, ArtUploadRequestClass ArtReplacement)
        {
            return ReportArt(new ReportArtRequest
            {
                Body = new ReportArtRequestBody()
                {
                    userID = userID,
                    GameType = GameType,
                    ArtType = ArtType,
                    ArtGameID = ArtGameID,
                    ArtFile = ArtFile,
                    ArtComments = ArtComments,
                    ArtReplacement = ArtReplacement
                }
            }).Body.ReportArtResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginReportArt(ReportArtRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginReportArt(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginReportArt(string userID, GameType GameType, ArtType ArtType, string ArtGameID, string ArtFile, string ArtComments, ArtUploadRequestClass ArtReplacement, AsyncCallback callback, object asyncState)
        {
            return BeginReportArt(new ReportArtRequest
            {
                Body = new ReportArtRequestBody()
                {
                    userID = userID,
                    GameType = GameType,
                    ArtType = ArtType,
                    ArtGameID = ArtGameID,
                    ArtFile = ArtFile,
                    ArtComments = ArtComments,
                    ArtReplacement = ArtReplacement
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ReportArtResponse EndReportArt(IAsyncResult result)
        {
            return Channel.EndReportArt(result);
        }

        private IAsyncResult OnBeginReportArt(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var userID = Convert.ToString(inValues[0]);
            var gameType = (GameType)Convert.ToInt32(inValues[1]);
            var artType = (ArtType)Convert.ToInt32(inValues[2]);
            var artGameID = Convert.ToString(inValues[3]);
            var artFile = Convert.ToString(inValues[4]);
            var artComments = Convert.ToString(inValues[5]);
            var artReplacement = (ArtUploadRequestClass)inValues[6];
            return BeginReportArt(userID, gameType, artType, artGameID, artFile, artComments, artReplacement, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndReportArt(IAsyncResult result)
        {
            return new object[]
            {
                EndReportArt(result).Body.ReportArtResult
            };
        }

        private void OnReportArtCompleted(object state)
        {
            if (ReportArtCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                ReportArtCompleted(this, new ReportArtCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void ReportArtAsync(string userID, GameType GameType, ArtType ArtType, string ArtGameID, string ArtFile, string ArtComments, ArtUploadRequestClass ArtReplacement)
        {
            ReportArtAsync(userID, GameType, ArtType, ArtGameID, ArtFile, ArtComments, ArtReplacement, null);
        }

        public void ReportArtAsync(string userID, GameType GameType, ArtType ArtType, string ArtGameID, string ArtFile, string ArtComments, ArtUploadRequestClass ArtReplacement, object userState)
        {
            onBeginReportArtDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginReportArt);
            onEndReportArtDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndReportArt);
            onReportArtCompletedDelegate ??= new SendOrPostCallback(OnReportArtCompleted);

            InvokeAsync(onBeginReportArtDelegate,
                new object[] { userID, GameType, ArtType, ArtGameID, ArtFile, ArtComments, ArtReplacement },
                onEndReportArtDelegate,
                onReportArtCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GetGameNameByIdResponse GetGameNameById(GetGameNameByIdRequest request)
        {
            return Channel.GetGameNameById(request);
        }

        public string GetGameNameById(GameType type, string GameId)
        {
            return GetGameNameById(new GetGameNameByIdRequest
            {
                Body = new GetGameNameByIdRequestBody()
                {
                    type = type,
                    GameId = GameId
                }
            }).Body.GetGameNameByIdResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginGetGameNameById(GetGameNameByIdRequest request, AsyncCallback callback, object asyncState)
        {
            return Channel.BeginGetGameNameById(request, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginGetGameNameById(GameType type, string GameId, AsyncCallback callback, object asyncState)
        {
            return BeginGetGameNameById(new GetGameNameByIdRequest
            {
                Body = new GetGameNameByIdRequestBody()
                {
                    type = type,
                    GameId = GameId
                }
            }, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GetGameNameByIdResponse EndGetGameNameById(IAsyncResult result)
        {
            return Channel.EndGetGameNameById(result);
        }

        private IAsyncResult OnBeginGetGameNameById(object[] inValues, AsyncCallback callback, object asyncState)
        {
            var type = (GameType)Convert.ToInt32(inValues[0]);
            var gameId = Convert.ToString(inValues[1]);
            return BeginGetGameNameById(type, gameId, callback, RuntimeHelpers.GetObjectValue(asyncState));
        }

        private object[] OnEndGetGameNameById(IAsyncResult result)
        {
            return new object[]
            {
                EndGetGameNameById(result).Body.GetGameNameByIdResult
            };
        }

        private void OnGetGameNameByIdCompleted(object state)
        {
            if (GetGameNameByIdCompleted != null)
            {
                var invokeAsyncCompletedEventArgs = (ClientBase<OPLManagerServiceSoap>.InvokeAsyncCompletedEventArgs)state;

                GetGameNameByIdCompleted(this, new GetGameNameByIdCompletedEventArgs(
                    invokeAsyncCompletedEventArgs.Results,
                    invokeAsyncCompletedEventArgs.Error,
                    invokeAsyncCompletedEventArgs.Cancelled,
                    RuntimeHelpers.GetObjectValue(invokeAsyncCompletedEventArgs.UserState)));
            }
        }

        public void GetGameNameByIdAsync(GameType type, string GameId)
        {
            GetGameNameByIdAsync(type, GameId, null);
        }

        public void GetGameNameByIdAsync(GameType type, string GameId, object userState)
        {
            onBeginGetGameNameByIdDelegate ??= new ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate(OnBeginGetGameNameById);
            onEndGetGameNameByIdDelegate ??= new ClientBase<OPLManagerServiceSoap>.EndOperationDelegate(OnEndGetGameNameById);
            onGetGameNameByIdCompletedDelegate ??= new SendOrPostCallback(OnGetGameNameByIdCompleted);

            InvokeAsync(onBeginGetGameNameByIdDelegate,
                new object[] { type, GameId },
                onEndGetGameNameByIdDelegate,
                onGetGameNameByIdCompletedDelegate,
                RuntimeHelpers.GetObjectValue(userState));
        }

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginGetDesktopAppVersionDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndGetDesktopAppVersionDelegate;

        private SendOrPostCallback onGetDesktopAppVersionCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginServiceStatusDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndServiceStatusDelegate;

        private SendOrPostCallback onServiceStatusCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginArtSearchSingleDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndArtSearchSingleDelegate;

        private SendOrPostCallback onArtSearchSingleCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginArtSearchBatchDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndArtSearchBatchDelegate;

        private SendOrPostCallback onArtSearchBatchCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginBatchArtShareCheckDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndBatchArtShareCheckDelegate;

        private SendOrPostCallback onBatchArtShareCheckCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginArtUploadDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndArtUploadDelegate;

        private SendOrPostCallback onArtUploadCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginReportArtDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndReportArtDelegate;

        private SendOrPostCallback onReportArtCompletedDelegate;

        private ClientBase<OPLManagerServiceSoap>.BeginOperationDelegate onBeginGetGameNameByIdDelegate;

        private ClientBase<OPLManagerServiceSoap>.EndOperationDelegate onEndGetGameNameByIdDelegate;

        private SendOrPostCallback onGetGameNameByIdCompletedDelegate;
    }
}