using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashtimer : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        Gamemanager.instance.LoadScene("mainmenu");
    }

}