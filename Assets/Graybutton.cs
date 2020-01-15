using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graybutton : MonoBehaviour
{
    public GameObject Gate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(Gate);
        }
    }
}
