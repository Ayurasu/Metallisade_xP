using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endScript : MonoBehaviour
{
    private GameManager manager;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        text.text = "Pisteet: " + manager.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
