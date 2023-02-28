using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using hexawware.Entities.Entities;

namespace hexawware.Test.Api.HexawareControllerSpec
{
    public class When_getting_all_hexaware : UsingHexawareControllerSpec
    {
        private ActionResult<IEnumerable<Hexaware>> _result;

        private IEnumerable<Hexaware> _all_hexaware;
        private Hexaware _hexaware;

        public override void Context()
        {
            base.Context();

            _hexaware = new Hexaware{
                hesxawaredotnet = "hesxawaredotnet"
            };

            _all_hexaware = new List<Hexaware> { _hexaware};
            _hexawareService.GetAll().Returns(_all_hexaware);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _hexawareService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<Hexaware>>();

            List<Hexaware> resultList = resultListObject as List<Hexaware>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_hexaware);
        }
    }
}
