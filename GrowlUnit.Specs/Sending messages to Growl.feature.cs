// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace GrowlUnit.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Sending messages to growl")]
    public partial class SendingMessagesToGrowlFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Sending messages to Growl.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sending messages to growl", "In order to get notified of events that happen\r\nAs a super cool developer\r\nI want" +
                    " to be able to send message to growl", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a message to growl")]
        public virtual void SendingAMessageToGrowl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a message to growl", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I have a growl application with the name of \"Super Cool Growler\"");
#line 9
testRunner.And("there it has a notification type of \"Sample Message\" with and id of \"sample_messa" +
                    "ge\"");
#line 10
testRunner.And("the Growl application is registered");
#line 11
testRunner.When("I send a \"sample_message\" message \"Foo\" with a title \"Bar\"");
#line 12
testRunner.Then("you should have see it pop up");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
