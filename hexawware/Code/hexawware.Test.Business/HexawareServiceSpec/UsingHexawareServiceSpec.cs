using NSubstitute;
using hexawware.Test.Framework;
using hexawware.Business.Services;
using hexawware.Data.Interfaces;

namespace hexawware.Test.Business.HexawareServiceSpec
{
    public abstract class UsingHexawareServiceSpec : SpecFor<HexawareService>
    {
        protected IHexawareRepository _hexawareRepository;

        public override void Context()
        {
            _hexawareRepository = Substitute.For<IHexawareRepository>();
            subject = new HexawareService(_hexawareRepository);

        }

    }
}
