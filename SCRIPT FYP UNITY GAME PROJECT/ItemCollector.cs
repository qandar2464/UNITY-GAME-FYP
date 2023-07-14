using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int wordsCollected = 0;
    private int totalWords = 0;

    [SerializeField] private Text wordText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        // Count the total number of items in the level
        totalWords = GameObject.FindGameObjectsWithTag("Ask").Length;
        UpdateWordText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ask"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            wordsCollected++;

            UpdateWordText();

            // Check if all items have been collected
            if (wordsCollected == totalWords)
            {
                // Enable the Finish script on the level complete trigger object
                GameObject.FindGameObjectWithTag("Finish").GetComponent<Finish>().enabled = true;
            }
        }
    }

    private void UpdateWordText()
    {
        wordText.text = "Words Collected: " + wordsCollected + "/" + totalWords;
    }
}