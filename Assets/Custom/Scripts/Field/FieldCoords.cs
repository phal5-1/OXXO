using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldCoords
{
    public int x;
    public int y;

    Vector3 ConvertToWorld()
    {
        return Vector3.right * (x - 5 * 20) + Vector3.forward * (y - 5 * 20);
    }
}
