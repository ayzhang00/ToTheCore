using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int horizontalSpeed = 2;
    public int verticalSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) {
        	transform.position += new Vector3(0, verticalSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) {
        	transform.position += new Vector3(0, -1*verticalSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) {
        	transform.position += new Vector3(-1*horizontalSpeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) {
        	transform.position += new Vector3(horizontalSpeed, 0) * Time.deltaTime;
        }
    }
}
