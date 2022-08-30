using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeloButton : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;

            if (!isActive)
            {
                Panel.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                Panel.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
