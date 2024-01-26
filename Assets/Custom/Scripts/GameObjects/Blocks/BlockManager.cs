using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlockManager : MonoBehaviour
{
    static List<IBlockBase> _blocks = new();
    static List<int> _possibilities = new();

    static UnityEvent _earlyUpdate;
    static UnityEvent _update;
    static UnityEvent _lateUpdate;

    static bool[ , ] _nextMove = new bool[9, 9];
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    static void AddToList(IBlockBase block)
    {
        _blocks.Add(block);
        _earlyUpdate.AddListener(block.OnEarlyUpdate);
        _update.AddListener(block.OnUpdate);
        _lateUpdate.AddListener(block.OnLateUpdate);
    }

    public static void RemoveFromList(IBlockBase block)
    {
        _blocks.Remove(block);
        _earlyUpdate.RemoveListener(block.OnEarlyUpdate);
        _update.RemoveListener(block.OnUpdate);
        _lateUpdate.RemoveListener(block.OnLateUpdate);
    }
}
