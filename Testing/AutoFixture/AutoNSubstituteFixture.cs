using AutoFixture.Kernel;
using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoFixture.AutoNSubstitute;

namespace CSharpTools.Testing.AutoFixture;

public class AutoNSubstituteFixture : Fixture
{
    public AutoNSubstituteFixture(int repeatCount = 3)
    {
        RepeatCount = repeatCount;

        Customize(new AutoNSubstituteCustomization());
        
        Behaviors.Remove(new ThrowingRecursionBehavior());
        Behaviors.Add(new OmitOnRecursionBehavior());
    }
}