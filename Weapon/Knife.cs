using System;

class Knife : IWeapon
{
    private string _weaponAction;
    private string _weaponType;
    public string weaponAction
    {
        get { return _weaponAction; }
    }
    public string weaponType
    {
        get { return _weaponType; }
    }
    public Knife()
    {
        _weaponAction = "Thrust";
        _weaponType = "Knife";
    }
    public string useWeapon()
    {
        string result = String.Format("The character has used the {0} to {1}.",
            this.weaponType, 
            this.weaponAction
        );
         
        return result;
    }
}
