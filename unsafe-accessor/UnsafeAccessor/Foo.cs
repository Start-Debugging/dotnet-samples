namespace UnsafeAccessor;

class Foo
{
    private Foo() { }
    private Foo(string value)
    {
        InstanceProperty = value;
    }

    private string InstanceProperty { get; set; } = "instance-property";
    private static string StaticProperty { get; set; } = "static-property";

    private int instanceField = 1;
    private static int staticField = 2;
    public readonly int readonlyField = 3;

    private string InstanceMethod(int value) => $"instance-method:{value}";
    private static string StaticMethod(int value) => $"static-method:{value}";
}
