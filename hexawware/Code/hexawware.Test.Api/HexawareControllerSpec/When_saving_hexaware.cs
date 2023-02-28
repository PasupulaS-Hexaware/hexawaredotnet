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
    public class When_saving_hexaware : UsingHexawareControllerSpec
    {
        private ActionResult<Hexaware> _result;

        private Hexaware _hexaware;

        public override void Context()
        {
            base.Context();

            _hexaware = new Hexaware
            {
                hesxawaredotnet = "hesxawaredotnet"
            };

            _hexawareService.Save(_hexaware).Returns(_hexaware);
        }
        public override void Because()
        {
            _result = subject.Save(_hexaware);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _hexawareService.Received(1).Save(_hexaware);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Hexaware>();

            var resultList = (Hexaware)resultListObject;

            resultList.ShouldBe(_hexaware);
        }
    }
}
