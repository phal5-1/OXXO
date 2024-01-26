using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockMove
{
    public int DecidePossibleMovements();

    public void CollapseMovements();

    public void Move();
}
