using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionScript : MonoBehaviour
{
    public GameObject DescriptionPanel;
    public GameObject DetailHewanPanel;
    public GameObject SuaraHewanPanel;
    public GameObject StatusHewanPanel;

    private GameObject activePanel;

    void Start()
    {
        DescriptionPanel.SetActive(false);
        DetailHewanPanel.SetActive(false);
        SuaraHewanPanel.SetActive(false);
        StatusHewanPanel.SetActive(false);
    }

    void ActivatePanel(GameObject panel)
    {
        if (activePanel == panel)
        {
            activePanel.SetActive(false);
            activePanel = null;
        }
        else
        {
            if (activePanel != null)
                activePanel.SetActive(false);

            activePanel = panel;
            activePanel.SetActive(true);
        }
    }

    public void NamaHewan()
    {
        ActivatePanel(DescriptionPanel);
    }

    public void DetailHewan()
    {
        ActivatePanel(DetailHewanPanel);
    }

    public void SuaraHewan()
    {
        ActivatePanel(SuaraHewanPanel);
    }

    public void StatusHewan()
    {
        ActivatePanel(StatusHewanPanel);
    }
}
