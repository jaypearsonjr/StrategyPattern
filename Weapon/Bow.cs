using System;

class Bow : IWeapon
{
    private string _weaponType;
    private string _weaponAction;
    public string weaponType
    {
        get{return _weaponType;}
    }
    public string weaponAction
    {
        get{return _weaponAction;}
    }
    public Bow()
    {
        _weaponAction = "Shoot";
        _weaponType = "Bow";
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
