using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redbutton : MonoBehaviour
{
    public GameObject EnemyCube1;
    public GameObject EnemyCube2;
    public GameObject EnemyCube3;
    public GameObject EnemyCube4;
    public GameObject EnemyCube5;
    public GameObject EnemyCube6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(EnemyCube1);
            Destroy(EnemyCube2);
            Destroy(EnemyCube3);
            Destroy(EnemyCube4);
            Destroy(EnemyCube5);
            Destroy(EnemyCube6);
        }
    }
}
