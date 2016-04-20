using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VoidBarController : MonoBehaviour
{

    public Image voidBarHealth;

    void Update()
    {
        voidBarHealth.fillAmount = (PlayerVoid.voidTime / 5) * Time.deltaTime;
    }
}
