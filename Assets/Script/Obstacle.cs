using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] public Plate switch1;
    [SerializeField] public Plate switch2;
    [SerializeField] public Plate switch3;
    [SerializeField] public GameObject obstacle;

    public void Update()
    {
        if (switch1.GetIsPressed() == true &&
            switch2.GetIsPressed() == true &&
            switch3.GetIsPressed() == true)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
            obstacle.SetActive(false);
        }
        return;
    }
}
