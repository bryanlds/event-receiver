﻿using NUnit.Framework;
using System.Linq;

namespace EventReceiver.Domain.ValueTypes.Tests
{
    [TestFixture()]
    public class ValorTest
    {
        [Test()]
        public void EmptyValorReturnError()
        {
            var valor = new Valor("");

            Assert.True(valor.Invalid);
            Assert.AreEqual("Valor is empty.", valor.Notifications.Single().Message);
        }


        [Test()]
        public void ToStringTest()
        {
            var valor = new Valor("teste");
            var emptyValor = new Valor("");

            // Assert
            Assert.That(valor.ToString, Is.EqualTo("teste"));
            Assert.That(emptyValor.ToString, Is.EqualTo("Error"));
        }
    }
}