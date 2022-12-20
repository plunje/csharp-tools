using AutoFixture.Xunit2;

namespace CSharpTools.Testing.AutoFixture;

public class InlineAutoDomainDataAttribute : InlineAutoDataAttribute
{
    public InlineAutoDomainDataAttribute(params object[] objects) : base(new AutoDomainDataAttribute(), objects)
    {
    }
}
