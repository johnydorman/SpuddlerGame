using UnityEngine;
using System.Collections;

public class PlayerVoid : MonoBehaviour
{

    public static bool voidOn = false;
    public static float voidTime = 5;
    private bool _canCallVoid = true;
    private bool _callVoidTimer = true;
    private bool _callVoidRecharge = true;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp("e") && _canCallVoid)
        {
            StartCoroutine(callVoidWait());
            if (voidTime > 0)
            {
                if (!voidOn)
                {
                    voidOn = true;
                }
                else if (voidOn)
                {
                    voidOn = false;
                }
            }   
        }

        if (voidOn && _callVoidTimer)
        {
            StartCoroutine(voidTimer());
        }
        else if (!voidOn && _callVoidRecharge && voidTime < 5)
        {
            StartCoroutine(voidRecharge());
        }


        if (voidTime <= 0.1f)
        {
            voidOn = false;
        }

    }

    IEnumerator callVoidWait()
    {
        _canCallVoid = false;
        yield return new WaitForSeconds(0.2f);
        _canCallVoid = true;
    }

    IEnumerator voidTimer()
    {
        _callVoidTimer = false;
        yield return new WaitForSeconds(0.1f);
        voidTime -= 0.1f;
        _callVoidTimer = true;
    }

    IEnumerator voidRecharge()
    {
        _callVoidRecharge = false; 
        yield return new WaitForSeconds(0.1f);
        voidTime += 0.2f;
        _callVoidRecharge = true;
    }

    void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 200, 20), "VoidOn = " + voidOn);
        GUI.Label(new Rect(10, 30, 200, 20), "Void charge: " + Mathf.Round(voidTime) + " seconds left");
        //GUI.Label(new Rect(10, 50, 200, 20), "inLevel = " + NextLevelController.inLevel);
        //GUI.Label(new Rect(10, 70, 200, 20), "chakraRed = " + PlayerChakra.chakraRed);
        //GUI.Label(new Rect(10, 90, 200, 20), "chakraGreen = " + PlayerChakra.chakraGreen);
        //GUI.Label(new Rect(10, 110, 200, 20), "chakraBlue = " + PlayerChakra.chakraBlue);
    }
}