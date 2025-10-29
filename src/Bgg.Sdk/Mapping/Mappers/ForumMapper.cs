
using Bgg.Sdk.Core.Forum;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class ForumMapper
    {
        [MapProperty(nameof(Forum.LastPostDateString), nameof(Models.Forum.LastPostDate))]
        [MapPropertyFromSource(nameof(Models.Forum.Threads), Use = nameof(CreatePagedCollection))]
        public static partial Models.Forum ToForum(Forum model);

        private static Models.PagedCollection<Models.Forum.Thread> CreatePagedCollection(Forum forum)
        {
            return new Models.PagedCollection<Models.Forum.Thread>
            {
                Total = forum.NumberOfThreads,
                Page = forum.Page,
                Items = forum.ThreadCollection.Threads.ConvertAll(ToThread)
            };
        }

        [MapProperty(nameof(Forum.ThreadCollectionElement.ThreadElement.PostDateString), nameof(Models.Forum.Thread.CreateDate))]
        [MapProperty(nameof(Forum.ThreadCollectionElement.ThreadElement.LastPostDateString), nameof(Models.Forum.Thread.LastPostDate))]
        private static partial Models.Forum.Thread ToThread(Forum.ThreadCollectionElement.ThreadElement model);
    }
}
