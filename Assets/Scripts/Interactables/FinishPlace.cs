using System.Collections.Generic;
using UnityEngine;

public class FinishPlace : MonoBehaviour
{
    // Start is called before the first frame update
    private bool printWinLog = true;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = this.GetComponent<Collider2D>();
        List<Collider2D> collided = new();
        collider.OverlapCollider(new ContactFilter2D().NoFilter(), collided);    
        foreach (var collidedObject in collided)
        {
            if (collidedObject.GetComponent<VictoryObject>() != null)
            {
                if (printWinLog)
                {
                    Debug.Log("Win!!");
                }
                printWinLog = false;
            }
        }  
    }
}
