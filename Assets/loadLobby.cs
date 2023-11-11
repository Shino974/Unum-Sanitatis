using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLobby : MonoBehaviour
{
    [SerializeField] public AudioSource t;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            t.Stop();
            SceneManager.LoadScene("Lobby", LoadSceneMode.Additive);
        }
    }
}
