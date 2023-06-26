using pinecone;
using pinecone.Models;

namespace PineconeEmbeddings
{
    public class PineconeService
    {
        private readonly PineconeProvider pineconeClient = new PineconeProvider("f909df8a-53aa-49b7-a25b-f428a9528215", "us-east4-gcp");
        private readonly string indexName = "chatbot1-index";
        private readonly string projectName = "56a1186";

        public string FindSimilarText(List<double> questionEmbeddings)
        {
            var queryRequest = new QueryRequest()
            {
                TopK = 2,
                Vector = questionEmbeddings,
                IncludeMetadata = true,
                IncludeValues= true,
            };
            var result = pineconeClient.GetQuery(indexName, projectName, queryRequest).Result;
            var text1 = result.Matches[0].Metadata[result.Matches[0].Id];
            var text2 = result.Matches[1].Metadata[result.Matches[1].Id];
            
            var combination = text1 + " " + text2;
            var combinationWithoutBlanks = combination.Replace("\n", "\\n").Replace("\u00AE", "\\u00AE");

            return combinationWithoutBlanks;
        }
    }
}
