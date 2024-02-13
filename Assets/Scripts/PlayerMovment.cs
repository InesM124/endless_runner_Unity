using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    float horizentalInput; 
    public float horizontalMultiplayer = 2;

    private void FixedUpdate ()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizentalMove = transform.right * horizentalInput * speed * Time.fixedDeltaTime * horizontalMultiplayer;
        rb.MovePosition(rb.position + forwardMove + horizentalMove);

    }


    // Update is called once per frame
    private void Update()
    { 
        horizentalInput = Input.GetAxis("Horizontal");
    }
}
