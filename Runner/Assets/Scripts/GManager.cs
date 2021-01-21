using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Panel;
    public Text textThreads;
    public Text FinishThreads;
    public int Threads = 0;
    private GameObject[] gems;
    public GameObject StartPAnel;



    void Start()
    {
        gems = GameObject.FindGameObjectsWithTag("Thread");
    }
    public void AddThreads(int number)
    {
        Threads += number;
        textThreads.text = Threads.ToString();
        FinishThreads.text = Threads.ToString();    }

    public void Restart()
    {
        Threads = 0;
        AddThreads(0);
        Panel.SetActive(false);
        Player.SetActive(true);
        Player.GetComponent<moveSphere>().enabled = true;
        for (int i = 0; i < gems.Length; i++)
        {
            gems[i].gameObject.SetActive(true);
        }
    }

    public void Load()
    {
        SceneManager.LoadScene("2");
    }

    public void StartGAmeplay()
    {
        StartPAnel.SetActive(false);
        Player.GetComponent<Rigidbody>().useGravity = true;
        Player.GetComponent<moveSphere>().enabled = true;
        
    
    }
}
