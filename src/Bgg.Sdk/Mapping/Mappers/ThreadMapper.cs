
using Bgg.Sdk.Core.Thread;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class ThreadMapper
    {
        [MapProperty(nameof(ThreadElement.Link), nameof(Models.Thread.Url))]
        [MapProperty(nameof(ThreadElement.ArticleCollection.Articles), nameof(Models.Thread.Articles))]
        public static partial Models.Thread ToThread(ThreadElement model);

        [MapProperty(nameof(ThreadElement.ArticleCollectionElement.ArticleElement.Link), nameof(Models.Thread.Article.Url))]
        private static partial Models.Thread.Article ToArticle(ThreadElement.ArticleCollectionElement.ArticleElement model);
    }
}
