using UnityEngine;
using System.Collections;



public class CameraFollow : MonoBehaviour {

    public GameObject target;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
        if (target != null)
        {
            if (target.transform.position.y > 5)
                transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 3, -10);
            else if (target.transform.position.x < 0)
                transform.position = new Vector3(0, 0, -10);
            else
                transform.position = new Vector3(target.transform.position.x, 0, -10);
        }
    }
}
