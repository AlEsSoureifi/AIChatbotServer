
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pinecone;
using System;

namespace HelperMethods
{
    internal class Program
    {

        public static void Main()
        {

            string filePath = @"C:\Users\some.user\Desktop\somefile.pdf";

            var pineconeClient = new PineconeProvider("api key value", "api key environment");

            var indexName = "index name";

            var projectName = "Project name from pinecone";


            var texts = TextMethods.PDFReaderAndSplitter(filePath);

            var upsertRequest = TextMethods.FillVectorsToRequest(texts);

            var result = pineconeClient.Upsert(indexName, projectName, upsertRequest).Result;

            //var result2 = pineconeClient.DescribeIndex(indexName).Result;

            //Console.WriteLine(result2);

        }


    }
}
