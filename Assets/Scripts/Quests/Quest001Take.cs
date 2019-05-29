using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001Take : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;

    public GameObject ActionText;

    public GameObject UIQuest;

    public GameObject ThePlayer;

    public GameObject NoticeCam;
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
            AttackBlocker.BlockSword = 1;

        }
        if (Input.GetButtonDown("Action"))
        {
                AttackBlocker.BlockSword = 2;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);

                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);
                ThePlayer.SetActive(false);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
        }
    }

    void OnMouseExit()
    {
        AttackBlocker.BlockSword = 0;
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
