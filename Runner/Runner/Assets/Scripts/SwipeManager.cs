using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    int speed = 5;
    Vector2 lastPoint;//make this private if you want to.

    void Update()
    {

        float offset; //offset of the touch from last frame

        if (Input.touches.Length > 0)//make sure we have a touch in the first place
        {

            Touch evt = Input.touches[0];//setting up touch events so we can get fancy.

            if (evt.phase == TouchPhase.Began)//this is the first frame the screen has been touched for, simply save the point.
            {

                lastPoint = evt.position;

            }
            else if (evt.phase == TouchPhase.Moved)
            {

                offset = evt.position.x - lastPoint.x;//take the difference
                                                      //I'm going to use Transform.Rotate because it's handy dandy
                transform.Rotate(0, offset * speed * Time.deltaTime, 0);
                //save the new "lastPoint"

                lastPoint = evt.position;

            }
            else if (evt.phase == TouchPhase.Ended)
            {

                //If you want the object to drift after you spin it you can make a function to go here.
                //To do this, take the speed of the rotation and continue to rotate all while subtracting off of the speed.
                //I would use the Transform.Rotate function on this too.
                //If you need me to I could write this function too.


            }

        }

    }
}


