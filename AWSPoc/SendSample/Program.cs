// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SendSample {
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System;
    using Amazon.SQS.Model;
    using Amazon.SQS;
    using Amazon;

    public class Program {
        public static void Main (string[] args) {
            MainAsync (args).GetAwaiter ().GetResult ();
        }

        private static async Task MainAsync (string[] args) {
           var t = await SQSSendMessage ();
           var s = await SQSReceiveMessage();           
        }
        public static Task<SendMessageResponse> SQSSendMessage () {
            Task<SendMessageResponse> tsss = null ;
            try {
                var sqsConfig = new AmazonSQSConfig ();
                sqsConfig.ServiceURL = "https://sqs.us-east-1.amazonaws.com";

                var endpoint = RegionEndpoint.GetBySystemName ("us-east-1");

                var client = new AmazonSQSClient ("AKIAJK6CRL3HNISC73OA", "cxEpaj4xIxHYk5q5VS4ivMcSivlKXPoNkDUoHFh2", endpoint);

                var request = new SendMessageRequest {
                    DelaySeconds = (int) TimeSpan.FromSeconds (5).TotalSeconds,
                        MessageAttributes = new Dictionary<string, MessageAttributeValue> {
                            {
                                "MyNameAttribute",
                                new MessageAttributeValue { DataType = "String", StringValue = "John Doe" }
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
                        //QueueUrl = "https://sqs.us-east-1.amazonaws.com/80398EXAMPLE/MyTestQueue"
                        QueueUrl = "https://sqs.us-east-1.amazonaws.com/107430047045/mexicotesting"
                };

              tsss =   client.SendMessageAsync (request);
            } catch (Exception ex) {
                Console.Write (ex.Message);
            }
            return tsss;

        }

        public static Task<ReceiveMessageResponse> SQSReceiveMessage ()

        {
            var endpoint = RegionEndpoint.GetBySystemName ("us-east-1");
            var client = new AmazonSQSClient ("AKIAJK6CRL3HNISC73OA", "cxEpaj4xIxHYk5q5VS4ivMcSivlKXPoNkDUoHFh2", endpoint);

            var request = new ReceiveMessageRequest

            {

                AttributeNames = new List<string> () { "All" },

                MaxNumberOfMessages = 5,

                QueueUrl = "https://sqs.us-east-1.amazonaws.com/107430047045/mexicotesting",

                VisibilityTimeout = (int) TimeSpan.FromMinutes (10).TotalSeconds,

                WaitTimeSeconds = (int) TimeSpan.FromSeconds (5).TotalSeconds

            };

            return   client.ReceiveMessageAsync (request);
            

        }
    }
}