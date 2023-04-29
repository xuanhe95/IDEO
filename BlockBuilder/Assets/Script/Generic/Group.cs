using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Group<P, T>
{
    //public T Type;
    public Type<T> Type;
    public int ID;
    public List<Unit<P, T>> Units { get; set; }
    public Choice<T> Choices { get; set; }

    public Group(int id, Type<T> type)
    {
        //Type = types[0];
        Type = type;
        ID = id;
        Units = new List<Unit<P, T>>();

        //Debug.Log(Types);
    }

    public void AddUnit(Unit<P, T> unit)
    {
        Units.Add(unit);
        unit.Group = this;
    }

    public List<Type<T>> GetChoices()
    {
        return Choices.Types;
    }

    public int Size()
    {
        return Units.Count;
    }

    public T GetObject()
    {
        return Type.GetName();
    }

    public Unit<P, T> GetUnit(int id)
    {
        return Units[id];
    }

    public void Select(System.Random random)
    {
        Type = Choices.GetType(random.Next(Choices.Size()));
        for(int i = 0; i < 4; i++)
        {
            Units[i].SetType(Type.GetType(i));
        }
    }




}