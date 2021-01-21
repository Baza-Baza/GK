using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject Panel;
    Vector3 startPosPlayer;


    private void Start()
    {
        startPosPlayer = Player.GetComponent<Rigidbody>().position;


    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Player.GetComponent<moveSphere>().enabled = false;
            Player.SetActive(false);
            Player.transform.position = startPosPlayer;
            Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Player.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            Panel.SetActive(true);
        }

    }
}
