using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public Player thePlayer;
    Text scoreText;
    public GameObject player;
   

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




    }

}