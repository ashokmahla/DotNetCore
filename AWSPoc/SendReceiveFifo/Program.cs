using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Amazon.SQS.Model;
using Amazon.SQS;
using Amazon;

namespace SendReceiveFifo
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }
        private static async Task MainAsync(string[] args)
        {
            //var t = await SQSSendMessage();            
            var d = await SQSDeleteMessage();           
        }

        public static Task<SendMessageResponse> SQSSendMessage()
        {
            Task<SendMessageResponse> tsss = null;
            try
            {
                var endpoint = RegionEndpoint.GetBySystemName("us-east-2");

                var client = new AmazonSQSClient("AKIAJK6CRL3HNISC73OA", "cxEpaj4xIxHYk5q5VS4ivMcSivlKXPoNkDUoHFh2", endpoint);

                var request = new SendMessageRequest
                {

                    //DelaySeconds = (int) TimeSpan.FromSeconds (5).TotalSeconds,
                    MessageAttributes = new Dictionary<string, MessageAttributeValue> {
                            {
                                "MyNameAttribute",
                                new MessageAttributeValue {DataType = "String", StringValue = "John Doe" }
                            },
                            {
                                "MyAddressAttribute",
                                new MessageAttributeValue { DataType = "String", StringValue = "123 Main St." }
                            },
                            {
                                "MyRegionAttribute",
                                new MessageAttributeValue { DataType = "String", StringValue = "Any Town, United States" }
                            }
                        },
                    MessageBody = "John Doe customer information.",
                    MessageGroupId = "58647",
                    MessageDeduplicationId = "121",
                    QueueUrl = "https://sqs.us-east-2.amazonaws.com/107430047045/mexicoqueue.fifo"
                };

                tsss = client.SendMessageAsync(request);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return tsss;

        }

        public static Task<ReceiveMessageResponse> SQSReceiveMessage()

        {
            var endpoint = RegionEndpoint.GetBySystemName("us-east-2");
            var client = new AmazonSQSClient("AKIAJK6CRL3HNISC73OA", "cxEpaj4xIxHYk5q5VS4ivMcSivlKXPoNkDUoHFh2", endpoint);

            var request = new ReceiveMessageRequest

            {

                AttributeNames = new List<string>() { "All" },

                MaxNumberOfMessages = 5,

                QueueUrl = "https://sqs.us-east-2.amazonaws.com/107430047045/mexicoqueue.fifo",

                VisibilityTimeout = (int)TimeSpan.FromMinutes(10).TotalSeconds,

                WaitTimeSeconds = (int)TimeSpan.FromSeconds(5).TotalSeconds,


            };

            return client.ReceiveMessageAsync(request);


        }

        public static Task<DeleteMessageResponse> SQSDeleteMessage()
        {
            var endpoint = RegionEndpoint.GetBySystemName("us-east-2");
            var client = new AmazonSQSClient("AKIAJK6CRL3HNISC73OA", "cxEpaj4xIxHYk5q5VS4ivMcSivlKXPoNkDUoHFh2", endpoint);
            var response = SQSReceiveMessage();

            Task<DeleteMessageResponse> delResponse = null;
            
            if (response.Result.Messages.Count > 0)
            {
                foreach (var message in response.Result.Messages)
                {
                    Console.Write("Message ID '" + message.MessageId + "' ");

                    var delRequest = new DeleteMessageRequest
                    {
                         QueueUrl = "https://sqs.us-east-2.amazonaws.com/107430047045/mexicoqueue.fifo",
                        ReceiptHandle = message.ReceiptHandle
                    };

                     delResponse = client.DeleteMessageAsync(delRequest);
                }
            }
            else
            {
               
                Console.WriteLine("No messages to delete.");
            }

             return delResponse;
             
        }
    }
}
