﻿namespace Knitter.Common.Utils;

public static class MathHelper
{
    public static float DegreesToRadians(float degrees)
    {
        return MathF.PI / 180f * degrees;
    }
}