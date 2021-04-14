using UnityEngine;
using UnityEngine.UI;


public class Stats : MonoBehaviour
{
    public Text abilityPoint;
    public Text attackDamage;
    public Text health;

    /*/Needed to use the Level property
    public Experience exp;

    //Needed to use access the AttackDamage property
    public PlayerCombat att;*/

    public Experience exp;

    // Update is called once per frame
    void Update()
    {
        abilityPoint.text = Experience.ABILITYPOINTS.ToString();
        attackDamage.text = PlayerHealth.MAXHEALTH.ToString();
        //health.text = Experience.ABILITYPOINTS.ToString() + "\n" + PlayerHealth.MAXHEALTH.ToString();
    }
}
