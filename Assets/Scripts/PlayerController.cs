using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb2;
    Vector2 moveInput;

    float move;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;

    [SerializeField] bool isJumping;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2 =  GetComponent<Rigidbody2D>(); 
        isJumping = true;
    }

    // Update is called once per frame
    void Update()
    {
        //move = Input.GetAxis("Horizontal");
        //rb2.linearVelocity = new Vector2 (move * speed , rb2.linearVelocity.y);
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2.AddForce(moveInput *  speed);

        

        if (Input.GetButtonDown("Jump") && isJumping)
        {
            rb2.AddForce(new Vector2 (rb2.linearVelocity.x, jumpForce));
            Debug.Log("Jump!!");
            isJumping = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
    //private void OnCollisionExit2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Ground"))
    //    {
    //        isJumping = true;
    //    }
    //}
}
