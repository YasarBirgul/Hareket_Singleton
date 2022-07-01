using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        private void Update()
        {
            EventManager.Instance.onInputDrag?.Invoke(new InputParamaters()
                {
                    XvalueP = GetInput().x,
                    YvalueP = GetInput().y,
                }
            );
        }

        private Vector2 GetInput() => new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }
}

