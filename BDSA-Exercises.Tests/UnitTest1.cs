namespace BDSA_Exercises.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Be_Hello_World()
        {
            // Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            //var program = Assembly.Load(nameof(Program));
            //program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

            // Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            output.Should().Be("Hello, World!");
        }
    }
}