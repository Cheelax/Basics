using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Objective02 : MonoBehaviour
{
    public float TheDistance;

    public GameObject TreasureChest;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheObjective;
    public int CloseObjective;

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
            ActionText.GetComponent<Text>().text = "Open Chest";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            TreasureChest.GetComponent<Animation>().Play("Q01ChestOpen");
            CloseObjective = 3;
            ActionText.SetActive(false);
            ActionDisplay.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
