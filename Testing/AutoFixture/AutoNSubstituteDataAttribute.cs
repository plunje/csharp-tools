using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CSharpTools.Testing.AutoFixture;

public class AutoNSubstituteDataAttribute : AutoDataAttribute
{
    public AutoNSubstituteDataAttribute() : base(() =>
    {
        var fixture = new AutoNSubstituteFixture();
        fixture.Customize<BindingInfo>(c => c.OmitAutoProperties());
        return fixture;
    })
    {
    }
}
