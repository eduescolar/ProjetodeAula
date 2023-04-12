using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenucontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(string levelName)
    {
        Gamemanager.instance.LoadScene(levelName);
        
    }
    
}