using UnityEngine;
using UnityEngine.UI;

public class AttackDamageText : MonoBehaviour
{
    public Text attackDamage;

    void Update()
    {
        attackDamage.text = PlayerCombat.attackDamage.ToString();

    }
}
