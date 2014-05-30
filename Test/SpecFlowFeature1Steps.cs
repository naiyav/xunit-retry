﻿using System;
using TechTalk.SpecFlow;
using Xunit;
namespace XUnitTestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        static int tentou = 0;
        [When]
        public void WhenITrySomething()
        {
            tentou++;
            Console.WriteLine("Tentou " + tentou);
            Assert.True(tentou >= 5);
        }
        [When]
        public void WhenIDoSomething()
        {
            Assert.True(true);
        }
    }
}