using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour
{

    // public int Score { get { return score; } }
    [SerializeField]
    public int score;
    int collectables;
    public float jumpHeight = 4;
    public float timeToJumpApex = .4f;
    float accelerationTimeAirborne = .2f;
    float accelerationTimeGrounded = .1f;
    public float moveSpeed = 20;


    float gravity;
    float jumpVelocity;
    Vector3 velocity;
    float velocityXSmoothing;

    Controller2D controller;
    SpriteRenderer mySpriteRenderer;
    void Start()
    {
        controller = GetComponent<Controller2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        print("Gravity: " + gravity + "  Jump Velocity: " + jumpVelocity);
        score = 0;
    }

    void Update()
    {

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (input.x < 0)
        {
            if (mySpriteRenderer != null)
            {
                mySpriteRenderer.flipX = true;
            }
                
        }

        if (input.x > 0)
        {
            if (mySpriteRenderer != null)
            {
                mySpriteRenderer.flipX = false;
            }

        }


        if (Input.GetKeyDown(KeyCode.Space) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }

        float targetVelocityX = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

 




}


