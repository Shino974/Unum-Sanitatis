using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] public Switch switch1;
    [SerializeField] public Switch switch2;
    [SerializeField] public Switch switch3;

    public void Update()
    {
        if (switch1.GetIsPressed() == true &&
            switch2.GetIsPressed() == true &&
            switch3.GetIsPressed() == true)
            this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        return;
    }
}
