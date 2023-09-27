using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 rawInput;
    [SerializeField] float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 deltaPosition = rawInput * moveSpeed * Time.deltaTime;
        transform.position += deltaPosition;
    }

    void OnMove(InputValue move)
    {
        rawInput = move.Get<Vector2>();
        Debug.Log(rawInput);
    }
}
