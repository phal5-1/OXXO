using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockBase
{
    public void OnEarlyUpdate();

    public void OnUpdate();
    
    public void OnLateUpdate();
}
