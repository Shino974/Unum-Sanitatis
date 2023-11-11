using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rb;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Rigidbody2D>().gravityScale = -2.0f;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        other.gameObject.GetComponent<Rigidbody2D>().gravityScale = -2.0f;
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
    }
}