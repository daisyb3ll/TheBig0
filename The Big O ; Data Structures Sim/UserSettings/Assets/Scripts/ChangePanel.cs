using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PanelChanger : MonoBehaviour
{
    public GameObject ThisPanel;

    public void HidePanel()
    {
        ThisPanel.SetActive(false);
    }

    public void ShowPanel()
    {
        ThisPanel.SetActive(true);
    }
}
