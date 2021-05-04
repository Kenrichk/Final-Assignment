using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using finalGetFilm;
using Amazon.Lambda.APIGatewayEvents;

namespace finalGetFilm.Tests
{
    public class FunctionTest
    {
        [Fact]
        public async Task<string> t()
        {
            return "The Wind Rises";
        }
        public void TestToUpperFunction()
        {
            
            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            Task<string> e=t();
            APIGatewayProxyRequest input = new APIGatewayProxyRequest
            {
                Body = "The Wind Rises",
            };
            //input.QueryStringParameters.Add("title","The Wind Rises");
            var filmSearch = function.FunctionHandler(input, context);

            Assert.Contains(e, (IEnumerable<Task<string>>)filmSearch);
        }
    }
}
