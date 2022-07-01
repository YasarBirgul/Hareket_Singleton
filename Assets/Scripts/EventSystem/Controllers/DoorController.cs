using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int idOfTheDoor; 
    
    public void Subscribe()
    {
        EventManager.Instance.onDoorwayTriggerEnter += OnDoorwayOpen;
        EventManager.Instance.onDoorwayTriggerExit += OnDoorwayClose;
    }
    public void Unsubscribe()
    {
        EventManager.Instance.onDoorwayTriggerEnter -= OnDoorwayOpen;
        EventManager.Instance.onDoorwayTriggerExit -= OnDoorwayClose;
    }
    private void OnDoorwayOpen(int id)
    {
        if (id == this.idOfTheDoor)
        {
            transform.Translate(new Vector3(0,2*idOfTheDoor,0));
        }
    }

    private void OnDoorwayClose(int id)
    {
        if (id == this.idOfTheDoor)
        {
            transform.Translate(new Vector3(0,-2*idOfTheDoor,0));
        }
    }
    private void OnEnable()
    {
        Subscribe();
    } 
    private void OnDisable()
    {
        Unsubscribe();
    }
    private void OnDestroy()
    {
        Unsubscribe();
    }
}
