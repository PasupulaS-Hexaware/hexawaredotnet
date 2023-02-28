using NSubstitute;
using hexawware.Test.Framework;
using hexawware.Api.Controllers;
using hexawware.Business.Interfaces;


namespace hexawware.Test.Api.HexawareControllerSpec
{
    public abstract class UsingHexawareControllerSpec : SpecFor<HexawareController>
    {
        protected IHexawareService _hexawareService;

        public override void Context()
        {
            _hexawareService = Substitute.For<IHexawareService>();
            subject = new HexawareController(_hexawareService);

        }

    }
}
