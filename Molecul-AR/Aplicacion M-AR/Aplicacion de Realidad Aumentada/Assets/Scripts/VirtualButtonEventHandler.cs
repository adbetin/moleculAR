/*==============================================================================
            Copyright (c) 2010-2011 QUALCOMM Incorporated.
            All Rights Reserved.
            Qualcomm Confidential and Proprietary
==============================================================================*/

using UnityEngine;

public class VirtualButtonEventHandler :    MonoBehaviour,
                                            IVirtualButtonEventHandler
{

    public Material[] m_TeapotMaterials;

    private GameObject mTeapot;

    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

        // Get handle to the teapot object
        mTeapot = transform.FindChild("teapot").gameObject;
    }


    // Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");

        if (!IsValid())
        {
            return;
        }

        // Apply the new texture:
        switch (vb.VirtualButtonName)
        {
            case "red":
                mTeapot.renderer.material = m_TeapotMaterials[0];
                break;

            case "blue":
                mTeapot.renderer.material = m_TeapotMaterials[1];
                break;

            case "yellow":
                mTeapot.renderer.material = m_TeapotMaterials[2];
                break;

            case "green":
                mTeapot.renderer.material = m_TeapotMaterials[3];
                break;
        }
    }


    // Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (!IsValid())
        {
            return;
        }

        mTeapot.renderer.material = m_TeapotMaterials[4];
    }


    private bool IsValid()
    {
        // Check the materials and teapot have been set:
        return  m_TeapotMaterials != null &&
                m_TeapotMaterials.Length == 5 &&
                mTeapot != null;
    }
}
