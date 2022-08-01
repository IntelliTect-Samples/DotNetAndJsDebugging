

// Simply click the margin to insert a breakpoint. You already knew this.
Console.WriteLine("Hello, World!");


for (int i = 0; i < 486; i++)
{
    // But what if we want to debug a particular item in a large loop?
    // Set a conditional breakpoint! Right-click the margin,
    // or right-click in the code and use the Breakpoint submenu.
    Console.WriteLine($"{i} is {((i % 2) == 0 ? "Even" : "Odd")}");
}

// You can also set tracepoints, temporary breakpoints, and dependent breakpoints.
// Any breakpoint can be configured at any time.
Console.WriteLine("Program is exiting");


// Breakpoints inside single-line delegates must be set via right-click
Enumerable.Range(0, 87)
    .Select(i => Math.Sqrt(i))
    .ToList();

// Programmatic interaction with the Debugger
if (System.Diagnostics.Debugger.IsAttached)
{
    System.Diagnostics.Debugger.Break();
}

return 0;


