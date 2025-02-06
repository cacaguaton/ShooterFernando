using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _bulletPivot;

    [SerializeField]
    private Animator _weaponAnimator;

    [SerializeField]
    private int _maxBulletNumber = 20;

    [SerializeField]

    private int _cartridgeBulletsNumber = 5;

    private int _totalBulletNumber = 0;

    private int _currentBulletNumber = 0;


    private Text _bulletText;

    private GetWeapon _getWeapon;

    public void Shoot()
    {
        if(_currentBulletNumber == 0)
        {
            if(_totalBulletNumber == 0)
            {
                RemoveWeapon();
            }
            return;
        }

        _weaponAnimator.Play("Shoot", -1, 0f);
        GameObject.Instantiate(_bullet,_bulletPivot.position,_bulletPivot.rotation);
        _currentBulletNumber--;
        UptateBulletText();
        
        
    }

    private void RemoveWeapon()
    {
        _getWeapon.RemoveWeapon();
        _getWeapon = null;
    }

    public void PickUpWeapon(GetWeapon getWeapon)
    {
        _totalBulletNumber = _maxBulletNumber;
        _getWeapon =   getWeapon;
        Reoload();
        _weaponAnimator.Play("GetWeapon");
    
    }

    public void Reoload()
    {
        if(_currentBulletNumber == _cartridgeBulletsNumber ||  _totalBulletNumber == 0)
        {
            return;
        }
        int bulletsNeeded = _cartridgeBulletsNumber - _currentBulletNumber;
        if(_totalBulletNumber >= _cartridgeBulletsNumber )
        {
            _currentBulletNumber = bulletsNeeded;
        }else if(_totalBulletNumber > 0)
        {
            _currentBulletNumber = _totalBulletNumber;
        }
        _totalBulletNumber -= _currentBulletNumber;
        UptateBulletText();
        _weaponAnimator.Play("Reload");
    
    }

    private void UptateBulletText()
    {
        if(_bulletText == null)
        {
            _bulletText = GameObject.Find("BulletText").GetComponent<Text>();
        }
        _bulletText.text = _currentBulletNumber + "/" + _totalBulletNumber;
    }

}
