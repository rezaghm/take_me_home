using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class radio : MonoBehaviour
{
    public bool enter_tile;
    public bool in_home;
    public bool isbeingHeld = false;
    public bool intile = false;
    public bool insowman = false;
    public bool drawing = false;
    public bool instone = false;
    public bool stop_drawing ;
    public bool draw;
    public int star_count = 0;
    public int overall_star = 0;
    public bool dont_cut;
    public bool end;
    public bool balot_collected = false;
    public bool balot_in_scene = false;
    public bool level_started = false;
    public bool game_played = false;
    public string level_name;
    public bool save_lavel = true;
    public bool stop_drawing_count = true;
    public bool save_the_star = true;
    public int pls_work ;
    // Start is called before the first frame update
    void Start()
    {
        level_name = SceneManager.GetActiveScene().name;
        if(level_name == "menu")
        {
            save_lavel = false;
        }
        star_count += PlayerPrefs.GetInt("overall_star") ;
        save_the_star = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (level_started == true && save_lavel == true)
        {
            string level_name = SceneManager.GetActiveScene().name;
            Debug.Log(level_name);
            PlayerPrefs.SetString("active_scene", level_name);
            level_started = false;
            game_played = true;
            PlayerPrefs.SetString("game_played",game_played.ToString());
        }
        if(save_the_star == true)
        {
            if (end == true)
            {
                //overall_star = PlayerPrefs.GetInt("overall_star")+ star_count;
               // PlayerPrefs.SetInt("star_to_show", overall_star);
                //pls_work = PlayerPrefs.GetInt("star_to_show");
                save_the_star = false;
            }
        }
        
    }
}
