using System;

public class Journal
{
    private int numberOfEmployees;

    public int NumberOfEmployees
    {
        get { return numberOfEmployees; }
        set { numberOfEmployees = value; }
    }

    public static Journal operator +(Journal journal, int increase)
    {
        journal.numberOfEmployees += increase;
        return journal;
    }

    public static Journal operator -(Journal journal, int decrease)
    {
        journal.numberOfEmployees -= decrease;
        return journal;
    }

    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees == journal2.numberOfEmployees;
    }

    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees != journal2.numberOfEmployees;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Journal))
            return false;

        Journal journal = (Journal)obj;
        return this.numberOfEmployees == journal.numberOfEmployees;
    }
}
