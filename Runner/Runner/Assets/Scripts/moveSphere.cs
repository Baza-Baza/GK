using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSphere : MonoBehaviour
{
    int m_Speed = 3;
    private CharacterController controller;
    public GManager Gm;
    private GameObject[] gems;

    private void Update()
    {
        transform.position += transform.forward *m_Speed* Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Thread"))
            return;

        Gm.AddThreads(1);
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        other.gameObject.SetActive(false);
        //Destroy(other.gameObject);
    }
}