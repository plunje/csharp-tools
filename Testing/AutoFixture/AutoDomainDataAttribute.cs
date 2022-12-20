using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CSharpTools.Testing.AutoFixture;

public class AutoDomainDataAttribute : AutoDataAttribute
{
    public AutoDomainDataAttribute() : base(() =>
    {
        var fixture = new AutoMoqFixture();
        fixture.Customize<BindingInfo>(c => c.OmitAutoProperties());
        return fixture;
    })
    {
    }
}
