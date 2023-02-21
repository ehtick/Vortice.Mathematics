// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Numerics;
using NUnit.Framework;
using Vortice.Mathematics.PackedVector;

namespace Vortice.Mathematics.Tests.PackedVectors;

[TestFixture(TestOf = typeof(Short2))]
public partial class Short2Tests
{
    [TestCase]
    public void DefaultChecks()
    {
        Short2 vector = new();
        Assert.AreEqual(vector.X, 0);
        Assert.AreEqual(vector.Y, 0);
        Assert.AreEqual(vector.PackedValue, 0u);
    }

    [TestCase]
    public void CreationTests()
    {
        Short2 vector = new(250, 450);
        Assert.AreEqual(vector.X, 250);
        Assert.AreEqual(vector.Y, 450);
        Assert.AreEqual(vector.PackedValue, 29491450u);

        vector = new(125.0f, 255.0f);
        Assert.AreEqual(vector.X, 125);
        Assert.AreEqual(vector.Y, 255);

        Vector2 vector2 = vector.ToVector2();
        Assert.AreEqual(vector2.X, 125.0f);
        Assert.AreEqual(vector2.Y, 255.0f);
    }
}
