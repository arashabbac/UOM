using FluentAssertions;
using NSubstitute;
using Screenplay.Core.Tests.Unit.TestDoubles;
using Xunit;

namespace Screenplay.Core.Tests.Unit
{
    public class ActorTests
    {
        [Fact]
        public void Actor_Has_A_Name()
        {
            var actor = Actor.Named("Jack");

            actor.Name.Should().Be("Jack");
        }

        [Fact]
        public void Actor_Performs_A_Task()
        {
            var jack = Actor.Named("Jack");
            var task = Substitute.For<IPerformable>();
            
            jack.AttemptsTo(task);
            task.Received(1).Perform(jack);
        }

        [Fact]
        public void Actor_Remember_Stuff()
        {
            var jack = Actor.Named("Jack");
            jack.Remembers("Id",1);

            var actualValue = jack.Recalls<int>("Id");
            actualValue.Should().Be(1);
        }

        [Fact]
        public void Actor_Asks_For_A_Question()
        {
            var jack = Actor.Named("Jack");
            var question = StubQuestion.CreateNew().WhichReturnsAnswer(10);

            var answer = jack.AsksFor(question);
            answer.Should().Be(10);
        }

        [Fact]
        public void Ability_Get_Enabled_In_Actor()
        {
            var jack = Actor.Named("Jack");
            var writeCleanCode = new WriteCleanCodeAbility();

            jack.WhoCan(writeCleanCode);
            var ability = jack.FindAbility<WriteCleanCodeAbility>();
            ability.Should().Be(writeCleanCode);
        }
    }
}
