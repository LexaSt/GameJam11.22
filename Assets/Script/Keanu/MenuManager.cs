using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject Menu;
      
    public BulletTime BulletTime;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuActivated();    
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MenuDeactivated();
        }
    }
    public void MenuActivated()
    {
        Cursor.lockState = CursorLockMode.Confined;
        BulletTime.gameObject.SetActive(false);
 
        Menu.SetActive(true);
        
        Time.timeScale = 0f;
    }

    public void MenuDeactivated()
    {
        Cursor.lockState = CursorLockMode.Locked;
        BulletTime.gameObject.SetActive(true);
        Menu.SetActive(false);

        Time.timeScale = 1f;
    }


    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
