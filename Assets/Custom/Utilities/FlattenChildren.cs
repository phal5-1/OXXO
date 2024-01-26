using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] public class FlattenChildren : MonoBehaviour
{
    [SerializeField] bool _deleteEmptyAfterFlattening = false;
    [Space(10f)]
    [SerializeField] bool _flatten = false;

    List<Transform> _children;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_flatten)
        {
            _flatten = false;
            foreach(Transform child in transform)
            {
                PullGutsOut(child);
            }
            if(_deleteEmptyAfterFlattening)
            {
                RemoveEmptyInChildren();
            }
        }
    }

    void PullGutsOut(Transform transform)
    {
        List<Transform> list = new List<Transform>();
        foreach(Transform child in transform)
        {
            if(child.childCount > 0)
            {
                PullGutsOut(child);
            }
        }
        foreach(Transform child in transform)
        {
            list.Add(child);
        }
        foreach(Transform move in list)
        {
            move.SetParent(transform.parent);
        }
    }

    void RemoveEmptyInChildren()
    {
        List<Transform> list = new List<Transform>();
        foreach (Transform child in transform)
        {
            if (child.GetComponents(typeof(Component)).Length == 1)
            {
                list.Add(child);
            }
        }
        foreach(Transform child in list)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}
