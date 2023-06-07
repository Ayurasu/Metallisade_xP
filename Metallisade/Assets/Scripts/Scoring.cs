using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{

    // public GameObject ScoreText;
    public int theScore;
    public AudioSource collectSound;
    public TextMeshProUGUI replayScore;
    private GameManager manager;
   

    // Start is called before the first frame update
    void Start() {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }



    void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.GetComponent<PlayerController>()) {
            return;
        }

        if (collectSound)
            {
                Debug.Log("pöö");
                collectSound.Play();
            }
        Debug.Log(theScore);
        manager.UpdateScore(theScore);
            Destroy(gameObject);
        }

   
}




