using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experience : MonoBehaviour
{
    public float levelCap=100;
    private int level=1;
    public static int ABILITYPOINTS = 0;


    public Slider slider;
    /*public void SetMinExperience()
    {
        slider.minValue = exprience;
    }*/
    public void SetMaxExperience()
    {
        slider.maxValue = levelCap;
        slider.value = slider.minValue;
    }

    public void SetExperience(float exp)
    {
        slider.value = exp;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (exprience >= levelCap)
            LevelUp();
    }
    void LevelUp()
    {
        exprience = exprience - levelCap;
        levelCap += 125;
        SetMaxExperience();
        ABILITYPOINTS++;
        level++;
        //levelCap += levelCap * 1.25f;
        //SetMinExperience();
        //SetMaxExperience();
    }

    private float exprience = 0;
    public float Exprience
    {
        get { return exprience; }
        set { exprience = value; }
    }

    private float score = 0;
    public float Score
    {
        get { return score; }
        set { score = value; }
    }

    /*public int AbilityPoint
    {
        get { return abilityPoint; }
        set { abilityPoint = value; }
    }*/
}
