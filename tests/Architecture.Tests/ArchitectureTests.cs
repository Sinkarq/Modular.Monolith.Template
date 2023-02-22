using FluentAssertions;
using NetArchTest.Rules;

namespace Architecture.Tests;

public class ArchitectureTests
{
    private const string Bootstrapper = "YourProject.Bootstrapper";
    private const string NotificationsApi = "YourProject.Modules.Notifications.Shared";

    [Fact]
    public void Test1()
    {
        //TODO: Make tests suitable for your Clean Architecture and test their dependencies as shown
        
        var assembly = System.Reflection.Assembly.Load(Bootstrapper);

        var otherProjects = new[]
        {
            NotificationsApi
        };

        var testResult = Types
            .InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjects)
            .GetResult();

        testResult.IsSuccessful.Should().BeTrue();
    }
}