using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{ 
    public bool isPressed = false;
    [SerializeField] public GameObject switch1;

    public bool GetIsPressed()
    {
        return isPressed;
    }
    //private bool isPressed = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        isPressed = true;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        switch1.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        isPressed = true;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        switch1.SetActive(true);
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
    }
}
