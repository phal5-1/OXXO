using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] int _column;
    [SerializeField] int _row;
    [Space(10f)]
    [SerializeField] bool _instantiate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_instantiate)
        {
            _instantiate = false;
            if(_prefab != null)
            {
                if(_prefab.activeInHierarchy)
                {
                    Debug.LogError("Prefabs are recommended for this operation.");
                }
            }
        }
    }
}
