﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button5 : MonoBehaviour
{

    // ボタンをクリックするとBattleSceneに移動します
    public void ButtonClicked()
    {
        SceneManager.LoadScene("Example_01");
    }
}
