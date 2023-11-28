using System.Diagnostics.CodeAnalysis;

namespace csharp12;

[System.Runtime.CompilerServices.InlineArray(3)]
public struct Point
{
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0051 // Remove unused private members
    private float _points;
#pragma warning restore IDE0051 // Remove unused private members
#pragma warning restore IDE0044 // Add readonly modifier
}

public class Point3d
{
    private Point _point;

    public Point3d(float x, float y, float z)
    {
        _point[0] = x;
        _point[1] = y;
        _point[2] = z;
    }

    public float X => _point[0];
    public float Y => _point[1];
    public float Z => _point[2];
}
