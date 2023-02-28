using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using hexawware.Entities.Entities;


namespace hexawware.Test.Business.HexawareServiceSpec
{
    public class When_updating_hexaware : UsingHexawareServiceSpec
    {
        private Hexaware _result;
        private Hexaware _hexaware;

        public override void Context()
        {
            base.Context();

            _hexaware = new Hexaware
            {
                hesxawaredotnet = "hesxawaredotnet"
            };

            _hexawareRepository.Update( _hexaware).Returns(_hexaware);
            
        }
        public override void Because()
        {
            _result = subject.Update( _hexaware);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _hexawareRepository.Received(1).Update( _hexaware);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Hexaware>();

            _result.ShouldBe(_hexaware);
        }
    }
}
