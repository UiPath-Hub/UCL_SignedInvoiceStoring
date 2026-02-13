using UCL_SignedInvoiceStoring.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace UCL_SignedInvoiceStoring
{
    public static class publicMethod{
        public static string ConvertFileToBase64String(FileInfo fileInfo)
        {
            // Check if the file exists
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException("The specified file was not found.", fileInfo.FullName);
            }
        
            // Read the file's content into a byte array
            byte[] fileBytes = File.ReadAllBytes(fileInfo.FullName);
        
            // Convert the byte array to a Base64 string
            string base64String = Convert.ToBase64String(fileBytes);
        
            return base64String;
        }
    }
    

}