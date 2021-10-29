using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;

public class ButtonMap : MonoBehaviour
{

    public UnityEvent spawnMap;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);
    }

    void InitiateEvent(InteractableStateArgs state)
    {
        if(state.NewInteractableState == InteractableState.ContactState)
        {
            spawnMap.Invoke();
        }
    }
}
