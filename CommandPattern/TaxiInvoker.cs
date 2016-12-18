namespace CommandPattern
{
    public class TaxiInvoker
    {
        private TaxiCommand _taxiCommand;

        public void SetCommand(TaxiCommand taxiCommand)
        {
            _taxiCommand = taxiCommand;
        }

        public void ExecuteCommand()
        {
            _taxiCommand.Execute();
        }
    }
}