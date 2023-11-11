using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    [SerializeField] public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
