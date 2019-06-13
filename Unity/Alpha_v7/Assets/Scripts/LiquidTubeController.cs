using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidTubeController : MonoBehaviour {

    // Patch Pure Data
    public LibPdInstance pdPatch;

    /*Changing the scale of the z axis while changing the position along the z axis,
 * giving the visual effect that the fluid is moving in one direction. Doing it
 * this way because Unity scales in two directions, not one.*/

    public GameObject tube;
    public GameObject headAnchorDummy;
    public GameObject container;

    [Tooltip("For ex. voldrums or vollead")]
    public string bangToSend;

    //0,0,0.005 
    [Tooltip("Use 0,0,0.005 by default")]
    public Vector3 ExpandZ;

    //0,0,0.0025
    [Tooltip("Use 0,0,0.0025 by default")]
    public Vector3 MoveZ;

    Vector3 headContainerPosition;
    Vector3 botContainerPosition;

    private void Start()
    {
        headContainerPosition = container.transform.position + container.transform.localScale;
        botContainerPosition = container.transform.position - container.transform.localScale;
    }
    // Update is called once per frame
    void Update()
    {

        Vector3 currentHeadTubePosition = tube.transform.position + tube.transform.localScale;

        if (headAnchorDummy.transform.position.y > currentHeadTubePosition.y + 0.01)
        {
            //makes the cube scale bigger on the Z axis
            tube.transform.localScale += ExpandZ;

            //transforms the position of the cube to make it appear that it is only expanding on one side
            tube.transform.position += MoveZ;

            float value = (currentHeadTubePosition.y - botContainerPosition.y) * 127.0f / (headContainerPosition.y - botContainerPosition.y);
            pdPatch.SendFloat(bangToSend, value);
            //Debug.Log(value);
        }

        else if (headAnchorDummy.transform.position.y < currentHeadTubePosition.y - 0.01)
        {
            //makes the cube scale bigger on the Z 
            tube.transform.localScale -= ExpandZ;

            //transforms the position of the cube to make it appear that it is only expanding on one side
            tube.transform.position -= MoveZ;

            float value = (currentHeadTubePosition.y - botContainerPosition.y) * 127.0f / (headContainerPosition.y - botContainerPosition.y);
            pdPatch.SendFloat(bangToSend, value);
            //Debug.Log(value);
        }

    }

}
