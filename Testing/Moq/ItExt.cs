using FluentAssertions;
using FluentAssertions.Equivalency;
using Moq;

namespace CSharpTools.Testing.Moq;

public static class ItExt
{
    public static T AsMatch<T>(this T @object)
    {
        return AsMatch(@object, config => config);
    }

    public static T AsMatch<T>(this T @object, Func<EquivalencyAssertionOptions<T>, EquivalencyAssertionOptions<T>> config)
    {
        return Match.Create<T>(x =>
        {
            try
            {
                @object.Should().BeEquivalentTo(x, config);
                return true;
            }
            catch
            {
                return false;
            }
        });
    }
}