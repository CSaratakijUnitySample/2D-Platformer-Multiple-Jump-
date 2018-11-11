using UnityEngine;
using UnityEngine.UI;

public class UIPlayerJumpInfo : MonoBehaviour
{
    [SerializeField]
    PlayerController player;

    [SerializeField]
    Text lblMaxAllowJump;

    [SerializeField]
    Text lblTotalJumpLeft;

    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        lblMaxAllowJump.text = ("Max Allow Airbone Jump : " + player.MaxAllowAirboneJump);
        lblTotalJumpLeft.text = ("Total Jump Left : " + player.TotalJumpLeft);
    }
}
