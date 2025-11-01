using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrol : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public InputActionAsset controls;
    private int direction = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (controls.FindAction("Move").ReadValue<float>() > 0)
        {
            direction = 1;
        }
        else if (controls.FindAction("Move").ReadValue<float>() < 0)
        {
            direction = -1;
        }
        else
        {
            direction = 0;
        }
        Vector2 vel = rb.linearVelocity;
        vel.x+= direction * speed * Time.deltaTime;
        rb.linearVelocity = vel;

    }

}