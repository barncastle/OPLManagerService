using OPLManagerService.Services;
using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace OPLManagerService
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://oplmanager.no-ip.info/", ConfigurationName = "OPLManagerService.OPLManagerServiceSoap")]
    public interface OPLManagerServiceSoap
    {
        [OperationContract(Action = "http://oplmanager.no-ip.info/GetDesktopAppVersion", ReplyAction = "*")]
        GetDesktopAppVersionResponse GetDesktopAppVersion(GetDesktopAppVersionRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/GetDesktopAppVersion", ReplyAction = "*")]
        IAsyncResult BeginGetDesktopAppVersion(GetDesktopAppVersionRequest request, AsyncCallback callback, object asyncState);

        GetDesktopAppVersionResponse EndGetDesktopAppVersion(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/ServiceStatus", ReplyAction = "*")]
        ServiceStatusResponse ServiceStatus(ServiceStatusRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/ServiceStatus", ReplyAction = "*")]
        IAsyncResult BeginServiceStatus(ServiceStatusRequest request, AsyncCallback callback, object asyncState);

        ServiceStatusResponse EndServiceStatus(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/ArtSearchSingle", ReplyAction = "*")]
        ArtSearchSingleResponse ArtSearchSingle(ArtSearchSingleRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/ArtSearchSingle", ReplyAction = "*")]
        IAsyncResult BeginArtSearchSingle(ArtSearchSingleRequest request, AsyncCallback callback, object asyncState);

        ArtSearchSingleResponse EndArtSearchSingle(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/ArtSearchBatch", ReplyAction = "*")]
        ArtSearchBatchResponse ArtSearchBatch(ArtSearchBatchRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/ArtSearchBatch", ReplyAction = "*")]
        IAsyncResult BeginArtSearchBatch(ArtSearchBatchRequest request, AsyncCallback callback, object asyncState);

        ArtSearchBatchResponse EndArtSearchBatch(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/BatchArtShareCheck", ReplyAction = "*")]
        BatchArtShareCheckResponse BatchArtShareCheck(BatchArtShareCheckRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/BatchArtShareCheck", ReplyAction = "*")]
        IAsyncResult BeginBatchArtShareCheck(BatchArtShareCheckRequest request, AsyncCallback callback, object asyncState);

        BatchArtShareCheckResponse EndBatchArtShareCheck(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/ArtUpload", ReplyAction = "*")]
        ArtUploadResponse ArtUpload(ArtUploadRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/ArtUpload", ReplyAction = "*")]
        IAsyncResult BeginArtUpload(ArtUploadRequest request, AsyncCallback callback, object asyncState);

        ArtUploadResponse EndArtUpload(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/ReportArt", ReplyAction = "*")]
        ReportArtResponse ReportArt(ReportArtRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/ReportArt", ReplyAction = "*")]
        IAsyncResult BeginReportArt(ReportArtRequest request, AsyncCallback callback, object asyncState);

        ReportArtResponse EndReportArt(IAsyncResult result);

        [OperationContract(Action = "http://oplmanager.no-ip.info/GetGameNameById", ReplyAction = "*")]
        GetGameNameByIdResponse GetGameNameById(GetGameNameByIdRequest request);

        [OperationContract(AsyncPattern = true, Action = "http://oplmanager.no-ip.info/GetGameNameById", ReplyAction = "*")]
        IAsyncResult BeginGetGameNameById(GetGameNameByIdRequest request, AsyncCallback callback, object asyncState);

        GetGameNameByIdResponse EndGetGameNameById(IAsyncResult result);
    }
}