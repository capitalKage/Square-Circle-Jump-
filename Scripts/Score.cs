using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public AudioClip scoreClip;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            player.playerScore++;
            gameObject.GetComponent<AudioSource>().PlayOneShot(scoreClip);
            Destroy(collision.gameObject);
        }
        else
        {
            player.gameOver = true;
            Destroy(collision.gameObject);
        }
        
    }
}
