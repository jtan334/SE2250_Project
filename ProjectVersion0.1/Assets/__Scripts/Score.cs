using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Experience exp;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = exp.Score.ToString();
    }
}
