using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Objective03 : MonoBehaviour
{
    public float TheDistance;

    public GameObject FakeSword;
    public GameObject RealSword;
    public GameObject ActionText;
    public GameObject ActionDisplay;
    public GameObject TheObjective;
    public int CloseObjective;

    public GameObject QuestComplete;
    public GameObject Exmark;

    void Update()
    {
        this.TheDistance = PlayerCasting.DistanceFromTarget;

        if (CloseObjective == 3)
        {
            if (TheObjective.transform.localScale.y <= 0.00f)
            {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }
            else
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.0f, 0.0f);
            }
        }
    }

    void OnMouseOver()
    {
        if (this.TheDistance <= 3)
        {
            ActionText.GetComponent<Text>().text = "Take Sword";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            FakeSword.SetActive(false);
            RealSword.SetActive(true);
            CloseObjective = 3;
            ActionText.SetActive(false);
            ActionDisplay.SetActive(false);
            QuestComplete.SetActive(true);
            Exmark.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}