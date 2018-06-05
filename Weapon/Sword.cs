using System;

class Sword : IWeapon
{
    private string _weaponAction { get; set; }
    private string _weaponType { get; set; }
    public string weaponAction{ get{return _weaponAction;} }
    public string weaponType{ get{return _weaponType;} }
    public Sword()
    {
        _weaponAction = "Perry";
        _weaponType = "Sword";
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