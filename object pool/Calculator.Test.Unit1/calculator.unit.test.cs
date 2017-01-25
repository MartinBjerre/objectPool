using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using myCalculator;

namespace Calculator.Test.Unit1
{
    [TestFixture]
    public class calculatorTestUnit1
    {
        [Test]
        public void add_add2and4_return6()
        {
            var uut = new myCalculatorClass();

            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void add_add2andMinus4_returnMinus2()
        {
            var utt = new myCalculatorClass();
            Assert.That(utt.Add(2,-4), Is.EqualTo(-2));
        }

    }
}
