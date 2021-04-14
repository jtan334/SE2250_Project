using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    public Text health;

    void Update()
    {
        health.text = "Ability Points: " + Experience.ABILITYPOINTS.ToString();
        health.text += "\nHealth: " + PlayerHealth.MAXHEALTH.ToString();
        health.text += "\nAttack Damage: " + PlayerCombat.attackDamage.ToString();
        health.text += "\nSpeed: "; //+ PlayerHealth.MAXHEALTH.ToString();

    }
}
