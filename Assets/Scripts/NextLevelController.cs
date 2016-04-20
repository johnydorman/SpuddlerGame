using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{

    public static bool inLevel = false;
    public GameObject target;
    public static int levelNum = 1;

    public bool recheckPlayer = false;
    void Awake()
    {
        DontDestroyOnLoad(this);
        Instantiate(target, new Vector3(-6f, -2.635f, 0f), Quaternion.identity);
    }

    void Update()
    {
        if (!recheckPlayer)
        {
            target = GameObject.FindGameObjectWithTag("Player");
            recheckPlayer = true;
        }

        if (Input.GetKeyUp("q") && GlowFadeController.character)
        {

            if (inLevel)
            {
                SceneManager.LoadScene(0);
                GlowFadeController.character = false;
                target.transform.position = new Vector3(-2.37f, -2.635f, 0f);
                inLevel = false;
                levelNum = 1;
            }

            else if (!inLevel)
            {
                if (PlayerChakra.chakraRed && !PlayerChakra.chakraBlue && !PlayerChakra.chakraGreen)
                {
                    SceneManager.LoadScene(2);
                    GlowFadeController.character = false;
                    target.transform.position = new Vector3(-7.284576f, -2.795f, 0f);
                    inLevel = true;
                    levelNum = 3;
                }
                else if (PlayerChakra.chakraRed && PlayerChakra.chakraBlue && !PlayerChakra.chakraGreen)
                {
                    SceneManager.LoadScene(3);
                    GlowFadeController.character = false;
                    target.transform.position = new Vector3(-7.284576f, -2.795f, 0f);
                    inLevel = true;
                    levelNum = 4;
                }
                else if (PlayerChakra.chakraRed && PlayerChakra.chakraBlue && PlayerChakra.chakraGreen)
                {
                    SceneManager.LoadScene(4);
                    GlowFadeController.character = false;
                    target.transform.position = new Vector3(10f, 0f, 0f);
                    inLevel = true;
                    levelNum = 5;
                }
                else
                {
                    SceneManager.LoadScene(1);
                    GlowFadeController.character = false;
                    inLevel = true;
                    target.transform.position = new Vector3(-5.17383f, -2.635f, 0f);
                    //KeyManager.QKey.GetComponent<SpriteRenderer>().enabled = false;
                    levelNum = 2;
                }
            }

        }

        GameObject[] playersArray = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < playersArray.Length - 1; i++)
        {
            Destroy(playersArray[i]);
        }
        GameObject[] levelsContArray = GameObject.FindGameObjectsWithTag("levelController");
        for (int i = 0; i < levelsContArray.Length - 1; i++)
        {
            Destroy(levelsContArray[i]);
            recheckPlayer = false;
        }

    }//end void update
}
