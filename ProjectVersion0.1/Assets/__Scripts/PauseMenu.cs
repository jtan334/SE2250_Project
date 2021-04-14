using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GAMEISPAUSED = false;
    public GameObject pauseMenuUI;

    //Needed to use the Level property
    //public Experience exp;

    //Needed to use access the AttackDamage property
    public PlayerCombat att;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GAMEISPAUSED)
                Resume();
            else
                Pause();
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GAMEISPAUSED = false;
    }
    void Pause() 
    { 
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GAMEISPAUSED = true;
    }
    public void LvlUpHealth()
    {
        if (Experience.ABILITYPOINTS >= 1)
        {
            PlayerHealth.MAXHEALTH += 25;
            Experience.ABILITYPOINTS--;
        }

    }
    public void LvlUpDamage()
    {
        if (Experience.ABILITYPOINTS >= 1)
        {
            PlayerCombat.attackDamage += 25;
            Experience.ABILITYPOINTS--;
        }

    }
}
