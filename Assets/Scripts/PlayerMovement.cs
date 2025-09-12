using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;
    public float rotationSpeed = 120f;

    private Vector2 movementValue;
    private float lookValue;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
        Debug.Log("whatever");
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
        Debug.Log(lookValue);
    }

    void Update()
    {
        transform.Translate(movementValue.x * Time.deltaTime, 0f, movementValue.y * Time.deltaTime);
        transform.Rotate(0f, lookValue * Time.deltaTime, 0f);
        //Debug.Log(lookValue);
    }
}
