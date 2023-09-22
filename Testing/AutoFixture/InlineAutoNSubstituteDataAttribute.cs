using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTools.Testing.AutoFixture
{
    public class InlineAutoNSubstituteDataAttribute : InlineAutoDataAttribute
    {
        public InlineAutoNSubstituteDataAttribute(params object[] objects) : base(new AutoNSubstituteDataAttribute(), objects)
        {
        }
    }
}
