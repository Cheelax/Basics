using UnityEngine;

public class HearthCollect : MonoBehaviour
{
    public int RotateSpeed;

    public AudioSource CollectSound;

    public GameObject ThisHeart;

    void Start()
    {
        ThisHeart.SetActive(true);
        RotateSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,RotateSpeed,0);
    }

    void OnTriggerEnter()
    {
        //son non joué
        CollectSound.Play();
        HealthMonitor.HealthValue++;
        ThisHeart.SetActive(false);

    }
}