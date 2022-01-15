using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce = 500.0f;

    private Rigidbody _body;
    
    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += jumpActionPerformed;
    }

    private void jumpActionPerformed(InputAction.CallbackContext obj)
    {
        _body.AddForce(Vector3.up * jumpForce);
    }
}
