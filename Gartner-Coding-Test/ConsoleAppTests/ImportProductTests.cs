using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class ImportProductTests
    {
        [TestMethod()]
        public void importProductDataTest()
        {
            string fp = "D:/capterra.yaml";
            ImportProduct.importProductData(fp);
    
        }
    }
}