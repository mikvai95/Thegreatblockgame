using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellowbutton : MonoBehaviour
{
    public GameObject Acid1;
    public GameObject Acid2;
    public GameObject Acid3;
    public GameObject Acid4;
    public GameObject Acid5;
    public GameObject Acid6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(Acid1);
            Destroy(Acid2);
            Destroy(Acid3);
            Destroy(Acid4);
            Destroy(Acid5);
            Destroy(Acid6);
        }
    }
}
