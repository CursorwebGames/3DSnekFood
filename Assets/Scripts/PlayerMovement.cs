using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody player;

    private void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 vect = new Vector3(horiz, 0, vert);
        player.velocity = transform.TransformDirection(vect) * Time.fixedDeltaTime * speed;
    }
}
