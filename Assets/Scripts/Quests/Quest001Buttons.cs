﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour
{
    public GameObject ThePlayer;

    public GameObject NoticeCam;

    public GameObject UIQuest;

    public GameObject ActiveQuestBox;

    public GameObject Objective01;
    public GameObject Objective02;
    public GameObject Objective03;

    public GameObject Exmark;
    public GameObject TheNotice;
    public GameObject NoticeTrigger;

    IEnumerator SetQuestUI()
    {
        Exmark.SetActive(false);
        TheNotice.SetActive(false);
        NoticeTrigger.SetActive(false);

        ActiveQuestBox.GetComponent<Text>().text = "My First Weapon";
        Objective01.GetComponent<Text>().text = "Reach the clearing in the wood";
        Objective02.GetComponent<Text>().text = "Open the chest";
        Objective03.GetComponent<Text>().text = "Retrive the weapon";

        QuestManager.ActiveQuestNumber = 1;
      
        yield return  new WaitForSeconds(0.5f);
        ActiveQuestBox.SetActive(true);
        yield return new  WaitForSeconds(1);

        Objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        Objective02.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        Objective03.SetActive(true);
        yield return new WaitForSeconds(9);

        Objective01.SetActive(false);
        Objective02.SetActive(false);
        Objective03.SetActive(false);
    }

    public void AcceptQuest()
    {
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }

    public void DeclineQuest()
    {
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        UIQuest.SetActive(false);
    }
}