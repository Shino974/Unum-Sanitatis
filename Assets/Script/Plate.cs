using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPressed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isPressed = true;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        isPressed = true;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isPressed = false;
        this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }

    public bool GetIsPressed()
    {
        return isPressed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
