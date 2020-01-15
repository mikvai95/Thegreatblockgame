using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public int levelNum;
    public bool lastLevel;
    public GameObject playAgainButton;
    public GameObject returnToMainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        playAgainButton.SetActive(false);
        returnToMainMenuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Level complete!");
        }
        if (lastLevel)
        {
            playAgainButton.SetActive(true);
            returnToMainMenuButton.SetActive(true);
        }
        else
        {
            StartCoroutine("jumpToNextLevel");
        }
    }

        IEnumerator jumpToNextLevel()
        {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("taso" + levelNum);
        }
    
}
