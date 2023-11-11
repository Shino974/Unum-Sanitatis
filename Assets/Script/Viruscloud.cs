using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Viruscloud : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rb;
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("I'm here");
        SceneManager.LoadScene(levelToLoad);
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
