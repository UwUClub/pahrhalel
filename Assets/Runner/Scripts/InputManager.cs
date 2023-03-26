using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

namespace HyperCasual.Runner
{
    /// <summary>
    /// A simple Input Manager for a Runner game.
    /// </summary>
    public class InputManager : MonoBehaviour
    {
        public float speed = 5.0f;
        private PlayerControls playerControls;
        private float horizontalInput;

        private void Awake()
        {
            playerControls = new PlayerControls();
            playerControls.Movement.MoveX.performed += ctx => horizontalInput = ctx.ReadValue<float>();
            playerControls.Movement.MoveX.canceled += ctx => horizontalInput = 0;
        }

        private void OnEnable()
        {
            playerControls.Enable();
        }

        private void OnDisable()
        {
            playerControls.Disable();
        }

        void Update()
        {
            float movement = horizontalInput * speed * Time.deltaTime;
            transform.position += new Vector3(movement, 0, 0);
        }
    }
}

