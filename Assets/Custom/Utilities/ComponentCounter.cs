using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ComponentCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GetComponents(typeof(Component)).Length);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetComponents(typeof(Component)).Length);
    }
}
