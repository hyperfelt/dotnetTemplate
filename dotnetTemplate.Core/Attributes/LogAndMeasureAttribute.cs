using System.Diagnostics;
using AspectInjector.Broker;

namespace dotnetTemplate.Core.Attributes;

[Aspect(Scope.Global)]
[Injection(typeof(LogAndMeasureAttribute))]
public class LogAndMeasureAttribute : Attribute
{
    [Advice(Kind.Around, Targets = Target.Method)]
    public object LogAndMeasure(
        [Argument(Source.Type)] Type type,
        [Argument(Source.Name)] string name,
        [Argument(Source.Target)] Func<object[], object> methodDelegate,
        [Argument(Source.Arguments)] object[] args)
    {
        Console.WriteLine($"[{DateTime.UtcNow}] Calling '{name}' method...");
        
        Stopwatch sw = Stopwatch.StartNew();
        object result = methodDelegate(args);
        sw.Stop();
        
        Console.WriteLine($"[{DateTime.UtcNow}] Method '{name}' finished in {sw.ElapsedMilliseconds} ms.");
        return result;
    }
}