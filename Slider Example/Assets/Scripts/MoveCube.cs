using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveCube : MonoBehaviour
{
    public GameObject PAnel;
    public GameObject FirstObject;
    public GameObject SecondObject;
    public Slider sliderScale;
    public Slider sliderRotationZ;
    public Slider sliderRotationY;




    public void Scale()
    {
        gameObject.transform.localScale = new Vector3(sliderScale.value, sliderScale.value, sliderScale.value);
    }

    public void RotateMyObject()
    {
        Vector3 currentRotation = gameObject.transform.rotation.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(currentRotation.x, sliderRotationY.value * 360, currentRotation.z);
    }
    public void TiltMyObject()
    {
        Vector3 currentRotation = gameObject.transform.rotation.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(sliderRotationZ.value * 360, currentRotation.y, currentRotation.z);
    }
    private void Update()
    {
        if(Vector3.Distance(SecondObject.transform.position, FirstObject.transform.position) < 5.0f &&
                      Quaternion.Angle(SecondObject.transform.rotation, FirstObject.transform.rotation) < 5.0f &&
                      Vector3.Distance(SecondObject.transform.localScale, FirstObject.transform.localScale) < 0.5f)
        {
            PAnel.SetActive(true);
            Debug.Log("Done");
        }
    }

}


