using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManagerMenuScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dataBoard;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(0);
    }
    public void DataBoardButton()
    {
        dataBoard.transform.GetChild(1).GetComponent<Text>().text = DataManager.Instance.totalShotBullet.ToString();
        dataBoard.transform.GetChild(2).GetComponent<Text>().text = DataManager.Instance.totalEnemyKilled.ToString();
        dataBoard.SetActive(true);
    }

}

