
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        Vector3 forward = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forward + horizontalMove);
    }



    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");



    }
}
