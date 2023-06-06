using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{

    // public GameObject ScoreText;
    public int theScore;
    public AudioSource collectSound;
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
                Debug.Log("p��");
                collectSound.Play();
            }
        Debug.Log(theScore);
        manager.UpdateScore(theScore);
            Destroy(gameObject);






        } 
    }


