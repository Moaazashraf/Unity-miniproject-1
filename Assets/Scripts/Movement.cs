using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 7;
    public Rigidbody rb;
    float horizontalInput;
    int currentScore;
    bool flipped;
    


    void FixedUpdate()
    { 
        if (GameManager.inst.flipped)
        {
            rb.AddForce(new Vector3(0, 10 * 7, 0), ForceMode.Acceleration);
        }
        else
        {
            rb.AddForce(new Vector3(0, -10 * 7, 0), ForceMode.Acceleration);
        }
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.inst.flipped =  !GameManager.inst.flipped;

        }
        horizontalInput = Input.GetAxis("Horizontal");
        /*Vector3 forwardMove = transform.forward * speed * Time.deltaTime;*/

    }
}
