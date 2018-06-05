using System;

interface ICharacter : IWeapon
{
    string characterType{get;}
    string displayType();
    void setWeapon(IWeapon weapon);

}