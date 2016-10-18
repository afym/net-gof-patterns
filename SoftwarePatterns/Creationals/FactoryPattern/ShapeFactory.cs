using System;
using System.Reflection;

namespace SoftwarePatterns.Creationals.FactoryPattern
{
    public class ShapeFactory
    {
        public static IShape GetShape(string ShapeName)
        {
            IShape Shape = null;
            string ClassName = "SoftwarePatterns.Creationals.FactoryPattern." + ShapeName;
            try
            {
                Shape = (IShape)Assembly.GetExecutingAssembly().CreateInstance(ClassName);
            }
            catch (Exception)
            {
               // catch exception here ...
            }

            return Shape;
        }
    }
}
