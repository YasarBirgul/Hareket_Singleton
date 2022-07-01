
using System;
using UnityEngine;

namespace Controllers
{
    public class TriggerController : MonoBehaviour
    {

        public int idOfTheDoor;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                EventManager.Instance.onDoorwayTriggerEnter(idOfTheDoor);
            }
        }
        
        
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                EventManager.Instance.onDoorwayTriggerExit(idOfTheDoor);
            }
        }
    }
}

