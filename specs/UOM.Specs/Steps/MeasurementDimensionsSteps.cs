using System;
using System.Collections.Generic;
using FluentAssertions;
using RestSharp;
using RestSharp.Authenticators;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Abilities;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UOM.Specs.Constants;
using UOM.Specs.Models;
using UOM.Specs.Screenplay.Questions;
using UOM.Specs.Screenplay.Tasks;

namespace UOM.Specs.Steps
{
    [Binding]
    public class MeasurementDimensionsSteps
    {

        //private Actor _actor;
        private MeasurmentDimension _dimension;
        private Stage _stage;

        //public MeasurementDimensionsSteps()
        //{
        //    var cast = Cast.WhereEveryoneCan(new List<IAbility> { CallAnApi.At(ApiConstants.BaseUrl) });
        //    _stage = new Stage(cast);
        //}

        public MeasurementDimensionsSteps(Stage stage)
        {
            _stage = stage;
        }

        [Given(@"I have entered as a procurement manager")]
        public void GivenIHaveEnteredAsAProcurementManager()
        {
            //_actor = Actor.Named("Procurement Manager")
            //    .WhoCan(CallAnApi.At(ApiConstants.BaseUrl));        //TODO : use persona
            _stage.ShineSpotlightOn("Procurement Manager");
        }

        [When(@"I define the following dimension")]
        public void WhenIDefineTheFollowingDimension(Table table)
        {
            _dimension = table.CreateInstance<MeasurmentDimension>();
            //_actor.AttemptsTo(new DefineDimension(_dimension));
            _stage.ActorInTheSpotlight.AttemptsTo(Define.Dimension(_dimension));
        }

        [Then(@"I should be able to see the dimension in the list of dimensions")]
        public void ThenIShouldBeAbleToSeeTheDimensionInTheListOfDimensions()
        {
            var actualDimension = _stage.ActorInTheSpotlight.AsksFor(new LastCreatedDimension());
            actualDimension.Should().BeEquivalentTo(_dimension);
        }

        //private long _createdId;
        //private readonly RestClient _client = new RestClient("http://localhost:5000/");
        //private MeasurmentDimension _expectedDimension;

        //[Given(@"I have entered as a procurement manager")]
        //public void GivenIHaveEnteredAsAProcurementManager()
        //{
        //}

        //[When(@"I define the following dimension")]
        //public void WhenIDefineTheFollowingDimension(Table table)
        //{
        //    _expectedDimension = table.CreateInstance<MeasurmentDimension>();

        //    var request = new RestRequest("dimensions", DataFormat.Json);
        //    request.AddJsonBody(_expectedDimension);
        //    _createdId = _client.Post<long>(request).Data;
        //}

        //[Then(@"I should be able to see the dimension in the list of dimensions")]
        //public void ThenIShouldBeAbleToSeeTheDimensionInTheListOfDimensions()
        //{
        //    var request = new RestRequest($"dimensions/{_createdId}", DataFormat.Json);
        //    var response = _client.Get<MeasurmentDimension>(request);

        //    var actualDimension = response.Data;
        //    actualDimension.Should().BeEquivalentTo(_expectedDimension);
        //}
    }
}
