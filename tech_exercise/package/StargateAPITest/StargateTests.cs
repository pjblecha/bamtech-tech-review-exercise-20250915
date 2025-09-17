using MediatR;
using StargateAPI.Controllers;

namespace StargateAPITest
{
    public class AstronautDutyTests
    {
        private readonly IMediator mediator;
        private AstronautDutyController _adCtr;
        public AstronautDutyTests() => _adCtr = new AstronautDutyController(mediator);

        [Fact]
        public async Task GetAstronautDuty_ReturnJaneDoe()
        {
            var result = await _adCtr.GetAstronautDutiesByName("Jane Doe");
            Assert.NotNull(result);
        }
    }

    public class PersonTests
    {
        private readonly IMediator mediator;
        private PersonController _pCtr;

        public PersonTests()
        {
            _pCtr = new PersonController(mediator);
        }

        [Fact]
        public async Task GetPersonByName_ReturnsPerson()
        {
            string personName = "Jane Doe";
            var result = await _pCtr.GetPersonByName(personName);
            Assert.NotNull(result);
        }
    }
}