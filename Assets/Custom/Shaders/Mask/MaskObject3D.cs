using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskObject3D : MonoBehaviour
{
    [SerializeField] GameObject _masked;
    // Start is called before the first frame update
    private void Update()
    {
        int queue = GetComponent<MeshRenderer>().material.renderQueue;
        Debug.Log(queue);
        _masked.GetComponent<MeshRenderer>().material.renderQueue = 2002;
    }
}
