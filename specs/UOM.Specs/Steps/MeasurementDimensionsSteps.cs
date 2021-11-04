using System;
using FluentAssertions;
using RestSharp;
using RestSharp.Authenticators;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UOM.Specs.Models;

namespace UOM.Specs.Steps
{
    [Binding]
    public class MeasurementDimensionsSteps
    {
        private long _createdId;
        private readonly RestClient _client = new RestClient("http://localhost:5000/");
        private MeasurmentDimension _expectedDimension;

        [Given(@"I have entered as a procurement manager")]
        public void GivenIHaveEnteredAsAProcurementManager()
        {
        }
        
        [When(@"I define the following dimension")]
        public void WhenIDefineTheFollowingDimension(Table table)
        {
            _expectedDimension = table.CreateInstance<MeasurmentDimension>();
            
            var request = new RestRequest("dimensions", DataFormat.Json);
            request.AddJsonBody(_expectedDimension);
            _createdId = _client.Post<long>(request).Data;
        }
        
        [Then(@"I should be able to see the dimension in the list of dimensions")]
        public void ThenIShouldBeAbleToSeeTheDimensionInTheListOfDimensions()
        {
            var request = new RestRequest($"dimensions/{_createdId}", DataFormat.Json);
            var response = _client.Get<MeasurmentDimension>(request);

            var actualDimension = response.Data;
            actualDimension.Should().BeEquivalentTo(_expectedDimension);
        }
    }
}
