using FrameFisher.Domain;

namespace FrameFisher.Services;

public interface IRekaVisionService
{
    /// <summary>
    /// Retrieves a list of videos from the Reka Vision service
    /// </summary>
    /// <returns>A list of Video objects</returns>
    Task<Video[]> GetAllVideos();

    /// <summary>
    /// Uploads a video to the Reka Vision service via URL
    /// </summary>
    /// <param name="videoUrl">The URL of the video to upload</param>
    /// <param name="videoName">The name for the video</param>
    /// <returns>The uploaded video information</returns>
    Task<Video> AddVideoWithURL(string videoUrl, string videoName);

    /// <summary>
    /// Uploads a video file to the Reka Vision service
    /// </summary>
    /// <param name="file">The video file to upload (from Blazor file input)</param>
    /// <param name="videoName">The name for the video</param>
    /// <param name="enableThumbnails">Whether to generate thumbnails for video chunks (optional, defaults to false)</param>
    /// <returns>The uploaded video information</returns>
    Task<Video> AddVideoWithFile(IFormFile file, string videoName, bool enableThumbnails = false);

    /// <summary>
    /// Deletes videos from the Reka Vision service
    /// </summary>
    /// <param name="videoIds">The IDs of the videos to delete</param>
    /// <returns>A task representing the asynchronous operation</returns>
    Task DeleteVideos(IEnumerable<Guid> videoIds);

    /// <summary>
    /// Searches for video segments matching the query
    /// </summary>
    /// <param name="query">The search query</param>
    /// <param name="threshold">The similarity threshold (optional, defaults to 0.6)</param>
    /// <returns>A list of search results with timestamps</returns>
    Task<List<SearchResult>> Search(string query, double threshold = 0.6);

    /// <summary>
    /// Asks a question about a specific video
    /// </summary>
    /// <param name="videoId">The ID of the video to ask about</param>
    /// <param name="question">The question to ask</param>
    /// <returns>The answer to the question</returns>
    Task<QAAnswer> AskQuestion(string videoId, string question);
}