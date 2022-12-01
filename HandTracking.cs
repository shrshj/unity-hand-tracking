using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;

public class HandTracking : MonoBehaviour
{

    public GameObject sphereMarker;

    private GameObject[] LeftHand;
    private GameObject[] RightHand;
    private int n = 26; // 0 is none


    MixedRealityPose pose;

    void Start()
    {

        LeftHand = new GameObject[n];
        RightHand = new GameObject[n];

        for(int i=0; i < n; i++)
        {
            LeftHand[i] = Instantiate(sphereMarker, this.transform);
            RightHand[i] = Instantiate(sphereMarker, this.transform);
        }


    }

    void Update()
    {

        for (int i = 0; i < n; i++)
        {
            LeftHand[i].GetComponent<Renderer>().enabled = false;
            RightHand[i].GetComponent<Renderer>().enabled = false;
        }


        for (int i = 0; i < n; i++)
        {

            TrackedHandJoint joint_index = (TrackedHandJoint)i + 1;
            if (HandJointUtils.TryGetJointPose(joint_index, Handedness.Right, out pose))
            {
                RightHand[i].GetComponent<Renderer>().enabled = true;
                RightHand[i].transform.position = pose.Position;
            }
 

            if (HandJointUtils.TryGetJointPose(joint_index, Handedness.Left, out pose))
            {
                LeftHand[i].GetComponent<Renderer>().enabled = true;
                LeftHand[i].transform.position = pose.Position;
            }
        }



    }
}
