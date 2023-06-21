using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultyButton : MonoBehaviour
{
    // Start is called before the first frame update
    public int difficulty;
    private Button button;
    private GameManager gameManager;
    
    
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficulty);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.setDifficulty(this.difficulty);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
