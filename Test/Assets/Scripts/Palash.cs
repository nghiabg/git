using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palash : MonoBehaviour
{
    int appStartedNumber;
    AsyncOperation progress = null;
    Image progressBar;
    float myProgress = 0;
    string sceneToLoad;
    // Use this for initialization
    void Start()
    {
        //		if(PlayerPrefs.HasKey("TutorialCompleted"))
        //		{

        sceneToLoad = "SampleScene";
        //		}
        //		else
        //			sceneToLoad = "TutorialLevel";

        progressBar = GameObject.Find("ProgressBar").GetComponent<Image>();
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            appStartedNumber = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            appStartedNumber = 0;
        }
        appStartedNumber++;
        PlayerPrefs.SetInt("appStartedNumber", appStartedNumber);
        StartCoroutine(LoadScene());
    }

    /// <summary>
    /// Coroutine koja ceka dok se ne inicijalizuje CrossPromotion, menja progres ucitavanja CrossPromotion-a, kao i progres ucitavanje scene, i taj progres se prikazuje u Update-u
    /// </summary>
    IEnumerator LoadScene()
    {

        progress = Application.LoadLevelAsync(sceneToLoad);
#pragma warning disable CS0618 // Type or member is obsolete

        yield return progress;

    }

    void Update()
    {
        if (progress != null && progress.progress > 0.49f)
        {
            progressBar.fillAmount = progress.progress;
        }

    }
}
