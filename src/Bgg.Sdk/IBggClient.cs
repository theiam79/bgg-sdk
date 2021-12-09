using Bgg.Sdk.Core.HotItems;
using Bgg.Sdk.Models;

namespace Bgg.Sdk
{
    /// <summary>
    /// A client to handle making requests to the BGG XMLAPI2 and map the responses
    /// </summary>
    public interface IBggClient
    {
        /// <summary>
        /// Get the collection for a given user
        /// </summary>
        /// <param name="queryParameters">The options for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the collection information</returns>
        Task<Collection> CollectionAsync(Core.Collection.QueryParameters queryParameters);
        /// <summary>
        /// Get the collection for the specificed <paramref name="username"/> using the default query parameters.
        /// </summary>
        /// <param name="username">The username to retrieve collection info for</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the collection information</returns>
        Task<Collection> CollectionAsync(string username);
        /// <summary>
        /// Get the information for a single family using the default query parameters.
        /// </summary>
        /// <param name="id">The id of the family</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the family information</returns>
        Task<FamilyCollection> FamilyAsync(int id);
        /// <summary>
        /// Get information for the specified families
        /// </summary>
        /// <param name="queryParameters">The options for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the family information</returns>
        Task<FamilyCollection> FamilyAsync(Core.Family.QueryParameters queryParameters);
        /// <summary>
        /// Get information for the specified forum using the default query parameters.
        /// </summary>
        /// <param name="id">The id of the forum</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the forum information</returns>
        Task<Forum> ForumAsync(int id);
        /// <summary>
        /// Get information for the specified forum.
        /// </summary>
        /// <param name="queryParameters">The options for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the forum information</returns>
        Task<Forum> ForumAsync(Core.Forum.QueryParameters queryParameters);
        /// <summary>
        /// Get a list of forums for a specific object using the default query parameters.
        /// </summary>
        /// <param name="id">The id of the object</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the forumlist</returns>
        Task<ForumList> ForumListAsync(int id);
        /// <summary>
        /// Get a list of forums for a specific object.
        /// </summary>
        /// <param name="queryParameters">The options for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the forumlist</returns>
        Task<ForumList> ForumListAsync(Core.ForumList.QueryParameters queryParameters);
        /// <summary>
        /// Get information for the specified guild using the default query parameters.
        /// </summary>
        /// <param name="id">The id of the guild</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the guild information</returns>
        Task<Guild> GuildAsync(int id);
        /// <summary>
        /// Get information for the specified guild.
        /// </summary>
        /// <param name="queryParameters">The options for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the guild information</returns>
        Task<Guild> GuildAsync(Core.Guild.QueryParameters queryParameters);
        /// <summary>
        /// Get the hotlist for a givent type using the default query parameters.
        /// </summary>
        /// <param name="hotListType">The hotlist type</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the hotlist</returns>
        Task<HotList> HotListAsync(HotListType hotListType);
        /// <summary>
        /// Get the hotlist for a given type.
        /// </summary>
        /// <param name="queryParameters">The options for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the hotlist</returns>
        Task<HotList> HotListAsync(QueryParameters queryParameters);
        /// <summary>
        /// Gets play information for a specified object using the default query parameters.
        /// </summary>
        /// <param name="id">The object to retrieve play information for</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the play information</returns>
        Task<PlayInfo> PlayInfoAsync(int id);
        /// <summary>
        /// Gets play information for a specified user and/or object.
        /// </summary>
        /// <param name="queryParameters">The options to use for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the play information</returns>
        Task<PlayInfo> PlayInfoAsync(Core.Plays.QueryParameters queryParameters);
        /// <summary>
        /// Gets play information for a specified user using the default query parameters.
        /// </summary>
        /// <param name="username">The user to retrieve play information for</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the play information</returns>
        Task<PlayInfo> PlayInfoAsync(string username);
        /// <summary>
        /// Gets play information for a specified user and object using the default query parameters.
        /// </summary>
        /// <param name="username">The user to retrieve play information for</param>
        /// <param name="id">The object to retrieve play information for</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the play information</returns>
        Task<PlayInfo> PlayInfoAsync(string username, int id);
        /// <summary>
        /// Search for items in the BGG database.
        /// </summary>
        /// <param name="queryParameters">The optiosn to use for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the search results</returns>
        Task<SearchResult> SearchAsync(Core.Search.QueryParameters queryParameters);
        /// <summary>
        /// Search for items in the BGG database using the default query parameters.
        /// </summary>
        /// <param name="searchTerm">The name to search for</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the search results</returns>
        Task<SearchResult> SearchAsync(string searchTerm);
        /// <summary>
        /// Get information for the specified thing using the default query parameters.
        /// </summary>
        /// <param name="id">The id of the thing</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the thing information</returns>
        Task<ThingCollection> ThingAsync(int id);
        /// <summary>
        /// Get information for the specified thing(s).
        /// </summary>
        /// <param name="queryParameters">The options to use for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the thing information</returns>
        Task<ThingCollection> ThingAsync(Core.Thing.QueryParameters queryParameters);
        /// <summary>
        /// Get information for the specified thread using the default query parameters.
        /// </summary>
        /// <param name="id">The id of the thread</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the thread information</returns>
        Task<Models.Thread> ThreadAsync(int id);
        /// <summary>
        /// Get information for the specified thread.
        /// </summary>
        /// <param name="queryParameters">The options to use for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the thread information</returns>
        Task<Models.Thread> ThreadAsync(Core.Thread.QueryParameters queryParameters);
        /// <summary>
        /// Get information for the specified user using the default query parameters.
        /// </summary>
        /// <param name="username">The username to retrieve information for</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the user information</returns>
        Task<Models.User> UserAsync(string username);
        /// <summary>
        /// Get information for the specified user.
        /// </summary>
        /// <param name="queryParameters">The options to use for the request</param>
        /// <returns>A <see cref="Task"/> representing the query. The task result contains the user information</returns>
        Task<User> UserAsync(Core.User.QueryParameters queryParameters);
    }
}