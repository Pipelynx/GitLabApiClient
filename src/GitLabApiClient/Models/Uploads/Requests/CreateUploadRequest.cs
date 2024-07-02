using System.IO;

namespace GitLabApiClient.Models.Uploads.Requests
{
    /// <summary>
    /// A upload (file) for Gitlab, which can be embedded via markdown
    /// </summary>
    public sealed class CreateUploadRequest
    {
        /// <summary>
        /// Creates a new instance if the create upload request
        /// </summary>
        /// <param name="stream">The stream to be uploaded</param>
        /// <param name="fileName">The name of the file being uploaded</param>
        public CreateUploadRequest(Stream stream, string fileName)
        {
            Stream = stream;
            FileName = fileName;
            IsAvatar = false;
        }

        /// <summary>
        /// The stream to be uploaded
        /// </summary>
        public Stream Stream { get; }

        /// <summary>
        /// The name of the file being uploaded
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Whether the upload is a project avatar
        /// </summary>
        public bool IsAvatar { get; set; }
    }
}
