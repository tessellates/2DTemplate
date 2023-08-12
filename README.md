# 2D-Template

Welcome to "2D-Template" 

We use C#.

## Style-Guide

reference: https://google.github.io/styleguide/csharp-style.html
reference documentation: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments

How to structure a file:
```csharp
namespace namespace
{
    /// <summary>
    /// Class <c>ClassName</c> has this summary
    /// </summary>
    public class ClassName
    {
        // PUBLIC - STATIC
        public static Foo BarFoo;

        // PUBLIC 
        public Foo FooBar {get; set;}
        Foo FooFoo => _fooFoo;

        /// <summary>
        ///  public method summary
        ///  <param name="param1">the <c>ClassOfTheParam</c> explain</param>
        /// <returns>
        /// <c>Foo</c> with a dash of radish
        /// </returns>
        /// </summary>
        public Foo CreateFoo(ClassOfTheParam param1)
        {

        }
    
        // PRIVATE - STATIC
        private static Bar _bar2
        // PRIVATE
        private Bar _bar
        
        /// <summary>
        ///  private method summary
        ///  <param name="param1">the <c>ClassOfTheParam</c> explain</param>
        /// </summary>
        private void CreateFoo(ClassOfTheParam param1)
        {

        }
    }
}
```
How to test a class:
```csharp

namespace YourWorkspace.Test.YourAwesomeClassTest
{
        // Use an abstract class as long as you need any setup. Omit it if not
    public abstract class YourAwesomeClassTest
    {
        //Your setup
    }

    [TestFixture]
    public class SomeMethodToTest : YourAwesomeClassTest
    {
        [Test]
        public void OnePossibleScenarioOfTheMethod_ExpectedResult()
        {
            //Your code
        }

        //Other methods
    }

    //Other classes
}
```
