using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player" && !levelCompleted)
        {
            // Check if all items have been collected
            if (GameObject.FindGameObjectsWithTag("Ask").Length == 0)
            {
                finishSound.Play();
                levelCompleted = true;
                Invoke("CompleteLevel", 2f);
            }
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}