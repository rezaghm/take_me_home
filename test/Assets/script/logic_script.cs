using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_script : MonoBehaviour
{
    private radio enter_in_radio;
    public Text value_of_the_moved_tile;
    public Text score_text;
    public int sorce;
    public int sorce_need_for_3star;
    public GameObject endig;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public float delay = 2;
    public float timer;
    public bool sicle = true ;
    public string level;
    public string saved_level;
    public string game_played;


    private void Start()
    {
        game_played = PlayerPrefs.GetString("game_played");
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
        sorce_need_for_3star += sorce;
    }
     public void addscore()
    {
        sorce += 1;
        value_of_the_moved_tile.text = sorce.ToString();
    }
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer> delay)
        {
            if (enter_in_radio.end == true)
            {
                endig.SetActive(true);
            }
        }
        
        if (sorce == sorce_need_for_3star)
        {
            save_score(3);
        }
        if (sorce == sorce_need_for_3star + 1)
        {
            save_score(2);
            star3.SetActive(false);
        }
        if (sorce == sorce_need_for_3star + 2)
        {
            save_score(1);
            star3.SetActive(false);
            star2.SetActive(false);

        }
        if (sorce > sorce_need_for_3star + 2)
        {
            star3.SetActive(false);
            star2.SetActive(false);
            star1.SetActive(false);
        }
    }
    public void save_score(int star)
    {
        if(enter_in_radio.end == true)
        {
            if(sicle == true)
            {
                enter_in_radio.star_count += star;
                sicle = false;
            }
        }
    }
    public void restar_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void next_level()
    {
        SceneManager.LoadScene(level);
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void start()
    {
        
        if(game_played == "True")
        {
            saved_level = PlayerPrefs.GetString("active_scene");

            SceneManager.LoadScene(saved_level);
        }
        else
        {
            SceneManager.LoadScene("level1");
        }
    }
}
