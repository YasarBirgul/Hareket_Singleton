
using System;
using UnityEngine;

namespace observer
{
   public class MovementSystem : MonoBehaviour
   { 
      private void Start()
      {
        // MovementPanel.OnforwardButtonClicked += MoveForward;
        // MovementPanel.OnBackButtonClicked += MoveBack;
        // MovementPanel.OnRightButtonClicked += MoveRight;
        // MovementPanel.OnLeftButtonClicked+= MoveLeft;

        MovementPanel.OnbuttonClicked += Move;
      }

      private void OnDestroy()
      {
          MovementPanel.OnbuttonClicked -= Move;
      }

      public void MoveForward() => transform.Translate(Vector3.forward);
      public void MoveBack() => transform.Translate(Vector3.back);
      public void MoveRight() => transform.Translate(Vector3.right);
      public void MoveLeft() => transform.Translate(Vector3.left);

      public void Move(Vector3 direction)
      {
          transform.Translate(direction);
          
      }
   } 
}

