namespace CommandPattern
{
    public class DriveCommand : TaxiCommand
    {
        private readonly TaxiFunction _taxiFunction;

        public DriveCommand(TaxiFunction taxtFunction)
        {
            _taxiFunction = taxtFunction;
        }

        public override void Execute()
        {
            _taxiFunction.Action();
        }
    }
}  