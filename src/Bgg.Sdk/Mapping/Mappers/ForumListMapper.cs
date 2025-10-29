
using Bgg.Sdk.Core.ForumList;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class ForumListMapper
    {
        [MapProperty(nameof(ForumList.ForumElement.LastPostDateString), nameof(Models.ForumList.Forum.LastPostDate))]
        private static partial Models.ForumList.Forum ToForum(ForumList.ForumElement model);
        public static partial Models.ForumList ToForumList(ForumList model);
    }
}
