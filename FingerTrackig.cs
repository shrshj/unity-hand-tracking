using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;

public class FingerTracking: MonoBehaviour
{

    public GameObject jointMarker;

    GameObject thumbObject;

    MixedRealityPose pose;

    void Start()
    {
        thumbObject = Instantiate(jointMarker, this.transform);

    }

    void Update()
    {

        thumbObject.GetComponent<Renderer>().enabled = false;


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out pose))
        {
            thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObject.transform.position = pose.Position;
        }




    }
}