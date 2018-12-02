using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour {

    public Transform trans;
    public Transform trans1;
    public Vector3 pos;

    // Update is called once per frame
    void Update () {
        trans1.position=trans.position+pos;
		
	}
}
