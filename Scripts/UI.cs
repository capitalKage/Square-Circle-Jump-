using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip buttonclip;
    Player player;
    public TMP_Text scoreText;
    public GameObject startUI, gameoverUI;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + player.playerScore.ToString();

        if(player.gameOver == true)
        {
            gameoverUI.SetActive(true);
        }
    }

    public void GameStart()
    {
        startUI.SetActive(false);
        player.gameStart = false;
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    public void GameReplay()
    {
        SceneManager.LoadScene(0);
    }

    public void AudioButton()
    {
        audio.PlayOneShot(buttonclip);
    }
}
