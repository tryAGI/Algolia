
#nullable enable

namespace Algolia.Recommend
{
    public partial interface IAlgoliaRecommendClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}