using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       onAndroidBackButtonClick();
    }

    public void ChangeScene(string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
        Debug.Log("berhasil pindah scene");
    }

    public void onExitClicked()
    {
        Application.Quit();
    }
    
    private void onAndroidBackButtonClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Homepage", LoadSceneMode.Single);
        }
    }
}
