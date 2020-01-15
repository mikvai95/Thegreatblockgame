using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Teleportation());
        }
    }

    IEnumerator Teleportation()
    {
        yield return new WaitForSeconds(0.5f);
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
}
