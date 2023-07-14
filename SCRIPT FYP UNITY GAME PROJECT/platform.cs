using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name  == "player")
        {
            collision.gameObject.transform.SetParent(transform);
        }

    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
