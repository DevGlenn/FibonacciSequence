using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioClip restartSound, openInfoPanelSound, closeInfoPanelSound, sequenceIncreaseSound; // Instantiate all of the AudioClips
    private static AudioSource audioSrc;
    void Start()
    {
        restartSound = Resources.Load<AudioClip>("Sound/Sounds/Restart_Clip"); // Find the Clips in the Resources folder
        openInfoPanelSound = Resources.Load<AudioClip>("Sound/Sounds/OpenInfoPanel_Clip");
        closeInfoPanelSound = Resources.Load<AudioClip>("Sound/Sounds/CloseInfoPanel_Clip");
        sequenceIncreaseSound = Resources.Load<AudioClip>("Sound/Sounds/SequenceIncrease_Clip");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip) // Make this static function so I can call it in other scripts wherever needed, so I don't need to reference this script all the time
    {
        switch (clip) // I used a switch case for the sound clips cause I find this way to be really clean and managable
        {
            case "Restart_Clip":
                audioSrc.PlayOneShot(restartSound);
                break;
            case "OpenInfoPanel_Clip":
                audioSrc.PlayOneShot(openInfoPanelSound);
                break;
            case "CloseInfoPanel_Clip":
                audioSrc.PlayOneShot(closeInfoPanelSound);
                break;
            case "SequenceIncrease_Clip":
                audioSrc.PlayOneShot(sequenceIncreaseSound);
                break;

        }
    }
}
