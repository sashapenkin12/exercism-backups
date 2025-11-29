class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    
    public int RemainingMinutesInOven(int cur_minutes) => ExpectedMinutesInOven() - cur_minutes;

    public int PreparationTimeInMinutes(int layers_count) => 2 * layers_count;

    public int ElapsedTimeInMinutes(int layers_count, int cur_minutes) => cur_minutes + PreparationTimeInMinutes(layers_count);

    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
