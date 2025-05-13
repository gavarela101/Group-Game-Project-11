using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Jayden Saelee Chao
 * Contols player movement and other things
 * 5/10/2025
 */

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
     
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public int greenArts = 0;
    public int goldArts = 0;
    public int blueArts = 0;
    public int spikeArts = 0;
    public int orangeArts = 0;
    public int lives = 3;
    public int health = 100;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;
    bool isMoving;

    private Vector3 lastPosition = new Vector3(0f, 0f, 0f);
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * X + transform.forward * Z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(lastPosition != gameObject.transform.position && isGrounded == true)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        lastPosition = gameObject.transform.position;

        loseLife();
        Death();
    } 

    public void loseLife()
    {
        if (health <= 0)
        {
            lives--;
        }
    }

    public void Death()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
