using System;

class King : ICharacter
{
    private string _characterType;
    private IWeapon _weapon;
    private string _weaponAction;
    private string _weaponType;
    public string weaponType { get{return _weaponType;}}
    public string weaponAction {get{return _weaponAction;}}
    public string characterType {get{return _characterType;}}
    public King()
    {
        _characterType = "King";
        _weapon = new Sword();
    }

    public King(IWeapon weapon)
    {
        _characterType = "King";
        _weapon = weapon;
    }

    public string displayType()
    {
        return _characterType;
    }

    public void setWeapon(IWeapon weapon)
    {
        _weapon = weapon;
    }
    public string useWeapon()
    {
        return _weapon.useWeapon();
    }
}