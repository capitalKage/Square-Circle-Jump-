using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 25;
    Player player;

    private void Awake()
    {
        //audio.PlayOneShot(Shot);
    }
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameOver == false && player.gameStart == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * Random.Range(7, speed));

        }
        else
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
