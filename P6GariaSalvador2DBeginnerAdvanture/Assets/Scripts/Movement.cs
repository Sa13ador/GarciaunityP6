using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement PlayerController 1 : MonoBehaviour
{
public InputAction MoveAction;
    // Start is called before the first frame update
    void Start()
    {
    LeftAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
    Vector2 move = MoveAction.ReadValue<Vector2>();
    Debug.Log(move);

        Vector2 position = transform.position;
        position. x = position.x * horizontal;
        position. y = position.y * vertical;
        transform.position = position;
}
