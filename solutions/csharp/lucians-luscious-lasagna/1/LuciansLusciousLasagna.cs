class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    
    public int RemainingMinutesInOven(int cur_minutes)
    {
        return ExpectedMinutesInOven() - cur_minutes;
    }

    public int PreparationTimeInMinutes(int layers_count)
    {
        return 2 * layers_count;
    }

    public int ElapsedTimeInMinutes(int layers_count, int cur_minutes)
    {
        return cur_minutes + PreparationTimeInMinutes(layers_count);
    }
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
