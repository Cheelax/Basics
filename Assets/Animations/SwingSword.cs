using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject TheSword;
    public int SwordStatut;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && SwordStatut == 0 && AttackBlocker.BlockSword == 0)
        {
            StartCoroutine(SwingSwordFunction());
        }
    }

    IEnumerator SwingSwordFunction()
    {
        SwordStatut = 1;
        TheSword.GetComponent<Animation>().Play("ElvenSwordAnim");
        SwordStatut = 2;
        yield return new WaitForSeconds(1.0f);
        SwordStatut = 0;

    }
}
