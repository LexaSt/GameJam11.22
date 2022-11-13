using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeanuThrow : MonoBehaviour
{
    public GameObject BulletPref;
    [SerializeField] int _forceThrow=10;
    [SerializeField] Transform BulletMaker;
    public float ChangeForce;
    public ActionAnim ActionAnim;
    public Text ForceThrow;
    public GameObject Hint;
    private int _AddForce;
    private void Update()
    {
        ChangeForceMOde();
        ForceThrow.text ="���� ������ ��������� �����: " + (_AddForce +_forceThrow).ToString();
        //Debug.Log(Time.timeScale);
    }

    private void Shooting()
    {
        GameObject newBullet = Instantiate(BulletPref, BulletMaker.position, BulletMaker.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * (_forceThrow + _AddForce), ForceMode.Impulse);
        
        Destroy(newBullet, 10f);
        _AddForce = 0;
    }
    void ChangeForceMOde()
    {
        if (Time.timeScale <= 0.5f)
        {
            Hint.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1)) 
            {
                _AddForce += 6;
            }
        }
        else
        {
            Hint.SetActive(false);
        }
    }

}


