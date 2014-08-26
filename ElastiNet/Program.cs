using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace ElastiNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ElasticsearchClient();
            Console.ReadLine();
        }
    }
}
