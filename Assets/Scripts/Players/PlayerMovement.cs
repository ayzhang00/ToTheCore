using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 2;

    public Collider2D movementCollider;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow) && CanMove(Vector2.up)) {
        	transform.position += new Vector3(0, speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow) && CanMove(Vector2.down)) {
        	transform.position += new Vector3(0, -1*speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow) && CanMove(Vector2.left)) {
        	transform.position += new Vector3(-1*speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow) && CanMove(Vector2.right)) {
        	transform.position += new Vector3(speed, 0) * Time.deltaTime;
        }
    }

    bool CanMove(Vector2 direction)
    {
        RaycastHit2D[] results = new RaycastHit2D[1];
        return (movementCollider.Raycast(direction, results, 0.32f) == 0 || results[0].collider.tag == "Ground");
    }
}
