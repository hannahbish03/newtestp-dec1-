using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectables : MonoBehaviour
{
    public Player thePlayer;
    Text scoreText;
    public GameObject player;
    private int Win; 

   // Use this for initialization
    void Start()
    {  
        scoreText = GameObject.Find("scoreText").GetComponent<Text>();
        thePlayer = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        thePlayer.score += 1;
        scoreText.text = "Score: " + thePlayer.score;
        Destroy(gameObject);

        if (thePlayer.score > 25)
        {
           SceneManager.LoadScene(2);
           // go to win scene 

        }


    }

}