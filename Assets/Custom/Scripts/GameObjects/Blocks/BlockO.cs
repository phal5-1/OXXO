using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class BlockO : MonoBehaviour, IBlockBase, IBlockMove
{
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEarlyUpdate()
    {
        DecidePossibleMovements();
    }

    public void OnUpdate()
    {
        CollapseMovements();
    }

    public void OnLateUpdate()
    {

    }

    public int DecidePossibleMovements()
    {
        return 1;
    }

    public void CollapseMovements()
    {

    }

    public void Move()
    {
        
    }
}
