using Definitions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Proofs
{
    [TestClass]
    public class ProofsContract
    {
        [TestMethod]
        public void Rotation0()
        {
            var c = new Contract();

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);
        }

        [TestMethod]
        public void Rotation1()
        {
            var c = new Contract();

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);
        }

        [TestMethod]
        public void Rotation2()
        {
            var c = new Contract();

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);
        }

        [TestMethod]
        public void Rotation3()
        {
            var c = new Contract();

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);
        }

        [TestMethod]
        public void Rotation4()
        {
            var c = new Contract();

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, null);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);
        }

        [TestMethod]
        public void Rotation5()
        {
            var c = new Contract();
            c.Axis = Orientation.Primary;

            Assert.AreEqual(c.Axis, Orientation.Primary);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, Orientation.Secondary);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, Orientation.Primary);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, Orientation.Secondary);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Positive);

            Assert.AreEqual(c.Axis, Orientation.Primary);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);
        }

        [TestMethod]
        public void Rotation6()
        {
            var c = new Contract();
            c.Axis = Orientation.Primary;

            Assert.AreEqual(c.Axis, Orientation.Primary);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, Orientation.Secondary);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, Orientation.Primary);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, Orientation.Secondary);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);

            c.Rotate(Direction.Negative);

            Assert.AreEqual(c.Axis, Orientation.Primary);
            Assert.AreEqual(c.Sides[1].Direction, Direction.Negative);
            Assert.AreEqual(c.Sides[0].Direction, Direction.Positive);
        }
    }
}
