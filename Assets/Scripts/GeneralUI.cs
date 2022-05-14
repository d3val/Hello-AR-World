using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralUI : MonoBehaviour
{
    public void ChangeScene(int sceneIndex)
    {
        GameManager.Instance.LoadScene(sceneIndex);
    }
}
