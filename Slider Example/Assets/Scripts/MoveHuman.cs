using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveHuman : MonoBehaviour
{
    public GameObject Left_leg;
    public GameObject Left_leg2;
    public GameObject B_upper_arm_L;
    public GameObject B_upper_arm_L2;
    public GameObject B_upper_arm_R;
    public GameObject B_upper_arm_R2;
    public GameObject PAnel;
    public GameObject FirstObject;
    public GameObject SecondObject;
    public Slider sliderScale;
    public Slider sliderRotationZ;
    public Slider sliderRotationY;
    public Text MyText;

    public void Scale()
    {
        gameObject.transform.localScale = new Vector3(sliderScale.value, sliderScale.value, sliderScale.value);
    }

    public void RotateLeftLeg()
    {
        Vector3 currentRotation = Left_leg.transform.rotation.eulerAngles;
        Left_leg.transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, sliderRotationZ.value * 180);
    }
    public void B_upperL()
    {
        Vector3 currentRotation = B_upper_arm_L.transform.rotation.eulerAngles;
        B_upper_arm_L.transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, sliderRotationZ.value * 130);
    }
    public void RotateB_upper_R()
    {
        Vector3 currentRotation = B_upper_arm_R.transform.rotation.eulerAngles;
        B_upper_arm_R.transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, sliderRotationY.value *-100 );
    }
/*    private void Update()
    {
        if ( Quaternion.Angle(B_upper_arm_L.transform.rotation, B_upper_arm_L2.transform.rotation) < 5.0f &&
                      Vector3.Distance(FirstObject.transform.localScale, SecondObject.transform.localScale) < 0.5f &&
                      Quaternion.Angle(B_upper_arm_R.transform.rotation, B_upper_arm_R2.transform.rotation) < 5.0f &&
                      Quaternion.Angle(Left_leg.transform.rotation, Left_leg2.transform.rotation) < 5.0f )
        {
            PAnel.SetActive(true);
            Debug.Log("Done");
        }
    }*/
    public void CheckButton()
    {
        if (Quaternion.Angle(B_upper_arm_L.transform.rotation, B_upper_arm_L2.transform.rotation) < 10.0f &&
                       Vector3.Distance(FirstObject.transform.localScale, SecondObject.transform.localScale) < 0.5f &&
                       Quaternion.Angle(B_upper_arm_R.transform.rotation, B_upper_arm_R2.transform.rotation) < 10.0f &&
                       Quaternion.Angle(Left_leg.transform.rotation, Left_leg2.transform.rotation) < 10.0f)
        {
            PAnel.SetActive(false);
            MyText.enabled = true;
            MyText.text = "100%";
            SceneManager.LoadScene(1);
        }
        else if (Quaternion.Angle(B_upper_arm_L.transform.rotation, B_upper_arm_L2.transform.rotation) < 15.0f &&
                       Vector3.Distance(FirstObject.transform.localScale, SecondObject.transform.localScale) < 0.7f &&
                       Quaternion.Angle(B_upper_arm_R.transform.rotation, B_upper_arm_R2.transform.rotation) < 15.0f &&
                       Quaternion.Angle(Left_leg.transform.rotation, Left_leg2.transform.rotation) < 15.0f)
        {
            PAnel.SetActive(false);
            MyText.enabled = true;
            MyText.text = "75%";
            SceneManager.LoadScene(1);
        }
        else if (Quaternion.Angle(B_upper_arm_L.transform.rotation, B_upper_arm_L2.transform.rotation) < 20.0f &&
                     Vector3.Distance(FirstObject.transform.localScale, SecondObject.transform.localScale) < 0.7f &&
                     Quaternion.Angle(B_upper_arm_R.transform.rotation, B_upper_arm_R2.transform.rotation) < 20.0f &&
                     Quaternion.Angle(Left_leg.transform.rotation, Left_leg2.transform.rotation) < 20.0f)
        {
            PAnel.SetActive(false);
            MyText.enabled = true;
            MyText.text = "50%";
            SceneManager.LoadScene(1);
        }
        else
        {
            PAnel.SetActive(false);
            MyText.enabled = true;
            MyText.text = "0%";
            SceneManager.LoadScene(1);
        }
    }

}


