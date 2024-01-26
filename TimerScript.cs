using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //for showing the time

public class Timer_Script : MonoBehaviour
{
    /* we will use core-rotuine(a single thred ) a single class which will run parallel with this class*/

    //varibale to show time
    public Text timer;
    //varibale for Game over message
    public Text message;

    //if the time over then player will be destroyed
    public GameObject player;
    
    //  time variable
    public int seconds = 20;
    // flag to pause coroutine
    bool flag = false;

    public Text game_win_message; // it will appear when we won the game

    // calculating the gems
    GameObject[] allgems; // array based on tags


    public GameObject camera; // to destroy the camera to over come the transfrom error

    public Button playagain;
    public Button menu;


    // Start is called before the first frame update
    void Start()
    {

        playagain.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
      //  menu.enabled = false;
        message.enabled = false; // diabled end message at the start of the game

        game_win_message.enabled = false; // disabling the win message at the start of the game


    }


    // Update is called once per frame
    void Update()
    {
        allgems = GameObject.FindGameObjectsWithTag("Gems"); // populating the array of gems


        if (!flag && seconds > 0)
        {
            if(allgems.Length == 0)
            {
                game_win_message.enabled = true;
                 menu.gameObject.SetActive(true);
             playagain.gameObject.SetActive(true);
                Destroy(player);
                Destroy(camera);
                StartCoroutine(redirect());
            }
            StartCoroutine(timerCalculate());
        }
        if (seconds == 0 && allgems.Length>0) { 
            message.enabled = true;
            Destroy(player);
            Destroy(camera);
       
        }
    }


    IEnumerator timerCalculate()
    {
        flag = true; // we are making flag true only for 1s to update the time
        seconds -= 1; 
        timer.text = ""+seconds; // now showing the time 

        // use keyword yeild when return IEnumerator
        yield return new WaitForSeconds(1);
        flag = false; // again to the original position
    }

    public void playAgain(){



        SceneManager.LoadScene(0);
    }

    public void gotomenu(){

        SceneManager.LoadScene(1);
    }
    IEnumerator redirect()

    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
