using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Sequence sequence;

    [SerializeField] private TextMeshProUGUI numberText;
    private int amountButtonPressed = 0;
    
    public void DisplayNextNumber()
    {
        numberText.text = sequence.GetFc(amountButtonPressed); // Get the number from the array and put it into text
        amountButtonPressed++; // Add 1 to Button pressed counter
        SoundManager.PlaySound("SequenceIncrease_Clip");
    }
}
