using ObjCRuntime;

namespace AppKit;

[Mac(10, 10)]
[Native]
public enum NSAccessibilityUnits : long
{
	Unknown,
	Inches,
	Centimeters,
	Points,
	Picas
}