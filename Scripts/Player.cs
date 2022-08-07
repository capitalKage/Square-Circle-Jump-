using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioClip jump;
    public int playerScore;
    Rigidbody rigidbody;
    public int jumpForce = 10;
    public float gravityScale = 5;
    private bool ground;
    public float distanceToCheck = 1f;
    public bool gameOver, gameStart;


    private void Awake()
    {
        ground = true;
        gameStart = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && ground && gameOver == false)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(jump);
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //ground = false;
        }


    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(Physics.gravity * (gravityScale - 1) * rigidbody.mass);

        GroundCheck();
    }

    private void GroundCheck()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distanceToCheck + 0.1f))
        {
            Debug.Log("ground");
            ground = true;
        }
        else
        {
            Debug.Log("air");
            ground = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameOver = true;
        }
    }
}
