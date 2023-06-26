
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

            string filePath = @"C:\Users\alexis.essoureifi\Desktop\ITIL_4_MP_in_1000_words_CDS.pdf";

            var pineconeClient = new PineconeProvider("f909df8a-53aa-49b7-a25b-f428a9528215", "us-east4-gcp");

            var indexName = "chatbot1-index";

            var projectName = "56a1186";


            var texts = TextMethods.PDFReaderAndSplitter(filePath);

            var upsertRequest = TextMethods.FillVectorsToRequest(texts);

            var result = pineconeClient.Upsert(indexName, projectName, upsertRequest).Result;

            //var result2 = pineconeClient.DescribeIndex(indexName).Result;

            //Console.WriteLine(result2);

        }


    }
}
