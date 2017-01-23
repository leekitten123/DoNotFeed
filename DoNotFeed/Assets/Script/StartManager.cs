using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

    /** Start 버튼 클릭 시 게임을 시작한다. **/
    public void StartGame()
    {
        Application.LoadLevel("Stage1");   
    }
}
