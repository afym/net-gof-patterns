using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwarePatterns.Creationals.FactoryPattern;

namespace SoftwarePatternsTest.Creationals
{
    [TestClass]
    public class FactoryPattern
    {
        [TestMethod]
        public void TestBaseInstance()
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            Assert.IsInstanceOfType(circle, typeof(IShape));
            Assert.IsInstanceOfType(square, typeof(IShape));
            Assert.IsInstanceOfType(rectangle, typeof(IShape));
        }

        [TestMethod]
        public void TestCircleInstanceByFactory() 
        {
            IShape circle = ShapeFactory.GetShape("Circle");
            Assert.IsInstanceOfType(circle, typeof(IShape));
        }

        [TestMethod]
        public void TestRectangleInstanceByFactory()
        {
            IShape circle = ShapeFactory.GetShape("Rectangle");
            Assert.IsInstanceOfType(circle, typeof(IShape));
        }

        [TestMethod]
        public void TestSquareInstanceByFactory()
        {
            IShape circle = ShapeFactory.GetShape("Square");
            Assert.IsInstanceOfType(circle, typeof(IShape));
        }

        [TestMethod]
        public void TestAreaByFactory() 
        {
            IShape circle = ShapeFactory.GetShape("Circle");
            string area = circle.draw();
            Assert.AreEqual(area, "drawing a circle ...");
        }

        [TestMethod]
        public void TestInvalidShape() 
        {
            IShape triangle = ShapeFactory.GetShape("Triangle");
            Assert.IsNull(triangle);
        }
    }
}
