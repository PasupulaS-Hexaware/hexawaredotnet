using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using hexawware.Entities.Entities;

namespace hexawware.Test.Business.HexawareServiceSpec
{
    public class When_getting_all_hexaware : UsingHexawareServiceSpec
    {
        private IEnumerable<Hexaware> _result;

        private IEnumerable<Hexaware> _all_hexaware;
        private Hexaware _hexaware;

        public override void Context()
        {
            base.Context();

            _hexaware = new Hexaware{
                hesxawaredotnet = "hesxawaredotnet"
            };

            _all_hexaware = new List<Hexaware> { _hexaware};
            _hexawareRepository.GetAll().Returns(_all_hexaware);
        }
        public override void Because()
        {
            _result = subject.GetAll();
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _hexawareRepository.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Hexaware>>();

            List<Hexaware> resultList = _result as List<Hexaware>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_hexaware);
        }
    }
}
