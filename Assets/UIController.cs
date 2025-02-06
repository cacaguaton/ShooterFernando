using System;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletUI;

    private Text _bulletsUI;
    public Text  BulletsText;

    public void ShowBulletUI(bool show)
    {
        _bulletUI.SetActive(show);
    }
}
