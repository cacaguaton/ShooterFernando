using System;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletUI;

    private Text _bulletsText;
    public Text  BulletsText
    {
        get{return _bulletsText;}
    }

    [SerializeField]
  private GameObject _gameOverUi;
  [SerializeField]
  private GameObject _gameWinUi;
 
 
 public void ShowBulletsUi(bool show)
 {
    _bulletUI.SetActive(show);
 
 }
  public void ShowGameOverUI(bool show)
 {
    _gameOverUi.SetActive(show);
 
 }
 public void ShowGameWinUI(bool show)
 {
   _gameWinUi.SetActive(show);
 
 }
}
