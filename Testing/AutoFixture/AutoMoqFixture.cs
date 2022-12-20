using System.Reflection;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Kernel;

namespace CSharpTools.Testing.AutoFixture;

public class AutoMoqFixture : Fixture
{
    public AutoMoqFixture(int repeatCount = 3)
    {
        RepeatCount = repeatCount;

        Customize(new AutoMoqCustomization());
        Behaviors.Remove(new ThrowingRecursionBehavior());
        Behaviors.Add(new OmitOnRecursionBehavior());

        Customizations.Add(new BoolAlwaysTrueBuilder());
    }

    private class BoolAlwaysTrueBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var pi = request as PropertyInfo;

            if (pi == null)
            {
                return new NoSpecimen();
            }

            if (pi.PropertyType == typeof(bool))
            {
                return true;
            }

            return new NoSpecimen();
        }
    }
}

