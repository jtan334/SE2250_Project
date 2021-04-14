using UnityEngine;
using UnityEngine.UI;

public class AbilityPointText : MonoBehaviour
{
    public Text abilityPoint;

    void Update()
    {
        abilityPoint.text = Experience.ABILITYPOINTS.ToString();

    }
}
