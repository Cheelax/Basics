using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Complete : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;

    public GameObject ActionText;

    public GameObject UIQuest;

    public GameObject ThePlayer;

    public GameObject ExMark;

    public GameObject CompleteTrigger;

    void Update()
    {
        this.TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (this.TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            ActionText.GetComponent<Text>().text = "Complete Text";


        }
        if (Input.GetButtonDown("Action"))
            {
                ExMark.SetActive(false);
                GlobalXp.CurentExp += 100;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                CompleteTrigger.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
