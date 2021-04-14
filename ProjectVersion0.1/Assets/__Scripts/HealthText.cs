using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text health;

    void Update()
    {
        health.text = "distance" + PlayerHealth.MAXHEALTH.ToString();

    }
}
