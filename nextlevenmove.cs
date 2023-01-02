using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class nextlevenmove : MonoBehaviour
{
    public GameObject planse;
    public Slider slider;
    public void losnnextleven()
    {
        StartCoroutine(loadlevel());
    }

    IEnumerator loadlevel()
    {
        planse.SetActive(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex +1);

        while (!asyncOperation.isDone)
        {
            if (slider.value >= 0.9f)
            {
                slider.value = 1;
            }
            slider.value = asyncOperation.progress;
            yield return null;
        }
    }
}
