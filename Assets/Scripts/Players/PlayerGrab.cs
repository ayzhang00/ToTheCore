using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    // Requires player and objects to have Collider2ds

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If has item, drops it
            if (transform.childCount > 0)
            {
                transform.DetachChildren();
            }
            else 
            {
                // Try to pick up item
                Collider2D collider = this.GetComponent<Collider2D>();
                List<Collider2D> collided = new();
                collider.OverlapCollider(new ContactFilter2D().NoFilter(), collided); 
                if (collided.Count > 0)
                {
                    // If multiple nearby objects, picks up one at random
                    if (collided[0].GetComponent<GrabbableObject>() != null)
                    {
                        collided[0].transform.SetParent(transform);
                    }
                }
            }
        }
    }
}
