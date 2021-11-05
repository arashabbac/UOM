using System;
using System.Linq;
using FluentAssertions;
using Screenplay.Core;
using Screenplay.Rest.Interactions;
using Screenplay.Rest.Tests.Unit.TestDoubles;
using Xunit;

namespace Screenplay.Rest.Tests.Unit
{
    public class GetTests
    {
        [Fact]
        public void Actor_Perform_A_Get_Request()
        {
            var jack = Actor.Named("Jack");
            var sender = new SpyHttpSender();
            var callAnApi = new CallAnApi(sender);
            jack.WhoCan(callAnApi);

            jack.AttemptsTo(GetResource.At("http://localhost:5000/api/people"));
            var allSentRequests = sender.GetAllRequests();

            allSentRequests.Should().HaveCount(1);
            allSentRequests.First().Method.Should().BeEquivalentTo("GET");
            allSentRequests.First().RequestUri.AbsoluteUri.Should().BeEquivalentTo("http://localhost:5000/api/people");
        }
    }
}
