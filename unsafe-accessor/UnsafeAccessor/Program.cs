using System.Runtime.CompilerServices;
using UnsafeAccessor;

// Creating object instances using private constructors

[UnsafeAccessor(UnsafeAccessorKind.Constructor)]
extern static Foo PrivateConstructor();

[UnsafeAccessor(UnsafeAccessorKind.Constructor)]
extern static Foo PrivateConstructorWithParameters(string value);

var instance1 = PrivateConstructor();
var instance2 = PrivateConstructorWithParameters("bar");



// Invoke private instance methods

[UnsafeAccessor(UnsafeAccessorKind.Method, Name = "InstanceMethod")]
extern static string InstanceMethod(Foo @this, int value);

Console.WriteLine(InstanceMethod(instance1, 42)); // "instance-method:42"



// Get / Set private instance properties

[UnsafeAccessor(UnsafeAccessorKind.Method, Name = "get_InstanceProperty")]
extern static string InstanceGetter(Foo @this);

[UnsafeAccessor(UnsafeAccessorKind.Method, Name = "set_InstanceProperty")]
extern static void InstanceSetter(Foo @this, string value);

Console.WriteLine(InstanceGetter(instance1)); // "instance-property"
InstanceSetter(instance1, "bar");
Console.WriteLine(InstanceGetter(instance1)); // "bar"



// Static methods and properties

[UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = "StaticMethod")]
extern static string StaticMethod(Foo @this, int value);

[UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = "get_StaticProperty")]
extern static string StaticGetter(Foo @this);

[UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = "set_StaticProperty")]
extern static void StaticSetter(Foo @this, string value);



// Fields

[UnsafeAccessor(UnsafeAccessorKind.Field, Name = "instanceField")]
extern static ref int InstanceField(Foo @this);

[UnsafeAccessor(UnsafeAccessorKind.StaticField, Name = "staticField")]
extern static ref int StaticField(Foo @this);

// Read the field value
var x = InstanceField(instance1);
var y = StaticField(instance1);

// Update the field value
InstanceField(instance1) = 3;
StaticField(instance1) = 4;



// Readonly fields

[UnsafeAccessor(UnsafeAccessorKind.Field, Name = "readonlyField")]
extern static ref int ReadonlyField(Foo @this);

Console.WriteLine(instance1.readonlyField); // 3

ReadonlyField(instance1) = 42;
Console.WriteLine(instance1.readonlyField); // 42