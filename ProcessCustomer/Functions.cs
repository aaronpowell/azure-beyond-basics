﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace ProcessCustomer
{
  public class Functions
  {
    // This function will get triggered/executed when a new message is written 
    // on an Azure Queue called queue.
    public static void ProcessQueueMessage([QueueTrigger("customerqueue")] string message, TextWriter log)
    {
      // processing + send email
      throw new ApplicationException("ugh!!");
      log.WriteLine(message);
    }
  }
}
