using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckGems : MonoBehaviour
{

    [SerializeField] private int numnberOfGems;

    private int numberOfGemsInSocket = 0;

    public UnityEvent unlcock;
    
    public void AddGems()
    {
        numberOfGemsInSocket += 1;
        CheckForAllGems();
    }

    private void CheckForAllGems()
    {
        if (numberOfGemsInSocket == numnberOfGems)
            unlcock.Invoke();
    }

    public void RemoveGems()
    {
        numberOfGemsInSocket -= 1;
    }
}
