using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    
    public void ReloadScene()
   {
        SoundManager.PlaySound("Restart_Clip");
        SceneManager.LoadScene(0); // Reload the main scene

   }
}
