// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateSetup
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Integration technology for deploying R analytics inside web, desktop,
    /// mobile, and dashboard applications as well as backend systems. Turn
    /// your R scripts into analytics web services, so code can be easily
    /// executed by applications running on a secure server.
    ///
    /// The core APIs can be grouped into several categories, including:
    /// [Authentication](#authentication-apis), [Web
    /// Services](#services-management-apis), [Sessions](#session-apis),
    /// [Snapshots](#snapshot-apis), and [Status](#status-apis).
    ///
    /// </summary>
    public partial interface IMRSServer : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Login User
        /// </summary>
        /// <remarks>
        /// Logs the user in.
        /// </remarks>
        /// <param name='loginRequest'>
        /// Login properties for athentication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AccessTokenResponse>> LoginWithHttpMessagesAsync(LoginRequest loginRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Refresh User Access Token
        /// </summary>
        /// <remarks>
        /// The user renews access token and refresh token.
        /// </remarks>
        /// <param name='renewTokenRequest'>
        /// Renew access token properties for athentication.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AccessTokenResponse>> RenewTokenWithHttpMessagesAsync(RenewTokenRequest renewTokenRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete User Access Token
        /// </summary>
        /// <remarks>
        /// The user revokes a refresh token.
        /// </remarks>
        /// <param name='refreshToken'>
        /// The refresh token to be revoked.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AccessTokenResponse>> RevokeRefreshTokenWithHttpMessagesAsync(string refreshToken, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Services
        /// </summary>
        /// <remarks>
        /// Lists all the published services.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<WebService>>> GetAllWebServicesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create Service by `name`
        /// </summary>
        /// <remarks>
        /// Publish the web services for the logged in user with given name and
        /// a unique version.
        /// </remarks>
        /// <param name='name'>
        /// name of the published web service.
        /// </param>
        /// <param name='publishRequest'>
        /// Publish Web Service request details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PublishWebServiceWithHttpMessagesAsync(string name, PublishWebServiceRequest publishRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Service by `name`
        /// </summary>
        /// <remarks>
        /// Lists all the published services with the provided `name`.
        /// </remarks>
        /// <param name='name'>
        /// name of the published web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<WebService>>> GetAllWebServiceVersionsByNameWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create realtime web service by `name`
        /// </summary>
        /// <remarks>
        /// Publish the realtime web services for the logged in user with given
        /// name and a unique version.
        /// </remarks>
        /// <param name='name'>
        /// name of the realtime web service to be published.
        /// </param>
        /// <param name='model'>
        /// The binary serialized model to be used for realtime web service.
        /// </param>
        /// <param name='description'>
        /// The description of the realtime web service to be published.
        /// </param>
        /// <param name='operationId'>
        /// Swagger operationId/alias for the realtime web service to be
        /// published.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PublishRealtimeWebServiceByNameWithHttpMessagesAsync(string name, Stream model, string description = default(string), string operationId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create Service by `name` and `version`
        /// </summary>
        /// <remarks>
        /// Publish the web service for the logged in user with given name and
        /// version.
        /// </remarks>
        /// <param name='name'>
        /// name of the published web service.
        /// </param>
        /// <param name='version'>
        /// version of the published web service.
        /// </param>
        /// <param name='publishRequest'>
        /// Publish Service request details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PublishWebServiceVersionWithHttpMessagesAsync(string name, string version, PublishWebServiceRequest publishRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Patch Service
        /// </summary>
        /// <remarks>
        /// Updates the published service.
        /// </remarks>
        /// <param name='name'>
        /// The name of the published web service.
        /// </param>
        /// <param name='version'>
        /// The version of the published web service.
        /// </param>
        /// <param name='patchRequest'>
        /// Publish Web Service request details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PatchWebServiceVersionWithHttpMessagesAsync(string name, string version, PublishWebServiceRequest patchRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Service by `name` and `version`
        /// </summary>
        /// <remarks>
        /// Lists all the published services with the provided `name` and
        /// `version`.
        /// </remarks>
        /// <param name='name'>
        /// The name of the published web service.
        /// </param>
        /// <param name='version'>
        /// The version of the published web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<WebService>>> GetWebServiceVersionWithHttpMessagesAsync(string name, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Service
        /// </summary>
        /// <remarks>
        /// Deletes the published web service for the logged in user.
        /// </remarks>
        /// <param name='name'>
        /// The name of the published web service.
        /// </param>
        /// <param name='version'>
        /// The version of the published web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteWebServiceVersionWithHttpMessagesAsync(string name, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create realtime web service by `name` and `version`.
        /// </summary>
        /// <remarks>
        /// Publish the realtime web services for the logged in user with given
        /// name and given version.
        /// </remarks>
        /// <param name='name'>
        /// The name of the realtime web service to be published.
        /// </param>
        /// <param name='version'>
        /// The version of the realtime web service to be published.
        /// </param>
        /// <param name='model'>
        /// The binary serialized model to be used for realtime web service.
        /// </param>
        /// <param name='description'>
        /// The description of the realtime web service to be published.
        /// </param>
        /// <param name='operationId'>
        /// Swagger operationId/alias for the realtime web service to be
        /// published.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PublishRealtimeWebServiceByNameVersionWithHttpMessagesAsync(string name, string version, Stream model, string description = default(string), string operationId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Patch realtime web service
        /// </summary>
        /// <remarks>
        /// Updates the published realtime web service.
        /// </remarks>
        /// <param name='name'>
        /// Name of the published realtime web service
        /// </param>
        /// <param name='version'>
        /// Version of the published realtime web service
        /// </param>
        /// <param name='description'>
        /// The description of the realtime web service to be published.
        /// </param>
        /// <param name='operationId'>
        /// Swagger operationId/alias for the realtime web service to be
        /// published.
        /// </param>
        /// <param name='model'>
        /// The binary serialized model to be used for realtime web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PatchRealtimeWebServiceByNameVersionWithHttpMessagesAsync(string name, string version, string description = default(string), string operationId = default(string), Stream model = default(Stream), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get API Swagger
        /// </summary>
        /// <remarks>
        /// Returns a _Swagger_ `swagger.json` describing a published web
        /// service's API capabilities.
        /// </remarks>
        /// <param name='name'>
        /// The name of the published web service.
        /// </param>
        /// <param name='version'>
        /// The version of the published web service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IDictionary<string, object>>> GetWebServiceSwaggerWithHttpMessagesAsync(string name, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create Session
        /// </summary>
        /// <remarks>
        /// Create a new session.
        /// </remarks>
        /// <param name='createSessionRequest'>
        /// Properties of the new session.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CreateSessionResponse>> CreateSessionWithHttpMessagesAsync(CreateSessionRequest createSessionRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Sessions
        /// </summary>
        /// <remarks>
        /// Lists all existing sessions for the current user.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Session>>> ListSessionsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Execute Code
        /// </summary>
        /// <remarks>
        /// Executes code in the context of a specific session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='executeRequest'>
        /// code that needs to be executed
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ExecuteResponse>> ExecuteCodeWithHttpMessagesAsync(string id, ExecuteRequest executeRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Session
        /// </summary>
        /// <remarks>
        /// Close a session and releases all it's associated resources.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> CloseSessionWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Session by `force`
        /// </summary>
        /// <remarks>
        /// Attempt to _kill_ a session and releases all it's associated
        /// resources.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> CloseSessionByForceWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Console Output
        /// </summary>
        /// <remarks>
        /// Returns the console output for the current or last execution.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ConsoleOutputResponse>> GetSessionConsoleOutputWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get History
        /// </summary>
        /// <remarks>
        /// Lists all history for a specific session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<string>>> ListSessionHistoryWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Load File
        /// </summary>
        /// <remarks>
        /// Loads a file into the session working directory. The uploaded file
        /// name is extracted from the file and if another file with the same
        /// name already exists in the working directory, the file will be
        /// overwritten.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='file'>
        /// The file to be uploaded to the workspace.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> UploadSessionFileWithHttpMessagesAsync(string id, Stream file, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Files
        /// </summary>
        /// <remarks>
        /// Lists all files of a specific session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<string>>> ListSessionFilesWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get File
        /// </summary>
        /// <remarks>
        /// Downloads a file from a session as a stream.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='fileName'>
        /// Name of the file.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> GetSessionFileWithHttpMessagesAsync(string id, string fileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete File
        /// </summary>
        /// <remarks>
        /// Delete a file from a session's working directory.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='fileName'>
        /// Name of the file.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteSessionFileWithHttpMessagesAsync(string id, string fileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Workspace Object Names
        /// </summary>
        /// <remarks>
        /// Lists all object names of a specific session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<string>>> ListWorkspaceObjectsWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create Workspace Object
        /// </summary>
        /// <remarks>
        /// Upload a serialized object into the session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='objectName'>
        /// Name of the object.
        /// </param>
        /// <param name='serializedObject'>
        /// The binary file that contains a serialized object to be uploaded.
        /// The binary file `Content-Type` should be
        /// `application/octet-stream`.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> SetWorkspaceObjectWithHttpMessagesAsync(string id, string objectName, string serializedObject, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Workspace Object
        /// </summary>
        /// <remarks>
        /// Returns an object from a session. For the `R` runtime, the object
        /// is serialized as a `.RData` file stream. For the `Python` runtime,
        /// the object is serialized as a `.dill` file stream.
        ///
        /// **Important** Python objects are not guaranteed to be compatible
        /// with versions other than Python `3.5`.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='objectName'>
        /// Name of the R object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> GetWorkspaceObjectWithHttpMessagesAsync(string id, string objectName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Workspace Object
        /// </summary>
        /// <remarks>
        /// Delete an object from a session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='objectName'>
        /// Name of the object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteWorkspaceObjectWithHttpMessagesAsync(string id, string objectName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create Snapshot
        /// </summary>
        /// <remarks>
        /// Create a snapshot from session by saving the workspace and all
        /// files in the working directory into zip file, the return value will
        /// be the created snapshot Id.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='createSnapshotRequest'>
        /// Properties of the new snapshot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CreateSnapshotResponse>> CreateSnapshotWithHttpMessagesAsync(string id, CreateSnapshotRequest createSnapshotRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Load Snapshot
        /// </summary>
        /// <remarks>
        /// Loads a snapshot into session by merging the workspace of the saved
        /// snapshot and target session. It will override the files in the
        /// working directory as well.
        ///
        /// **Note - ** You can only load R snapshots to R session and Python
        /// snapshots to a Python session.
        /// </remarks>
        /// <param name='id'>
        /// Id of the session.
        /// </param>
        /// <param name='snapshotId'>
        /// Id of the saved snapshot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> LoadSnapshotWithHttpMessagesAsync(string id, string snapshotId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cancel Session
        /// </summary>
        /// <remarks>
        /// Cancel a session by aborting the current execution operation,
        /// afterwards the session will be alive and ready to accept any calls.
        /// Cancel session is **not** guaranteed to interrupt the execution
        /// </remarks>
        /// <param name='id'>
        /// Id of the session to cancel.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> CancelSessionWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Snapshots
        /// </summary>
        /// <remarks>
        /// List all the snapshots for the current user and display some info
        /// such as Id, display name, creation time, zip file size and owner
        /// for this snapshot.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Snapshot>>> ListSnapshotsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Snapshot
        /// </summary>
        /// <remarks>
        /// Get the snapshot content as zip file stream (zip file containing
        /// the working directory files and the workspace file)
        /// </remarks>
        /// <param name='id'>
        /// Id of the snapshot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> GetSnapshotContentWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete Snapshot
        /// </summary>
        /// <remarks>
        /// Delete a snapshot permanently and also it's content (zip file
        /// containing the working directory files and the workspace file)
        /// </remarks>
        /// <param name='id'>
        /// Id of the snapshot.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> DeleteSnapshotWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Status
        /// </summary>
        /// <remarks>
        /// Gets the current health of the system.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<StatusResponse>> StatusWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}