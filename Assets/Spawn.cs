using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject leftHand;
    public GameObject Map;
    private bool created = false;

    public void InstantiateMap()
    {
        if (created == false)
        {
            Instantiate(Map, leftHand.transform);
            created = true;
        }
    }
}
