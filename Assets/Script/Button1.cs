using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    [SerializeField] public GameObject wind;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        //isPressed = true;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        wind.SetActive(false);
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        //isPressed = true;
        this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        wind.SetActive(false);
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        wind.SetActive(true);
    }
}
