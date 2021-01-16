using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelActivator : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject helpButton;
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject restartButton;

    private void Start()
    {
        if(infoPanel == isActiveAndEnabled)
        {
            helpButton.SetActive(false);
            startButton.SetActive(false);
            restartButton.SetActive(false);
        }
    }

    public void DeactivePanel()
    {
        infoPanel.SetActive(false); // Whenever you press the coresponding button, turn the info panel off
        helpButton.SetActive(true);
        startButton.SetActive(true);
        restartButton.SetActive(true);
        SoundManager.PlaySound("CloseInfoPanel_Clip");
    }

    public void ActivatePanel()
    {
        infoPanel.SetActive(true); // Whenever you press the coresponding button, turn the info panel on
        if (infoPanel == isActiveAndEnabled)
        {
            helpButton.SetActive(false);
            startButton.SetActive(false);
            restartButton.SetActive(false);
        }

        SoundManager.PlaySound("OpenInfoPanel_Clip");
        

    }
}
