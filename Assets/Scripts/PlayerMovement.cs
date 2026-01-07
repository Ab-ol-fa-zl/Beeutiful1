using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D characterbody;
    private Vector2 inputMovement;

    void Start()
    {
        characterbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        inputMovement = Vector2.zero;

        if (Keyboard.current.aKey.isPressed) inputMovement.x = -1;
        if (Keyboard.current.dKey.isPressed) inputMovement.x = 1;
        if (Keyboard.current.sKey.isPressed) inputMovement.y = -1;
        if (Keyboard.current.wKey.isPressed) inputMovement.y = 1;
    }

    void FixedUpdate()
    {
        Vector2 delta = inputMovement * speed * Time.fixedDeltaTime;
        characterbody.MovePosition(characterbody.position + delta);
    }
}
