using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.Util;
using JMeter_Manager.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JMeterManager.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            Uri connecturi = new Uri(Environment.GetEnvironmentVariable("ActiveMQ-Server")); 

            Console.WriteLine("About to connect to " + connecturi);

            // NOTE: ensure the nmsprovider-activemq.config file exists in the executable folder.
            IConnectionFactory factory = new NMSConnectionFactory(connecturi);

            Console.WriteLine("UserName: " + Environment.GetEnvironmentVariable("ActiveMQ-UserName"));
            Console.WriteLine("Password: " + Environment.GetEnvironmentVariable("ActiveMQ-Password"));

            using (IConnection connection = factory.CreateConnection())
            using (ISession session = connection.CreateSession())
            {

                IDestination destination = SessionUtil.GetDestination(session, "queue://JMeter");
                Console.WriteLine("Using destination: " + destination);

                // Create a consumer and producer
                using (IMessageProducer producer = session.CreateProducer(destination))
                {
                    // Start the connection so that messages will be processed.
                    connection.Start();
                    producer.DeliveryMode = MsgDeliveryMode.Persistent;

                    // Send a message
                    ITextMessage request = session.CreateTextMessage(JMSMessage.RequestId);
                    request.NMSCorrelationID = new Guid().ToString();
                    request.Properties["TeamID"] = "DevOps";
                    request.Properties["Application"] = "DevOps-Testing";

                    for (int i = 0; i < 100; i++)
                    {
                        producer.Send(request);
                    }
                    connection.Close();
                }
            }
            return "Done";
        }
    }
}
